using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace EquifyAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new EquifyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<EquifyContext>>()))
            {
                // Look for any deals
                if (context.Deal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Deal.AddRange(
                    new Deal
                    {
                        CompanyName = "Green Standards",
                        Founded = 2009,
                        Country = "Canada",
                        Region = "North America",
                        Sector = "Waste Management & Recycling",
                        EnterpriseValue = 65.03M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2019-2-12"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund I",
                        Currency = "CAD",
                        EquityRequired = 15,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "Bear Mattress",
                        Founded = 1993,
                        Country = "USA",
                        Region = "North America",
                        Sector = "Household Goods",
                        EnterpriseValue = 30.12M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2020-03-17"),
                        DealStatus = "Cold",
                        FundInvesting = "ECP Fund II",
                        Currency = "USD",
                        EquityRequired = 5,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    },

                    new Deal
                    {
                        CompanyName = "ShipMonk",
                        Founded = 2014,
                        Country = "USA",
                        Region = "North America",
                        Sector = "Support Services",
                        EnterpriseValue = 25.74M,
                        DealType = "Management Buyout",
                        DealOriginationDate = DateTime.Parse("2020-05-10"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund I",
                        Currency = "USD",
                        EquityRequired = 20,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "Office Libations",
                        Founded = 2015,
                        Country = "USA",
                        Region = "North America",
                        Sector = "Food & Beverage",
                        EnterpriseValue = 20.89M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2019-06-15"),
                        DealStatus = "Closed",
                        FundInvesting = "ECP Fund II",
                        Currency = "USD",
                        EquityRequired = 5,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    },

                    new Deal
                    {
                        CompanyName = "Coderhouse",
                        Founded = 2014,
                        Country = "Argentina",
                        Region = "Americas",
                        Sector = "Education",
                        EnterpriseValue = 12.54M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2020-04-16"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund I",
                        Currency = "ARS",
                        EquityRequired = 3,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "Zetrasoft",
                        Founded = 2000,
                        Country = "Brazil",
                        Region = "Americas",
                        Sector = "Financial Services",
                        EnterpriseValue = 55.26M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2019-11-18"),
                        DealStatus = "Cold",
                        FundInvesting = "ECP Fund II",
                        Currency = "BRL",
                        EquityRequired = 10,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    },

                    new Deal
                    {
                        CompanyName = "Country Fresh",
                        Founded = 2011,
                        Country = "Colombia",
                        Region = "Americas",
                        Sector = "Agricultural Commodities",
                        EnterpriseValue = 25.59M,
                        DealType = "Management Buyout",
                        DealOriginationDate = DateTime.Parse("2020-06-25"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund I",
                        Currency = "COP",
                        EquityRequired = 15,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "Alta Sistemas",
                        Founded = 2013,
                        Country = "Mexico",
                        Region = "Americas",
                        Sector = "Technology",
                        EnterpriseValue = 60.93M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2020-02-21"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund II",
                        Currency = "MXN",
                        EquityRequired = 30,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    },

                    new Deal
                    {
                        CompanyName = "Crep Protect",
                        Founded = 2014,
                        Country = "United Kingdom",
                        Region = "Europe",
                        Sector = "Fashion",
                        EnterpriseValue = 8.52M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2020-03-05"),
                        DealStatus = "Closed",
                        FundInvesting = "ECP Fund I",
                        Currency = "GBP",
                        EquityRequired = 3,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "Apotea",
                        Founded = 2012,
                        Country = "Sweden",
                        Region = "Europe",
                        Sector = "Pharmaceuticals",
                        EnterpriseValue = 145.28M,
                        DealType = "Follow-On",
                        DealOriginationDate = DateTime.Parse("2020-07-06"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund II",
                        Currency = "SEK",
                        EquityRequired = 50,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    },

                    new Deal
                    {
                        CompanyName = "Seal Aromas",
                        Founded = 2012,
                        Country = "Spain",
                        Region = "Europe",
                        Sector = "Household Goods",
                        EnterpriseValue = 20.84M,
                        DealType = "Management Buyout",
                        DealOriginationDate = DateTime.Parse("2019-12-21"),
                        DealStatus = "Cold",
                        FundInvesting = "ECP Fund I",
                        Currency = "EUR",
                        EquityRequired = 5,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "Non-Stop Dogwear",
                        Founded = 2009,
                        Country = "Norway",
                        Region = "Europe",
                        Sector = "Retail",
                        EnterpriseValue = 45.85M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2020-04-27"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund II",
                        Currency = "NOK",
                        EquityRequired = 20,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    },

                    new Deal
                    {
                        CompanyName = "Fave Asia",
                        Founded = 2015,
                        Country = "Malaysia",
                        Region = "Asia",
                        Sector = "Ecommerce",
                        EnterpriseValue = 250.16M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2020-05-31"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund I",
                        Currency = "MYR",
                        EquityRequired = 80,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "Soundbrenner",
                        Founded = 2015,
                        Country = "Hong Kong",
                        Region = "Asia",
                        Sector = "Technology",
                        EnterpriseValue = 90.48M,
                        DealType = "Follow-On",
                        DealOriginationDate = DateTime.Parse("2020-02-06"),
                        DealStatus = "Closed",
                        FundInvesting = "ECP Fund II",
                        Currency = "HKD",
                        EquityRequired = 25,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    },

                    new Deal
                    {
                        CompanyName = "Schbang",
                        Founded = 2015,
                        Country = "India",
                        Region = "Asia",
                        Sector = "Sales & Marketing",
                        EnterpriseValue = 65.67M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2019-11-30"),
                        DealStatus = "Closed",
                        FundInvesting = "ECP Fund I",
                        Currency = "INR",
                        EquityRequired = 25,
                        DealTeamLead = "John Stanmore",
                        InvestorRelationsLead = "Nelson Granger",
                        ESGLead = "Michele Smith"
                    },

                    new Deal
                    {
                        CompanyName = "ZUU",
                        Founded = 2013,
                        Country = "Japan",
                        Region = "Asia",
                        Sector = "Fintech",
                        EnterpriseValue = 60.42M,
                        DealType = "Growth Equity",
                        DealOriginationDate = DateTime.Parse("2020-06-25"),
                        DealStatus = "Active",
                        FundInvesting = "ECP Fund II",
                        Currency = "JPY",
                        EquityRequired = 15,
                        DealTeamLead = "Bryan Montecute",
                        InvestorRelationsLead = "Rachel Snelling",
                        ESGLead = "Samantha Rose"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}