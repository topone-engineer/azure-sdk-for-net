// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.IotCentral;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> Network Rule Set Properties of this IoT Central application. </summary>
    public partial class IotCentralNetworkRuleSets
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

        /// <summary> Initializes a new instance of <see cref="IotCentralNetworkRuleSets"/>. </summary>
        public IotCentralNetworkRuleSets()
        {
            IPRules = new ChangeTrackingList<IotCentralNetworkRuleSetIPRule>();
        }

        /// <summary> Initializes a new instance of <see cref="IotCentralNetworkRuleSets"/>. </summary>
        /// <param name="applyToDevices"> Whether these rules apply for device connectivity to IoT Hub and Device Provisioning service associated with this application. </param>
        /// <param name="applyToIotCentral"> Whether these rules apply for connectivity via IoT Central web portal and APIs. </param>
        /// <param name="defaultAction"> The default network action to apply. </param>
        /// <param name="ipRules"> List of IP rules. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal IotCentralNetworkRuleSets(bool? applyToDevices, bool? applyToIotCentral, IotCentralNetworkAction? defaultAction, IList<IotCentralNetworkRuleSetIPRule> ipRules, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ApplyToDevices = applyToDevices;
            ApplyToIotCentral = applyToIotCentral;
            DefaultAction = defaultAction;
            IPRules = ipRules;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Whether these rules apply for device connectivity to IoT Hub and Device Provisioning service associated with this application. </summary>
        public bool? ApplyToDevices { get; set; }
        /// <summary> Whether these rules apply for connectivity via IoT Central web portal and APIs. </summary>
        public bool? ApplyToIotCentral { get; set; }
        /// <summary> The default network action to apply. </summary>
        public IotCentralNetworkAction? DefaultAction { get; set; }
        /// <summary> List of IP rules. </summary>
        public IList<IotCentralNetworkRuleSetIPRule> IPRules { get; }
    }
}
