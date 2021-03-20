﻿// -----------------------------------------------------------------
// <copyright file="KeyVaultSecretsProviderOptions.cs" company="2Dudes">
// Copyright (c) | Jose L. Nunez de Caceres et al.
// https://linkedin.com/in/nunezdecaceres
//
// All Rights Reserved.
//
// Licensed under the MIT License. See LICENSE in the project root for license information.
// </copyright>
// -----------------------------------------------------------------

namespace Fibula.Providers.Azure
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// Class that represents options for the Azure Key Vault secrets provider configuration.
    /// </summary>
    public class KeyVaultSecretsProviderOptions
    {
        /// <summary>
        /// Gets or sets the base url for the Key Vault.
        /// </summary>
        [Required(ErrorMessage = "A Key Vault URL is required.")]
        [Url(ErrorMessage = "An invalid URL was not supplied.")]
        public string VaultBaseUrl { get; set; }

        /// <summary>
        /// Gets or sets the id of the tenant in Azure.
        /// </summary>
        [Required(ErrorMessage = "An Azure tenant id is required.")]
        public string AzureTenantId { get; set; }
    }
}
