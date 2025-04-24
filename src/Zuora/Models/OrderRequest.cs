using System.ComponentModel.DataAnnotations;

namespace Zuora.WebAPI.Models
{
    /// <summary>
    /// Modelo de requisição para criação/atualização de pedidos
    /// </summary>
    public class OrderRequest
    {
        /// <summary>
        /// ID da conta associada ao pedido
        /// </summary>
        [Required(ErrorMessage = "O ID da conta é obrigatório")]
        public string AccountId { get; set; }

        /// <summary>
        /// Lista de itens do pedido
        /// </summary>
        [Required(ErrorMessage = "O pedido deve conter pelo menos um item")]
        [MinLength(1, ErrorMessage = "O pedido deve conter pelo menos um item")]
        public List<OrderItemRequest> Items { get; set; }

        /// <summary>
        /// Data de início do pedido
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Data de término do pedido
        /// </summary>
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Status do pedido
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Observações adicionais sobre o pedido
        /// </summary>
        public string Notes { get; set; }
    }

    /// <summary>
    /// Modelo de requisição para itens do pedido
    /// </summary>
    public class OrderItemRequest
    {
        /// <summary>
        /// ID do produto
        /// </summary>
        [Required(ErrorMessage = "O ID do produto é obrigatório")]
        public string ProductId { get; set; }

        /// <summary>
        /// Quantidade do item
        /// </summary>
        [Range(1, int.MaxValue, ErrorMessage = "A quantidade deve ser maior que zero")]
        public int Quantity { get; set; }

        /// <summary>
        /// Preço unitário do item
        /// </summary>
        [Range(0, double.MaxValue, ErrorMessage = "O preço unitário deve ser maior ou igual a zero")]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Desconto aplicado ao item
        /// </summary>
        [Range(0, 100, ErrorMessage = "O desconto deve estar entre 0 e 100")]
        public decimal Discount { get; set; }

        /// <summary>
        /// Observações adicionais sobre o item
        /// </summary>
        public string Notes { get; set; }
    }
} 