// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.PolicyInsights;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary> The restrictions on a field imposed by a specific policy. </summary>
    public partial class FieldRestriction
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

        /// <summary> Initializes a new instance of <see cref="FieldRestriction"/>. </summary>
        internal FieldRestriction()
        {
            Values = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="FieldRestriction"/>. </summary>
        /// <param name="result"> The type of restriction that is imposed on the field. </param>
        /// <param name="defaultValue"> The value that policy will set for the field if the user does not provide a value. </param>
        /// <param name="values"> The values that policy either requires or denies for the field. </param>
        /// <param name="policy"> The details of the policy that is causing the field restriction. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FieldRestriction(FieldRestrictionResult? result, string defaultValue, IReadOnlyList<string> values, PolicyReference policy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Result = result;
            DefaultValue = defaultValue;
            Values = values;
            Policy = policy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of restriction that is imposed on the field. </summary>
        public FieldRestrictionResult? Result { get; }
        /// <summary> The value that policy will set for the field if the user does not provide a value. </summary>
        public string DefaultValue { get; }
        /// <summary> The values that policy either requires or denies for the field. </summary>
        public IReadOnlyList<string> Values { get; }
        /// <summary> The details of the policy that is causing the field restriction. </summary>
        public PolicyReference Policy { get; }
    }
}
