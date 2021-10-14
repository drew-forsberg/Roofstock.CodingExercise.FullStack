using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Property
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [JsonPropertyName("accountId")]
        public int AccountId { get; set; }

        [JsonPropertyName("buyerAccountId")]
        public int? BuyerAccountId { get; set; }

        [JsonPropertyName("buyerUserId")]
        public int? BuyerUserId { get; set; }

        [JsonPropertyName("externalId")]
        public object ExternalId { get; set; }

        [JsonPropertyName("programId")]
        public object ProgramId { get; set; }

        [JsonPropertyName("isDwellCertified")]
        public bool IsDwellCertified { get; set; }

        [JsonPropertyName("isAllowOffer")]
        public bool IsAllowOffer { get; set; }

        [JsonPropertyName("isAllowPreview")]
        public bool IsAllowPreview { get; set; }

        [JsonPropertyName("isFeatured")]
        public bool IsFeatured { get; set; }

        [JsonPropertyName("isRentGuaranteed")]
        public bool IsRentGuaranteed { get; set; }

        [JsonPropertyName("allowRentGuaranteedOptout")]
        public bool AllowRentGuaranteedOptout { get; set; }

        [JsonPropertyName("isSecuritized")]
        public bool IsSecuritized { get; set; }

        [JsonPropertyName("isHot")]
        public bool IsHot { get; set; }

        [JsonPropertyName("isNew")]
        public bool IsNew { get; set; }

        [JsonPropertyName("isBargain")]
        public bool? IsBargain { get; set; }

        [JsonPropertyName("isDiligenceVaultUnlocked")]
        public bool IsDiligenceVaultUnlocked { get; set; }

        [JsonPropertyName("isPropertyManagerOfferRetain")]
        public bool? IsPropertyManagerOfferRetain { get; set; }

        [JsonPropertyName("isHoa")]
        public bool? IsHoa { get; set; }

        [JsonPropertyName("hasAudio")]
        public bool HasAudio { get; set; }

        [JsonPropertyName("hasDiligenceVaultDocuments")]
        public bool HasDiligenceVaultDocuments { get; set; }

        [JsonPropertyName("market")]
        public int Market { get; set; }

        [JsonPropertyName("daysOnMarket")]
        public int? DaysOnMarket { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("propertyName")]
        public object PropertyName { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("highlights")]
        public object Highlights { get; set; }

        [JsonPropertyName("mainImageUrl")]
        public string MainImageUrl { get; set; }

        [JsonPropertyName("personalProperties")]
        public object PersonalProperties { get; set; }

        [JsonPropertyName("diligenceVaultSummary")]
        public string DiligenceVaultSummary { get; set; }

        [JsonPropertyName("featuredReason")]
        public object FeaturedReason { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("allowedFundingTypes")]
        public string AllowedFundingTypes { get; set; }

        [JsonPropertyName("allowableSaleTypes")]
        public string AllowableSaleTypes { get; set; }

        [JsonPropertyName("visibility")]
        public string Visibility { get; set; }

        [JsonPropertyName("priceVisibility")]
        public string PriceVisibility { get; set; }

        [JsonPropertyName("propertyType")]
        public string PropertyType { get; set; }

        [JsonPropertyName("certificationLevel")]
        public string CertificationLevel { get; set; }

        [JsonPropertyName("escrowClosingDate")]
        public DateTime? EscrowClosingDate { get; set; }

        [JsonPropertyName("address")]
        public Address Address { get; set; }

        [JsonPropertyName("financial")]
        public Financial Financial { get; set; }

        [JsonPropertyName("physical")]
        public Physical Physical { get; set; }

        [JsonPropertyName("score")]
        public Score Score { get; set; }

        [JsonPropertyName("valuation")]
        public Valuation Valuation { get; set; }

        [JsonPropertyName("resources")]
        public Resources Resources { get; set; }

        [JsonPropertyName("manager")]
        public object Manager { get; set; }

        [JsonPropertyName("seller")]
        public object Seller { get; set; }

        [JsonPropertyName("sellerBroker")]
        public object SellerBroker { get; set; }

        [JsonPropertyName("hoa")]
        public object Hoa { get; set; }

        [JsonPropertyName("lease")]
        public Lease Lease { get; set; }

        [JsonPropertyName("diligences")]
        public List<object> Diligences { get; set; }

        [JsonPropertyName("googleMapOption")]
        public GoogleMapOption GoogleMapOption { get; set; }

        [JsonPropertyName("inspectionType")]
        public object InspectionType { get; set; }
    }
}