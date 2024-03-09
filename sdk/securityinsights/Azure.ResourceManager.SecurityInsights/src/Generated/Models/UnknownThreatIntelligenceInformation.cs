// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> Unknown version of ThreatIntelligenceInformation. </summary>
    internal partial class UnknownThreatIntelligenceInformation : SecurityInsightsThreatIntelligenceIndicatorBaseData
    {
        /// <summary> Initializes a new instance of <see cref="UnknownThreatIntelligenceInformation"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> The kind of the entity. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownThreatIntelligenceInformation(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ThreatIntelligenceResourceInnerKind kind, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, kind, etag, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownThreatIntelligenceInformation"/> for deserialization. </summary>
        internal UnknownThreatIntelligenceInformation()
        {
        }
    }
}
