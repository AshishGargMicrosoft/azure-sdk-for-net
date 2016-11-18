// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The parameters to list sas credentials of a storage account.
    /// </summary>
    public partial class AccountSasParameters
    {
        /// <summary>
        /// Initializes a new instance of the AccountSasParameters class.
        /// </summary>
        public AccountSasParameters() { }

        /// <summary>
        /// Initializes a new instance of the AccountSasParameters class.
        /// </summary>
        public AccountSasParameters(string services, string resourceTypes, string permissions, DateTime sharedAccessExpiryTime, string iPAddressOrRange = default(string), HttpProtocol? protocols = default(HttpProtocol?), DateTime? sharedAccessStartTime = default(DateTime?), string keyToSign = default(string))
        {
            Services = services;
            ResourceTypes = resourceTypes;
            Permissions = permissions;
            IPAddressOrRange = iPAddressOrRange;
            Protocols = protocols;
            SharedAccessStartTime = sharedAccessStartTime;
            SharedAccessExpiryTime = sharedAccessExpiryTime;
            KeyToSign = keyToSign;
        }

        /// <summary>
        /// Sets the signed services accessible with the account SAS. Possible
        /// values include: 'b', 'q', 't', 'f'
        /// </summary>
        [JsonProperty(PropertyName = "signedServices")]
        public string Services { get; set; }

        /// <summary>
        /// Sets the signed resource types that are accessible with the
        /// account SAS. Possible values include: 's', 'c', 'o'
        /// </summary>
        [JsonProperty(PropertyName = "signedResourceTypes")]
        public string ResourceTypes { get; set; }

        /// <summary>
        /// Sets the signed permissions for the account SAS. Possible values
        /// include: 'r', 'd', 'w', 'l', 'a', 'c', 'u', 'p'
        /// </summary>
        [JsonProperty(PropertyName = "signedPermission")]
        public string Permissions { get; set; }

        /// <summary>
        /// Sets an IP address or a range of IP addresses from which to accept
        /// requests.
        /// </summary>
        [JsonProperty(PropertyName = "signedIp")]
        public string IPAddressOrRange { get; set; }

        /// <summary>
        /// Sets the protocol permitted for a request made with the account
        /// SAS. Possible values include: 'https,http', 'https'
        /// </summary>
        [JsonProperty(PropertyName = "signedProtocol")]
        public HttpProtocol? Protocols { get; set; }

        /// <summary>
        /// Sets the time at which the SAS becomes valid.
        /// </summary>
        [JsonProperty(PropertyName = "signedStart")]
        public DateTime? SharedAccessStartTime { get; set; }

        /// <summary>
        /// Sets the time at which the shared access signature becomes invalid.
        /// </summary>
        [JsonProperty(PropertyName = "signedExpiry")]
        public DateTime SharedAccessExpiryTime { get; set; }

        /// <summary>
        /// Sets the key to sign the account SAS token with.
        /// </summary>
        [JsonProperty(PropertyName = "keyToSign")]
        public string KeyToSign { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public virtual void Validate()
        {
            if (Services == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Services");
            }
            if (ResourceTypes == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ResourceTypes");
            }
            if (Permissions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Permissions");
            }
        }
    }
}
