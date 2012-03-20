using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace StockService
{
    [DataContract]
    public class CompanyInfo
    {
        [DataMember(Name= "Company Name",Order = 0)]
        public string CompanyName;

        [DataMember(Order = 1)]
        public string Location;
        
        [DataMember(Name="Stock Price", Order = 2)]
        public double StockPrice;

        [DataMember(Name="Annual Turnover", Order = 3)]
        public double AnnualTurnover;

        [DataMember(Name="Weekly Price", Order = 4, IsRequired = false)]
        public string WeeklyPrice;

        [DataMember(Name="Type", Order = 4, IsRequired = false)]
        public string Type;

    }
   
}
