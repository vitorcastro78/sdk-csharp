using System;

namespace Zuora.WebAPI.Models
{
    /// <summary>
    /// Classe que representa os dados de saída de um imposto
    /// </summary>
    public class TaxResponse
    {
        /// <summary>
        /// ID do imposto
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Nome do imposto
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Código do imposto
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// Taxa do imposto em porcentagem
        /// </summary>
        public decimal Rate { get; set; }

        /// <summary>
        /// Descrição do imposto
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Indica se o imposto está ativo
        /// </summary>
        public bool IsActive { get; set; }

        /// <summary>
        /// Código do país onde o imposto é aplicável
        /// </summary>
        public string CountryCode { get; set; }

        /// <summary>
        /// Código do estado onde o imposto é aplicável
        /// </summary>
        public string StateCode { get; set; }

        /// <summary>
        /// Data de criação do imposto
        /// </summary>
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Data da última atualização do imposto
        /// </summary>
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// ID do usuário que criou o imposto
        /// </summary>
        public string CreatedBy { get; set; }

        /// <summary>
        /// ID do usuário que atualizou o imposto pela última vez
        /// </summary>
        public string UpdatedBy { get; set; }
    }
} 