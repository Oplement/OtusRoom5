using System.ComponentModel.DataAnnotations;

namespace Shop.Microservice.Domain.Common
{
    /// <summary>
    /// Стутусы заказов
    /// </summary>
    public enum OrderStatus
    {
        [Display(Name = "В корзине")]
        InCart,

        [Display(Name = "В работе")]
        InProgress,

        [Display(Name = "Выдан")]
        Issued,
        
        [Display(Name = "Отменен")]
        Canceled,
    }
}
