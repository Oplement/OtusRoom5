using Authorization.Microservice.Core.JWTSettings;
using Authorization.Microservice.Domain;
using Authorization.Microservice.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace Authorization.Microservice.Core.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthController : Controller
    {
        private readonly AuthService _service;

        public AuthController(AuthService service)
        {
            _service = service;
        }

        /// <summary>
        /// Проверка токена юзера на валидность
        /// В Header "Authorization" передаем "Bearer {token}"
        /// </summary>
        /// <returns></returns>
        [HttpGet("isValid", Name = "isValid")]
        public async Task<IActionResult> IsValid()
        {
            if (User.Identity is not null && User.Identity.IsAuthenticated)
            {
                return Ok();
            }
            return Unauthorized();
        }

        /// <summary>
        /// Авторизация пользователя и отправка токена в ответ
        /// Передаем email и password с формы в Body(json)
        /// </summary>
        /// <returns>JWT Токен</returns>
        [HttpPost("login", Name = "login")]
        public async Task<IActionResult> Login([FromBody] LoginModel loginData)
        {
            User person = await _service.GetByEmailAsync(loginData.Email);

            if (person is null) return BadRequest("Пользователь с таким Email не найден");

            var hash = await _service.Hash(loginData.Password);

            if (person.PasswordHash != hash) return Unauthorized("Неверный логин или пароль");

            var jwt = AuthOptions.GenerateToken(person);
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);

            var response = new
            {
                access_token = encodedJwt,
                username = person.Email
            };

            return Json(response);
        }

        /// <summary>
        /// Регистрация пользователя и отправка токена в ответ
        ///  В Header "Authorization" передаем "Bearer {token}"
        /// </summary>
        /// <returns>Email, Role</returns>
        [Authorize(AuthenticationSchemes = "Bearer")]
        [HttpGet("getUserInfo", Name = "getUserInfo")]
        public async Task<IActionResult> GetUserInfo()
        {
            var username = User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Name);
            var email = User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Email);
            var role = User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Role);

            var user = _service.GetByEmailAsync(email.Value.ToString()).Result;
            var response = new
            {

                id = user?.Id,
                userphoto = user?.ImagePath,
                username = username.Value,
                role = role.Value,

                // нужно забрать с БД
                balance= "",
                forSend = "",
            };

            return Ok(response);
        }

        /// <summary>
        /// Получение информации об авторизованном пользователе
        /// Передаем username, email, password и role с формы в Body(json)
        /// </summary>
        /// <returns>JWT Токен</returns>
        [HttpPost("register", Name = "register")]
        public async Task<IActionResult> Register([FromBody] RegisterModel registerData)
        { 
            var person = await _service.GetByEmailAsync(registerData.Email);

            if (person != null) return BadRequest("Пользователь с таким Email уже существует");

            var hash = await _service.Hash(registerData.Password);
            person = new User() { Email = registerData.Email, PasswordHash = hash, Username = registerData.Username, Role = "user" };

            await _service.CreateAsync(person);

            var jwt = AuthOptions.GenerateToken(person);
            var encodedJwt = new JwtSecurityTokenHandler().WriteToken(jwt);


            var response = new
            {
                access_token = encodedJwt,
                username = person.Email
            };

            return Ok(response);
        }

    }


}
