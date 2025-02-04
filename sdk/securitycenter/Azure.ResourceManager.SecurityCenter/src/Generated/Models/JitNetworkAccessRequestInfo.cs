// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The JitNetworkAccessRequestInfo. </summary>
    public partial class JitNetworkAccessRequestInfo
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

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessRequestInfo"/>. </summary>
        /// <param name="virtualMachines"></param>
        /// <param name="startOn"> The start time of the request in UTC. </param>
        /// <param name="requestor"> The identity of the person who made the request. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachines"/> or <paramref name="requestor"/> is null. </exception>
        public JitNetworkAccessRequestInfo(IEnumerable<JitNetworkAccessRequestVirtualMachine> virtualMachines, DateTimeOffset startOn, string requestor)
        {
            Argument.AssertNotNull(virtualMachines, nameof(virtualMachines));
            Argument.AssertNotNull(requestor, nameof(requestor));

            VirtualMachines = virtualMachines.ToList();
            StartOn = startOn;
            Requestor = requestor;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessRequestInfo"/>. </summary>
        /// <param name="virtualMachines"></param>
        /// <param name="startOn"> The start time of the request in UTC. </param>
        /// <param name="requestor"> The identity of the person who made the request. </param>
        /// <param name="justification"> The justification for making the initiate request. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitNetworkAccessRequestInfo(IList<JitNetworkAccessRequestVirtualMachine> virtualMachines, DateTimeOffset startOn, string requestor, string justification, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            VirtualMachines = virtualMachines;
            StartOn = startOn;
            Requestor = requestor;
            Justification = justification;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessRequestInfo"/> for deserialization. </summary>
        internal JitNetworkAccessRequestInfo()
        {
        }

        /// <summary> Gets the virtual machines. </summary>
        public IList<JitNetworkAccessRequestVirtualMachine> VirtualMachines { get; }
        /// <summary> The start time of the request in UTC. </summary>
        public DateTimeOffset StartOn { get; set; }
        /// <summary> The identity of the person who made the request. </summary>
        public string Requestor { get; set; }
        /// <summary> The justification for making the initiate request. </summary>
        public string Justification { get; set; }
    }
}
