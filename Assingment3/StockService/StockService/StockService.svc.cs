using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Xml.Linq;
using System.Linq.Expressions;
using StockService;
using System.Xml;
using System.IO;
using System.Web.Hosting;


namespace StockService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "StockService" in code, svc and config file together.
    public class StockService : IStockService
    {
        
        List<CompanyInfo> comp = new List<CompanyInfo>();
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }
  
        public List<CompanyInfo> CompanyDetails()
        {
            if(comp == null)
            {
                PopulateData();
            }
            return comp;
        }


        public double GetStockPrice(string companyName)
        {
            double x = 0;
            for (int i = 0; i < comp.Count; i++)
            {
                if (comp[i].CompanyName == companyName)
                {
                    x = comp[i].StockPrice;
                }
            }

            
            return x;            
        }


       

        public double GetAvgWeeklyPrice(string companyName)
        {

            
            string x="";
            for (int i = 0; i < comp.Count; i++)
            {
                if (comp[i].CompanyName == companyName)
                {
                    x = comp[i].WeeklyPrice;
                }
            }
            string[] price = x.Split(',');
            double[] arrDouble = new double[price.Length];
            for (int i = 0; i < price.Length; i++)
            {
                arrDouble[i] = double.Parse(price[i]);
            }
            double avg= 0;
            foreach (double weeklyVal in arrDouble)
                avg += weeklyVal;

            string Savg = string.Format(String.Format("{0:0.00}", (avg / arrDouble.Length))); 
            

            return Convert.ToDouble(Savg);
        }      
        public void PopulateData()
        {
           
        //var companyList = from nodes in System.Xml.Linq.XElement.Load("G:\\Assingment3\\StockService\\StockService\\CompanyDB.xml").Elements("company") select nodes;
            var companyList = from nodes in System.Xml.Linq.XElement.Load(Path.Combine(HostingEnvironment.ApplicationPhysicalPath, "CompanyDB.xml")).Elements("company") select nodes;
           
               
               foreach (var a in companyList)
               {
                   CompanyInfo company = new CompanyInfo();
                   company.CompanyName = a.FirstAttribute.Value;
                   company.Location = a.Element("Location").Value;
                   company.StockPrice = Convert.ToDouble(a.Element("StockPrice").Value);
                   company.AnnualTurnover = Convert.ToDouble(a.Element("AnnualPrice").Value);
                   company.WeeklyPrice = a.Element("AvgWeeklyPrice").Value;
                   company.Type = a.Element("type").Value;
                   comp.Add(company);
                   
               }

           }


        
        public void TerminateService()
        {
        }
        public string[] StockType()
        {
            string[] type = { "Energy", "Technology" };
            return type;

        }
        public List<CompanyInfo> CompanyStockType(string stockType)
        {
            List<CompanyInfo> x = new List<CompanyInfo>();
            for (int i = 0; i < comp.Count; i++)
            {
                if (comp[i].Type == stockType)
                {
                    x.Add(comp[i]);
                }
            }
            return x;

        }
       
       
    }
}
