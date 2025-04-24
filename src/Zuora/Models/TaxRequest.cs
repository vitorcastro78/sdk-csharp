using System.ComponentModel.DataAnnotations;

namespace Zuora.WebAPI.Models
{
    /// <summary>
    /// Classe que representa os dados de entrada para criação ou atualização de um imposto
    /// </summary>
    public class TaxRequest
    {
        /// <summary>
        /// Nome do imposto
        /// </summary>
        [Required(ErrorMessage = "O nome do imposto é obrigatório.")]
        [StringLength(100, ErrorMessage = "O nome do imposto não pode ter mais de 100 caracteres.")]
        public string Name { get; set; }

        /// <summary>
        /// Código do imposto
        /// </summary>
        [Required(ErrorMessage = "O código do imposto é obrigatório.")]
        [StringLength(20, ErrorMessage = "O código do imposto não pode ter mais de 20 caracteres.")]
        public string Code { get; set; }

        /// <summary>
        /// Taxa do imposto em porcentagem
        /// </summary>
        [Required(ErrorMessage = "A taxa do imposto é obrigatória.")]
        [Range(0, 100, ErrorMessage = "A taxa do imposto deve estar entre 0 e 100.")]
        public decimal Rate { get; set; }

        /// <summary>
        /// Descrição do imposto
        /// </summary>
        [StringLength(500, ErrorMessage = "A descrição do imposto não pode ter mais de 500 caracteres.")]
        public string Description { get; set; }

        /// <summary>
        /// Indica se o imposto está ativo
        /// </summary>
        public bool IsActive { get; set; } = true;

        /// <summary>
        /// Código do país onde o imposto é aplicável
        /// </summary>
        [StringLength(2, ErrorMessage = "O código do país deve ter 2 caracteres.")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Código do estado onde o imposto é aplicável
        /// </summary>
        [StringLength(2, ErrorMessage = "O código do estado deve ter 2 caracteres.")]
        public string StateCode { get; set; }
    }
} 