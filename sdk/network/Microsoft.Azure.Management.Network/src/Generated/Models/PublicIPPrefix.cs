// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Public IP prefix resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PublicIPPrefix : Resource
    {
        /// <summary>
        /// Initializes a new instance of the PublicIPPrefix class.
        /// </summary>
        public PublicIPPrefix()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PublicIPPrefix class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="sku">The public IP prefix SKU.</param>
        /// <param name="publicIPAddressVersion">The public IP address version.
        /// Possible values include: 'IPv4', 'IPv6'</param>
        /// <param name="ipTags">The list of tags associated with the public IP
        /// prefix.</param>
        /// <param name="prefixLength">The Length of the Public IP
        /// Prefix.</param>
        /// <param name="ipPrefix">The allocated Prefix.</param>
        /// <param name="publicIPAddresses">The list of all referenced
        /// PublicIPAddresses.</param>
        /// <param name="loadBalancerFrontendIpConfiguration">The reference to
        /// load balancer frontend IP configuration associated with the public
        /// IP prefix.</param>
        /// <param name="resourceGuid">The resource GUID property of the public
        /// IP prefix resource.</param>
        /// <param name="provisioningState">The provisioning state of the
        /// Public IP prefix resource. Possible values are: 'Updating',
        /// 'Deleting', and 'Failed'.</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        /// <param name="zones">A list of availability zones denoting the IP
        /// allocated for the resource needs to come from.</param>
        public PublicIPPrefix(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), PublicIPPrefixSku sku = default(PublicIPPrefixSku), string publicIPAddressVersion = default(string), IList<IpTag> ipTags = default(IList<IpTag>), int? prefixLength = default(int?), string ipPrefix = default(string), IList<ReferencedPublicIpAddress> publicIPAddresses = default(IList<ReferencedPublicIpAddress>), SubResource loadBalancerFrontendIpConfiguration = default(SubResource), string resourceGuid = default(string), string provisioningState = default(string), string etag = default(string), IList<string> zones = default(IList<string>))
            : base(id, name, type, location, tags)
        {
            Sku = sku;
            PublicIPAddressVersion = publicIPAddressVersion;
            IpTags = ipTags;
            PrefixLength = prefixLength;
            IpPrefix = ipPrefix;
            PublicIPAddresses = publicIPAddresses;
            LoadBalancerFrontendIpConfiguration = loadBalancerFrontendIpConfiguration;
            ResourceGuid = resourceGuid;
            ProvisioningState = provisioningState;
            Etag = etag;
            Zones = zones;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the public IP prefix SKU.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public PublicIPPrefixSku Sku { get; set; }

        /// <summary>
        /// Gets or sets the public IP address version. Possible values
        /// include: 'IPv4', 'IPv6'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddressVersion")]
        public string PublicIPAddressVersion { get; set; }

        /// <summary>
        /// Gets or sets the list of tags associated with the public IP prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipTags")]
        public IList<IpTag> IpTags { get; set; }

        /// <summary>
        /// Gets or sets the Length of the Public IP Prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.prefixLength")]
        public int? PrefixLength { get; set; }

        /// <summary>
        /// Gets or sets the allocated Prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipPrefix")]
        public string IpPrefix { get; set; }

        /// <summary>
        /// Gets or sets the list of all referenced PublicIPAddresses.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicIPAddresses")]
        public IList<ReferencedPublicIpAddress> PublicIPAddresses { get; set; }

        /// <summary>
        /// Gets the reference to load balancer frontend IP configuration
        /// associated with the public IP prefix.
        /// </summary>
        [JsonProperty(PropertyName = "properties.loadBalancerFrontendIpConfiguration")]
        public SubResource LoadBalancerFrontendIpConfiguration { get; private set; }

        /// <summary>
        /// Gets or sets the resource GUID property of the public IP prefix
        /// resource.
        /// </summary>
        [JsonProperty(PropertyName = "properties.resourceGuid")]
        public string ResourceGuid { get; set; }

        /// <summary>
        /// Gets or sets the provisioning state of the Public IP prefix
        /// resource. Possible values are: 'Updating', 'Deleting', and
        /// 'Failed'.
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets a unique read-only string that changes whenever the
        /// resource is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; set; }

        /// <summary>
        /// Gets or sets a list of availability zones denoting the IP allocated
        /// for the resource needs to come from.
        /// </summary>
        [JsonProperty(PropertyName = "zones")]
        public IList<string> Zones { get; set; }

    }
}
