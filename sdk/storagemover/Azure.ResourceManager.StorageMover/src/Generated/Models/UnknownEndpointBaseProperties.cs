// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.StorageMover.Models
{
    /// <summary> Unknown version of EndpointBaseProperties. </summary>
    internal partial class UnknownEndpointBaseProperties : EndpointBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownEndpointBaseProperties"/>. </summary>
        /// <param name="endpointType"> The Endpoint resource type. </param>
        /// <param name="description"> A description for the Endpoint. </param>
        /// <param name="provisioningState"> The provisioning state of this resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownEndpointBaseProperties(EndpointType endpointType, string description, StorageMoverProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(endpointType, description, provisioningState, serializedAdditionalRawData)
        {
            EndpointType = endpointType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownEndpointBaseProperties"/> for deserialization. </summary>
        internal UnknownEndpointBaseProperties()
        {
        }
    }
}
