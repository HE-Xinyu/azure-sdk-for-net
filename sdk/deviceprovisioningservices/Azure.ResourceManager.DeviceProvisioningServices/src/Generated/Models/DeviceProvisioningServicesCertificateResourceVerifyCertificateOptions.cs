// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DeviceProvisioningServices.Models
{
    /// <summary> The DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions. </summary>
    public partial class DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions
    {
        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions"/>. </summary>
        /// <param name="ifMatch"> ETag of the certificate. </param>
        /// <param name="content"> The name of the certificate. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="ifMatch"/> or <paramref name="content"/> is null. </exception>
        public DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions(string ifMatch, CertificateVerificationCodeContent content)
        {
            if (ifMatch == null)
            {
                throw new ArgumentNullException(nameof(ifMatch));
            }
            if (content == null)
            {
                throw new ArgumentNullException(nameof(content));
            }

            IfMatch = ifMatch;
            Content = content;
        }

        /// <summary> Initializes a new instance of <see cref="DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions"/> for deserialization. </summary>
        internal DeviceProvisioningServicesCertificateResourceVerifyCertificateOptions()
        {
        }

        /// <summary> ETag of the certificate. </summary>
        public string IfMatch { get; }
        /// <summary> The name of the certificate. </summary>
        public CertificateVerificationCodeContent Content { get; }
        /// <summary> Common Name for the certificate. </summary>
        public string CertificateCommonName { get; set; }
        /// <summary> Raw data of certificate. </summary>
        public byte[] CertificateRawBytes { get; set; }
        /// <summary> Indicates if the certificate has been verified by owner of the private key. </summary>
        public bool? CertificateIsVerified { get; set; }
        /// <summary> Describe the purpose of the certificate. </summary>
        public DeviceProvisioningServicesCertificatePurpose? CertificatePurpose { get; set; }
        /// <summary> Certificate creation time. </summary>
        public DateTimeOffset? CertificateCreatedOn { get; set; }
        /// <summary> Certificate last updated time. </summary>
        public DateTimeOffset? CertificateLastUpdatedOn { get; set; }
        /// <summary> Indicates if the certificate contains private key. </summary>
        public bool? CertificateHasPrivateKey { get; set; }
        /// <summary> Random number generated to indicate Proof of Possession. </summary>
        public string CertificateNonce { get; set; }
    }
}
