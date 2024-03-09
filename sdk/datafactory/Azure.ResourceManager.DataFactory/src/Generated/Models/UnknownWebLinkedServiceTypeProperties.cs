// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core.Expressions.DataFactory;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Unknown version of WebLinkedServiceTypeProperties. </summary>
    internal partial class UnknownWebLinkedServiceTypeProperties : WebLinkedServiceTypeProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownWebLinkedServiceTypeProperties"/>. </summary>
        /// <param name="uri"> The URL of the web service endpoint, e.g. https://www.microsoft.com . Type: string (or Expression with resultType string). </param>
        /// <param name="authenticationType"> Type of authentication used to connect to the web table source. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownWebLinkedServiceTypeProperties(DataFactoryElement<string> uri, WebAuthenticationType authenticationType, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(uri, authenticationType, serializedAdditionalRawData)
        {
            AuthenticationType = authenticationType;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownWebLinkedServiceTypeProperties"/> for deserialization. </summary>
        internal UnknownWebLinkedServiceTypeProperties()
        {
        }
    }
}
