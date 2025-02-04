// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.DnsResolver;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.DnsResolver.Models
{
    /// <summary> IP configuration. </summary>
    public partial class InboundEndpointIPConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="InboundEndpointIPConfiguration"/>. </summary>
        /// <param name="subnet"> The reference to the subnet bound to the IP configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subnet"/> is null. </exception>
        public InboundEndpointIPConfiguration(WritableSubResource subnet)
        {
            Argument.AssertNotNull(subnet, nameof(subnet));

            Subnet = subnet;
        }

        /// <summary> Initializes a new instance of <see cref="InboundEndpointIPConfiguration"/>. </summary>
        /// <param name="subnet"> The reference to the subnet bound to the IP configuration. </param>
        /// <param name="privateIPAddress"> Private IP address of the IP configuration. </param>
        /// <param name="privateIPAllocationMethod"> Private IP address allocation method. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal InboundEndpointIPConfiguration(WritableSubResource subnet, IPAddress privateIPAddress, InboundEndpointIPAllocationMethod? privateIPAllocationMethod, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Subnet = subnet;
            PrivateIPAddress = privateIPAddress;
            PrivateIPAllocationMethod = privateIPAllocationMethod;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="InboundEndpointIPConfiguration"/> for deserialization. </summary>
        internal InboundEndpointIPConfiguration()
        {
        }

        /// <summary> The reference to the subnet bound to the IP configuration. </summary>
        internal WritableSubResource Subnet { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier SubnetId
        {
            get => Subnet is null ? default : Subnet.Id;
            set
            {
                if (Subnet is null)
                    Subnet = new WritableSubResource();
                Subnet.Id = value;
            }
        }

        /// <summary> Private IP address of the IP configuration. </summary>
        public IPAddress PrivateIPAddress { get; set; }
        /// <summary> Private IP address allocation method. </summary>
        public InboundEndpointIPAllocationMethod? PrivateIPAllocationMethod { get; set; }
    }
}
