﻿using Authorization.Microservice.Core.JWTSettings;
using Authorization.Microservice.Domain.Entities;
using Authorization.Microservice.Infrastructure.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

            if (person.Password != loginData.Password) return Unauthorized("Неверный логин или пароль");

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
            var name = User.Claims.FirstOrDefault(m=>m.Type == ClaimTypes.Name);
            var role = User.Claims.FirstOrDefault(m => m.Type == ClaimTypes.Role);

            var response = new
            {
                name = name.Value,
                role = role.Value
            };

            return Ok(response);
        }

        /// <summary>
        /// Получение информации об авторизованном пользователе
        /// Передаем username, email, password и role с формы в Body(json)
        /// </summary>
        /// <returns>JWT Токен</returns>
        [HttpPost("register", Name = "register")]
        public async Task<IActionResult> GetUserInfo([FromBody] RegisterModel registerData)
        {
            var person = await _service.GetByEmailAsync(registerData.Email);

            if (person != null) return BadRequest("Пользователь с таким Email уже существует");

            person = new User() { Email = registerData.Email, Password = registerData.Password, Username = registerData.Username, Role = "user" };

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