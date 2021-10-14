using System;
using System.Text.Json.Serialization;

namespace Roofstock.CodingExercise.FullStack.Models.Properties
{
    public class Financial
    {
        [JsonPropertyName("capRate")]
        public object CapRate { get; set; }

        [JsonPropertyName("occupancy")]
        public string Occupancy { get; set; }

        [JsonPropertyName("isSection8")]
        public bool IsSection8 { get; set; }

        [JsonPropertyName("leaseStartDate")]
        public DateTime LeaseStartDate { get; set; }

        [JsonPropertyName("leaseEndDate")]
        public DateTime LeaseEndDate { get; set; }

        [JsonPropertyName("listPrice")]
        public double ListPrice { get; set; }

        [JsonPropertyName("salePrice")]
        public object SalePrice { get; set; }

        [JsonPropertyName("marketValue")]
        public object MarketValue { get; set; }

        [JsonPropertyName("monthlyHoa")]
        public object MonthlyHoa { get; set; }

        [JsonPropertyName("monthlyManagementFees")]
        public object MonthlyManagementFees { get; set; }

        [JsonPropertyName("monthlyRent")]
        public double MonthlyRent { get; set; }

        [JsonPropertyName("netYield")]
        public object NetYield { get; set; }

        [JsonPropertyName("turnOverFee")]
        public object TurnOverFee { get; set; }

        [JsonPropertyName("rehabCosts")]
        public object RehabCosts { get; set; }

        [JsonPropertyName("rehabDate")]
        public object RehabDate { get; set; }

        [JsonPropertyName("yearlyInsuranceCost")]
        public double? YearlyInsuranceCost { get; set; }

        [JsonPropertyName("yearlyPropertyTaxes")]
        public double YearlyPropertyTaxes { get; set; }

        [JsonPropertyName("isCashOnly")]
        public bool IsCashOnly { get; set; }
    }
}