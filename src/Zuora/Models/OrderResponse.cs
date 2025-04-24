using System;

namespace Zuora.WebAPI.Models
{
    /// <summary>
    /// Modelo de resposta para pedidos
    /// </summary>
    public class OrderResponse
    {
        /// <summary>
        /// ID do pedido
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ID da conta associada ao pedido
        /// </summary>
        public string AccountId { get; set; }

        /// <summary>
        /// Número do pedido
        /// </summary>
        public string OrderNumber { get; set; }

        /// <summary>
        /// Lista de itens do pedido
        /// </summary>
        public List<OrderItemResponse> Items { get; set; }

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
        /// Valor total do pedido
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Valor total de descontos
        /// </summary>
        public decimal TotalDiscount { get; set; }

        /// <summary>
        /// Valor total após descontos
        /// </summary>
        public decimal NetAmount { get; set; }

        /// <summary>
        /// Observações adicionais sobre o pedido
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Data de criação do pedido
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Data da última atualização do pedido
        /// </summary>
        public DateTime UpdatedAt { get; set; }
    }

    /// <summary>
    /// Modelo de resposta para itens do pedido
    /// </summary>
    public class OrderItemResponse
    {
        /// <summary>
        /// ID do item
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// ID do produto
        /// </summary>
        public string ProductId { get; set; }

        /// <summary>
        /// Nome do produto
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// Quantidade do item
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Preço unitário do item
        /// </summary>
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// Desconto aplicado ao item
        /// </summary>
        public decimal Discount { get; set; }

        /// <summary>
        /// Valor total do item
        /// </summary>
        public decimal TotalAmount { get; set; }

        /// <summary>
        /// Valor líquido do item (após desconto)
        /// </summary>
        public decimal NetAmount { get; set; }

        /// <summary>
        /// Observações adicionais sobre o item
        /// </summary>
        public string Notes { get; set; }
    }
} 