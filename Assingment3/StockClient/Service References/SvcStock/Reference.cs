﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.261
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StockClient.SvcStock {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyInfo", Namespace="http://schemas.datacontract.org/2004/07/StockService")]
    [System.SerializableAttribute()]
    public partial class CompanyInfo : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double StockPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double AnnualTurnoverField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WeeklyPriceField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Company Name")]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Location {
            get {
                return this.LocationField;
            }
            set {
                if ((object.ReferenceEquals(this.LocationField, value) != true)) {
                    this.LocationField = value;
                    this.RaisePropertyChanged("Location");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Stock Price")]
        public double StockPrice {
            get {
                return this.StockPriceField;
            }
            set {
                if ((this.StockPriceField.Equals(value) != true)) {
                    this.StockPriceField = value;
                    this.RaisePropertyChanged("StockPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Annual Turnover", Order=3)]
        public double AnnualTurnover {
            get {
                return this.AnnualTurnoverField;
            }
            set {
                if ((this.AnnualTurnoverField.Equals(value) != true)) {
                    this.AnnualTurnoverField = value;
                    this.RaisePropertyChanged("AnnualTurnover");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=4)]
        public string Type {
            get {
                return this.TypeField;
            }
            set {
                if ((object.ReferenceEquals(this.TypeField, value) != true)) {
                    this.TypeField = value;
                    this.RaisePropertyChanged("Type");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="Weekly Price", Order=5)]
        public string WeeklyPrice {
            get {
                return this.WeeklyPriceField;
            }
            set {
                if ((object.ReferenceEquals(this.WeeklyPriceField, value) != true)) {
                    this.WeeklyPriceField = value;
                    this.RaisePropertyChanged("WeeklyPrice");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SvcStock.IStockService", SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface IStockService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockService/GetStockPrice", ReplyAction="http://tempuri.org/IStockService/GetStockPriceResponse")]
        double GetStockPrice(string companyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockService/GetAvgWeeklyPrice", ReplyAction="http://tempuri.org/IStockService/GetAvgWeeklyPriceResponse")]
        double GetAvgWeeklyPrice(string companyName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockService/CompanyDetails", ReplyAction="http://tempuri.org/IStockService/CompanyDetailsResponse")]
        StockClient.SvcStock.CompanyInfo[] CompanyDetails();
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IStockService/PopulateData")]
        void PopulateData();
        
        [System.ServiceModel.OperationContractAttribute(IsTerminating=true, Action="http://tempuri.org/IStockService/TerminateService", ReplyAction="http://tempuri.org/IStockService/TerminateServiceResponse")]
        void TerminateService();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockService/StockType", ReplyAction="http://tempuri.org/IStockService/StockTypeResponse")]
        string[] StockType();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStockService/CompanyStockType", ReplyAction="http://tempuri.org/IStockService/CompanyStockTypeResponse")]
        StockClient.SvcStock.CompanyInfo[] CompanyStockType(string stockType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStockServiceChannel : StockClient.SvcStock.IStockService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StockServiceClient : System.ServiceModel.ClientBase<StockClient.SvcStock.IStockService>, StockClient.SvcStock.IStockService {
        
        public StockServiceClient() {
        }
        
        public StockServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StockServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StockServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double GetStockPrice(string companyName) {
            return base.Channel.GetStockPrice(companyName);
        }
        
        public double GetAvgWeeklyPrice(string companyName) {
            return base.Channel.GetAvgWeeklyPrice(companyName);
        }
        
        public StockClient.SvcStock.CompanyInfo[] CompanyDetails() {
            return base.Channel.CompanyDetails();
        }
        
        public void PopulateData() {
            base.Channel.PopulateData();
        }
        
        public void TerminateService() {
            base.Channel.TerminateService();
        }
        
        public string[] StockType() {
            return base.Channel.StockType();
        }
        
        public StockClient.SvcStock.CompanyInfo[] CompanyStockType(string stockType) {
            return base.Channel.CompanyStockType(stockType);
        }
    }
}