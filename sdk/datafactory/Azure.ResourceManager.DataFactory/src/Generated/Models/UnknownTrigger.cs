// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Unknown version of Trigger. </summary>
    internal partial class UnknownTrigger : DataFactoryTriggerProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTrigger"/>. </summary>
        /// <param name="triggerType"> Trigger type. </param>
        /// <param name="description"> Trigger description. </param>
        /// <param name="runtimeState"> Indicates if trigger is running or not. Updated when Start/Stop APIs are called on the Trigger. </param>
        /// <param name="annotations"> List of tags that can be used for describing the trigger. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal UnknownTrigger(string triggerType, string description, DataFactoryTriggerRuntimeState? runtimeState, IList<BinaryData> annotations, IDictionary<string, BinaryData> additionalProperties) : base(triggerType, description, runtimeState, annotations, additionalProperties)
        {
            TriggerType = triggerType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTrigger"/> for deserialization. </summary>
        internal UnknownTrigger()
        {
        }
    }
}
