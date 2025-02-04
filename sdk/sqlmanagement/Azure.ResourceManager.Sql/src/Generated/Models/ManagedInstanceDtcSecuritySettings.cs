// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The Security Settings of managed instance DTC. </summary>
    public partial class ManagedInstanceDtcSecuritySettings
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

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcSecuritySettings"/>. </summary>
        public ManagedInstanceDtcSecuritySettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcSecuritySettings"/>. </summary>
        /// <param name="transactionManagerCommunicationSettings"> Transaction Manager communication settings of managed instance DTC. </param>
        /// <param name="isXATransactionsEnabled"> Allow XA Transactions to managed instance DTC. </param>
        /// <param name="snaLu6Point2TransactionsEnabled"> Allow SNA LU 6.2 Transactions to managed instance DTC. </param>
        /// <param name="xaTransactionsDefaultTimeoutInSeconds"> Default timeout for XA Transactions (in seconds). </param>
        /// <param name="xaTransactionsMaximumTimeoutInSeconds"> Maximum timeout for XA Transactions (in seconds). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceDtcSecuritySettings(ManagedInstanceDtcTransactionManagerCommunicationSettings transactionManagerCommunicationSettings, bool? isXATransactionsEnabled, bool? snaLu6Point2TransactionsEnabled, int? xaTransactionsDefaultTimeoutInSeconds, int? xaTransactionsMaximumTimeoutInSeconds, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            TransactionManagerCommunicationSettings = transactionManagerCommunicationSettings;
            IsXATransactionsEnabled = isXATransactionsEnabled;
            SnaLu6Point2TransactionsEnabled = snaLu6Point2TransactionsEnabled;
            XATransactionsDefaultTimeoutInSeconds = xaTransactionsDefaultTimeoutInSeconds;
            XATransactionsMaximumTimeoutInSeconds = xaTransactionsMaximumTimeoutInSeconds;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Transaction Manager communication settings of managed instance DTC. </summary>
        public ManagedInstanceDtcTransactionManagerCommunicationSettings TransactionManagerCommunicationSettings { get; set; }
        /// <summary> Allow XA Transactions to managed instance DTC. </summary>
        public bool? IsXATransactionsEnabled { get; set; }
        /// <summary> Allow SNA LU 6.2 Transactions to managed instance DTC. </summary>
        public bool? SnaLu6Point2TransactionsEnabled { get; set; }
        /// <summary> Default timeout for XA Transactions (in seconds). </summary>
        public int? XATransactionsDefaultTimeoutInSeconds { get; set; }
        /// <summary> Maximum timeout for XA Transactions (in seconds). </summary>
        public int? XATransactionsMaximumTimeoutInSeconds { get; set; }
    }
}
