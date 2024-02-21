// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Web activity authentication properties. </summary>
    public partial class WebActivityAuthentication
    {
        /// <summary> Initializes a new instance of <see cref="WebActivityAuthentication"/>. </summary>
        /// <param name="type"> Web activity authentication (Basic/ClientCertificate/MSI). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="type"/> is null. </exception>
        public WebActivityAuthentication(string type)
        {
            if (type == null)
            {
                throw new ArgumentNullException(nameof(type));
            }

            Type = type;
        }

        /// <summary> Initializes a new instance of <see cref="WebActivityAuthentication"/>. </summary>
        /// <param name="type"> Web activity authentication (Basic/ClientCertificate/MSI). </param>
        /// <param name="pfx">
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="username"> Web activity authentication user name for basic authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="password">
        /// Password for the PFX file or basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </param>
        /// <param name="resource"> Resource for which Azure Auth token will be requested when using MSI Authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="userTenant"> TenantId for which Azure Auth token will be requested when using ServicePrincipal Authentication. Type: string (or Expression with resultType string). </param>
        /// <param name="credential"> The credential reference containing authentication information. </param>
        internal WebActivityAuthentication(string type, SecretBase pfx, object username, SecretBase password, object resource, object userTenant, CredentialReference credential)
        {
            Type = type;
            Pfx = pfx;
            Username = username;
            Password = password;
            Resource = resource;
            UserTenant = userTenant;
            Credential = credential;
        }

        /// <summary> Web activity authentication (Basic/ClientCertificate/MSI). </summary>
        public string Type { get; set; }
        /// <summary>
        /// Base64-encoded contents of a PFX file.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Pfx { get; set; }
        /// <summary> Web activity authentication user name for basic authentication. Type: string (or Expression with resultType string). </summary>
        public object Username { get; set; }
        /// <summary>
        /// Password for the PFX file or basic authentication.
        /// Please note <see cref="SecretBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AzureKeyVaultSecretReference"/> and <see cref="SecureString"/>.
        /// </summary>
        public SecretBase Password { get; set; }
        /// <summary> Resource for which Azure Auth token will be requested when using MSI Authentication. Type: string (or Expression with resultType string). </summary>
        public object Resource { get; set; }
        /// <summary> TenantId for which Azure Auth token will be requested when using ServicePrincipal Authentication. Type: string (or Expression with resultType string). </summary>
        public object UserTenant { get; set; }
        /// <summary> The credential reference containing authentication information. </summary>
        public CredentialReference Credential { get; set; }
    }
}
