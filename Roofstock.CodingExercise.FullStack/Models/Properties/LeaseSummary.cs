using System;
using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class LeaseSummary
    {
        [JsonPropertyName("occupancy")]
        public string Occupancy { get; set; }

        [JsonPropertyName("leasingStatus")]
        public object LeasingStatus { get; set; }

        [JsonPropertyName("marketedRent")]
        public object MarketedRent { get; set; }

        [JsonPropertyName("paymentStatus")]
        public string PaymentStatus { get; set; }

        [JsonPropertyName("leaseStartDate")]
        public DateTime LeaseStartDate { get; set; }

        [JsonPropertyName("leaseEndDate")]
        public DateTime LeaseEndDate { get; set; }

        [JsonPropertyName("monthlyRent")]
        public double MonthlyRent { get; set; }

        [JsonPropertyName("securityDepositAmount")]
        public double? SecurityDepositAmount { get; set; }

        [JsonPropertyName("hasPet")]
        public object HasPet { get; set; }

        [JsonPropertyName("petFeeAmount")]
        public object PetFeeAmount { get; set; }

        [JsonPropertyName("isPetsDeposit")]
        public bool IsPetsDeposit { get; set; }

        [JsonPropertyName("petsDepositAmount")]
        public double? PetsDepositAmount { get; set; }

        [JsonPropertyName("isLeaseConcessions")]
        public bool? IsLeaseConcessions { get; set; }

        [JsonPropertyName("isRentersInsuranceRequired")]
        public bool IsRentersInsuranceRequired { get; set; }

        [JsonPropertyName("isSection8")]
        public bool IsSection8 { get; set; }

        [JsonPropertyName("isTenantBackgroundChecked")]
        public bool IsTenantBackgroundChecked { get; set; }

        [JsonPropertyName("isTenantIncomeAbove3x")]
        public bool IsTenantIncomeAbove3x { get; set; }

        [JsonPropertyName("isTenantMayTerminateEarly")]
        public object IsTenantMayTerminateEarly { get; set; }

        [JsonPropertyName("isTenantPurchaseOption")]
        public object IsTenantPurchaseOption { get; set; }
    }
}