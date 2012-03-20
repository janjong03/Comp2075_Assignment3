using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using StockService;

namespace StockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStockService" in both code and config file together.
    [ServiceContract(SessionMode= SessionMode.Required)]
    public interface IStockService
    {   [OperationContract]
        double GetStockPrice(string companyName);

        [OperationContract]
        double GetAvgWeeklyPrice(string companyName);

        [OperationContract]
        List<CompanyInfo> CompanyDetails();

        [OperationContract(IsInitiating = true, IsOneWay = true)]
        void PopulateData();

        [OperationContract(IsTerminating = true)]
        void TerminateService();
        [OperationContract]
        string[] StockType();

        [OperationContract]
        List<CompanyInfo> CompanyStockType(string stockType);
      
    }

    
}

