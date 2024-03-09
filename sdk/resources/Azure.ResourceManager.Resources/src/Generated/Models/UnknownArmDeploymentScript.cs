// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Unknown version of ArmDeploymentScript. </summary>
    internal partial class UnknownArmDeploymentScript : ArmDeploymentScriptData
    {
        /// <summary> Initializes a new instance of <see cref="UnknownArmDeploymentScript"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="identity"> Optional property. Managed identity to be used for this deployment script. Currently, only user-assigned MSI is supported. </param>
        /// <param name="location"> The location of the ACI and the storage account for the deployment script. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <param name="kind"> Type of the script. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownArmDeploymentScript(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ArmDeploymentScriptManagedIdentity identity, AzureLocation location, IDictionary<string, string> tags, ScriptType kind, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, identity, location, tags, kind, serializedAdditionalRawData)
        {
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownArmDeploymentScript"/> for deserialization. </summary>
        internal UnknownArmDeploymentScript()
        {
        }
    }
}
