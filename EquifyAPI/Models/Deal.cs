using System;
using System.ComponentModel.DataAnnotations;

namespace EquifyAPI.Models
{
    public class Deal
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }

        [DataType(DataType.Date)]
        public DateTime FoundedDate { get; set; }
        public string Country { get; set; }
        public string Region { get; set; }
        public string Sector { get; set; }
        public string EnterpriseValue { get; set; }
        public string DealType { get; set; }

        [DataType(DataType.Date)]
        public DateTime DealOriginationDate { get; set; }
        public string DealStatus { get; set; }
        public string FundInvesting { get; set; }
        public string Currency { get; set; }
        public decimal EquityRequired { get; set; }
        public string DealTeamLead { get; set; }
        public string InvestorRelationsLead { get; set; }
        public string ESGLead { get; set; }
    }
}
