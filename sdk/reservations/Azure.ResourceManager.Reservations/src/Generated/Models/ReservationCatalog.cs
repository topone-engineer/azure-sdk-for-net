// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Reservations;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> Product details of a type of resource. </summary>
    public partial class ReservationCatalog
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

        /// <summary> Initializes a new instance of <see cref="ReservationCatalog"/>. </summary>
        internal ReservationCatalog()
        {
            BillingPlans = new ChangeTrackingDictionary<string, IList<ReservationBillingPlan>>();
            Terms = new ChangeTrackingList<ReservationTerm>();
            Locations = new ChangeTrackingList<AzureLocation>();
            SkuProperties = new ChangeTrackingList<SkuProperty>();
            Restrictions = new ChangeTrackingList<SkuRestriction>();
            Capabilities = new ChangeTrackingList<SkuCapability>();
        }

        /// <summary> Initializes a new instance of <see cref="ReservationCatalog"/>. </summary>
        /// <param name="appliedResourceType"> The type of resource the sku applies to. </param>
        /// <param name="skuName"> The name of sku. </param>
        /// <param name="billingPlans"> The billing plan options available for this sku. </param>
        /// <param name="terms"> Available reservation terms for this resource. </param>
        /// <param name="locations"></param>
        /// <param name="skuProperties"></param>
        /// <param name="msrp"> Pricing information about the sku. </param>
        /// <param name="restrictions"></param>
        /// <param name="tier"> The tier of this sku. </param>
        /// <param name="size"> The size of this sku. </param>
        /// <param name="capabilities"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ReservationCatalog(string appliedResourceType, string skuName, IReadOnlyDictionary<string, IList<ReservationBillingPlan>> billingPlans, IReadOnlyList<ReservationTerm> terms, IReadOnlyList<AzureLocation> locations, IReadOnlyList<SkuProperty> skuProperties, ReservationCatalogMsrp msrp, IReadOnlyList<SkuRestriction> restrictions, string tier, string size, IReadOnlyList<SkuCapability> capabilities, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppliedResourceType = appliedResourceType;
            SkuName = skuName;
            BillingPlans = billingPlans;
            Terms = terms;
            Locations = locations;
            SkuProperties = skuProperties;
            Msrp = msrp;
            Restrictions = restrictions;
            Tier = tier;
            Size = size;
            Capabilities = capabilities;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The type of resource the sku applies to. </summary>
        public string AppliedResourceType { get; }
        /// <summary> The name of sku. </summary>
        public string SkuName { get; }
        /// <summary> The billing plan options available for this sku. </summary>
        public IReadOnlyDictionary<string, IList<ReservationBillingPlan>> BillingPlans { get; }
        /// <summary> Available reservation terms for this resource. </summary>
        public IReadOnlyList<ReservationTerm> Terms { get; }
        /// <summary> Gets the locations. </summary>
        public IReadOnlyList<AzureLocation> Locations { get; }
        /// <summary> Gets the sku properties. </summary>
        public IReadOnlyList<SkuProperty> SkuProperties { get; }
        /// <summary> Pricing information about the sku. </summary>
        public ReservationCatalogMsrp Msrp { get; }
        /// <summary> Gets the restrictions. </summary>
        public IReadOnlyList<SkuRestriction> Restrictions { get; }
        /// <summary> The tier of this sku. </summary>
        public string Tier { get; }
        /// <summary> The size of this sku. </summary>
        public string Size { get; }
        /// <summary> Gets the capabilities. </summary>
        public IReadOnlyList<SkuCapability> Capabilities { get; }
    }
}
