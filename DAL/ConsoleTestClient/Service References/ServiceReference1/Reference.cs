﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleTestClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Lot", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class Lot : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AboutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.LotHistory[] HistoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LotNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PhotoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StartPriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Tell[] TellsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeFinishField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime TimeStartField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Person WhoSaleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string About {
            get {
                return this.AboutField;
            }
            set {
                if ((object.ReferenceEquals(this.AboutField, value) != true)) {
                    this.AboutField = value;
                    this.RaisePropertyChanged("About");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.LotHistory[] History {
            get {
                return this.HistoryField;
            }
            set {
                if ((object.ReferenceEquals(this.HistoryField, value) != true)) {
                    this.HistoryField = value;
                    this.RaisePropertyChanged("History");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LotName {
            get {
                return this.LotNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LotNameField, value) != true)) {
                    this.LotNameField = value;
                    this.RaisePropertyChanged("LotName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Photo {
            get {
                return this.PhotoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhotoField, value) != true)) {
                    this.PhotoField = value;
                    this.RaisePropertyChanged("Photo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StartPrice {
            get {
                return this.StartPriceField;
            }
            set {
                if ((this.StartPriceField.Equals(value) != true)) {
                    this.StartPriceField = value;
                    this.RaisePropertyChanged("StartPrice");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Tell[] Tells {
            get {
                return this.TellsField;
            }
            set {
                if ((object.ReferenceEquals(this.TellsField, value) != true)) {
                    this.TellsField = value;
                    this.RaisePropertyChanged("Tells");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeFinish {
            get {
                return this.TimeFinishField;
            }
            set {
                if ((this.TimeFinishField.Equals(value) != true)) {
                    this.TimeFinishField = value;
                    this.RaisePropertyChanged("TimeFinish");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime TimeStart {
            get {
                return this.TimeStartField;
            }
            set {
                if ((this.TimeStartField.Equals(value) != true)) {
                    this.TimeStartField = value;
                    this.RaisePropertyChanged("TimeStart");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Person WhoSale {
            get {
                return this.WhoSaleField;
            }
            set {
                if ((object.ReferenceEquals(this.WhoSaleField, value) != true)) {
                    this.WhoSaleField = value;
                    this.RaisePropertyChanged("WhoSale");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class Person : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool GenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.LotHistory[] HistoriesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ImageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Lot[] LotsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PasswordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SecondNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Tell[] TellsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Gender {
            get {
                return this.GenderField;
            }
            set {
                if ((this.GenderField.Equals(value) != true)) {
                    this.GenderField = value;
                    this.RaisePropertyChanged("Gender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.LotHistory[] Histories {
            get {
                return this.HistoriesField;
            }
            set {
                if ((object.ReferenceEquals(this.HistoriesField, value) != true)) {
                    this.HistoriesField = value;
                    this.RaisePropertyChanged("Histories");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Image {
            get {
                return this.ImageField;
            }
            set {
                if ((object.ReferenceEquals(this.ImageField, value) != true)) {
                    this.ImageField = value;
                    this.RaisePropertyChanged("Image");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Lot[] Lots {
            get {
                return this.LotsField;
            }
            set {
                if ((object.ReferenceEquals(this.LotsField, value) != true)) {
                    this.LotsField = value;
                    this.RaisePropertyChanged("Lots");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Password {
            get {
                return this.PasswordField;
            }
            set {
                if ((object.ReferenceEquals(this.PasswordField, value) != true)) {
                    this.PasswordField = value;
                    this.RaisePropertyChanged("Password");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SecondName {
            get {
                return this.SecondNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SecondNameField, value) != true)) {
                    this.SecondNameField = value;
                    this.RaisePropertyChanged("SecondName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Tell[] Tells {
            get {
                return this.TellsField;
            }
            set {
                if ((object.ReferenceEquals(this.TellsField, value) != true)) {
                    this.TellsField = value;
                    this.RaisePropertyChanged("Tells");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="LotHistory", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class LotHistory : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Lot LotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int MoneyField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Person PerssonField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Lot Lot {
            get {
                return this.LotField;
            }
            set {
                if ((object.ReferenceEquals(this.LotField, value) != true)) {
                    this.LotField = value;
                    this.RaisePropertyChanged("Lot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Money {
            get {
                return this.MoneyField;
            }
            set {
                if ((this.MoneyField.Equals(value) != true)) {
                    this.MoneyField = value;
                    this.RaisePropertyChanged("Money");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Person Persson {
            get {
                return this.PerssonField;
            }
            set {
                if ((object.ReferenceEquals(this.PerssonField, value) != true)) {
                    this.PerssonField = value;
                    this.RaisePropertyChanged("Persson");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tell", Namespace="http://schemas.datacontract.org/2004/07/DAL")]
    [System.SerializableAttribute()]
    public partial class Tell : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Lot LotField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleTestClient.ServiceReference1.Person PersonField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Lot Lot {
            get {
                return this.LotField;
            }
            set {
                if ((object.ReferenceEquals(this.LotField, value) != true)) {
                    this.LotField = value;
                    this.RaisePropertyChanged("Lot");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleTestClient.ServiceReference1.Person Person {
            get {
                return this.PersonField;
            }
            set {
                if ((object.ReferenceEquals(this.PersonField, value) != true)) {
                    this.PersonField = value;
                    this.RaisePropertyChanged("Person");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IAuctionClient")]
    public interface IAuctionClient {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AddPerson", ReplyAction="http://tempuri.org/IAuctionClient/AddPersonResponse")]
        string AddPerson(string FirstName, string SecondName, string Email, string Password, bool Gender, byte[] Img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AddPerson", ReplyAction="http://tempuri.org/IAuctionClient/AddPersonResponse")]
        System.Threading.Tasks.Task<string> AddPersonAsync(string FirstName, string SecondName, string Email, string Password, bool Gender, byte[] Img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/Authorization", ReplyAction="http://tempuri.org/IAuctionClient/AuthorizationResponse")]
        string Authorization(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/Authorization", ReplyAction="http://tempuri.org/IAuctionClient/AuthorizationResponse")]
        System.Threading.Tasks.Task<string> AuthorizationAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AddLot", ReplyAction="http://tempuri.org/IAuctionClient/AddLotResponse")]
        string AddLot(string Name, string About, int StartPrice, System.DateTime Start, System.DateTime Finish, byte[] Img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AddLot", ReplyAction="http://tempuri.org/IAuctionClient/AddLotResponse")]
        System.Threading.Tasks.Task<string> AddLotAsync(string Name, string About, int StartPrice, System.DateTime Start, System.DateTime Finish, byte[] Img);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/Bet", ReplyAction="http://tempuri.org/IAuctionClient/BetResponse")]
        string Bet(int lotId, int money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/Bet", ReplyAction="http://tempuri.org/IAuctionClient/BetResponse")]
        System.Threading.Tasks.Task<string> BetAsync(int lotId, int money);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/OldLots", ReplyAction="http://tempuri.org/IAuctionClient/OldLotsResponse")]
        ConsoleTestClient.ServiceReference1.Lot[] OldLots();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/OldLots", ReplyAction="http://tempuri.org/IAuctionClient/OldLotsResponse")]
        System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> OldLotsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AllLots", ReplyAction="http://tempuri.org/IAuctionClient/AllLotsResponse")]
        ConsoleTestClient.ServiceReference1.Lot[] AllLots();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AllLots", ReplyAction="http://tempuri.org/IAuctionClient/AllLotsResponse")]
        System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> AllLotsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/FutureLots", ReplyAction="http://tempuri.org/IAuctionClient/FutureLotsResponse")]
        ConsoleTestClient.ServiceReference1.Lot[] FutureLots();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/FutureLots", ReplyAction="http://tempuri.org/IAuctionClient/FutureLotsResponse")]
        System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> FutureLotsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/NowLots", ReplyAction="http://tempuri.org/IAuctionClient/NowLotsResponse")]
        ConsoleTestClient.ServiceReference1.Lot[] NowLots();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/NowLots", ReplyAction="http://tempuri.org/IAuctionClient/NowLotsResponse")]
        System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> NowLotsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/TellMeAboutStartLot", ReplyAction="http://tempuri.org/IAuctionClient/TellMeAboutStartLotResponse")]
        string TellMeAboutStartLot(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/TellMeAboutStartLot", ReplyAction="http://tempuri.org/IAuctionClient/TellMeAboutStartLotResponse")]
        System.Threading.Tasks.Task<string> TellMeAboutStartLotAsync(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/SendMessage", ReplyAction="http://tempuri.org/IAuctionClient/SendMessageResponse")]
        void SendMessage(string Thema, string Message, ConsoleTestClient.ServiceReference1.Person to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/SendMessage", ReplyAction="http://tempuri.org/IAuctionClient/SendMessageResponse")]
        System.Threading.Tasks.Task SendMessageAsync(string Thema, string Message, ConsoleTestClient.ServiceReference1.Person to);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/ForgetPassword", ReplyAction="http://tempuri.org/IAuctionClient/ForgetPasswordResponse")]
        void ForgetPassword(string email, string FirstName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/ForgetPassword", ReplyAction="http://tempuri.org/IAuctionClient/ForgetPasswordResponse")]
        System.Threading.Tasks.Task ForgetPasswordAsync(string email, string FirstName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/LotHistory", ReplyAction="http://tempuri.org/IAuctionClient/LotHistoryResponse")]
        string LotHistory(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/LotHistory", ReplyAction="http://tempuri.org/IAuctionClient/LotHistoryResponse")]
        System.Threading.Tasks.Task<string> LotHistoryAsync(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/LastBet", ReplyAction="http://tempuri.org/IAuctionClient/LastBetResponse")]
        int LastBet(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/LastBet", ReplyAction="http://tempuri.org/IAuctionClient/LastBetResponse")]
        System.Threading.Tasks.Task<int> LastBetAsync(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AboutLot", ReplyAction="http://tempuri.org/IAuctionClient/AboutLotResponse")]
        ConsoleTestClient.ServiceReference1.Lot AboutLot(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/AboutLot", ReplyAction="http://tempuri.org/IAuctionClient/AboutLotResponse")]
        System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot> AboutLotAsync(int LotId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/SingOut", ReplyAction="http://tempuri.org/IAuctionClient/SingOutResponse")]
        void SingOut();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuctionClient/SingOut", ReplyAction="http://tempuri.org/IAuctionClient/SingOutResponse")]
        System.Threading.Tasks.Task SingOutAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuctionClientChannel : ConsoleTestClient.ServiceReference1.IAuctionClient, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuctionClientClient : System.ServiceModel.ClientBase<ConsoleTestClient.ServiceReference1.IAuctionClient>, ConsoleTestClient.ServiceReference1.IAuctionClient {
        
        public AuctionClientClient() {
        }
        
        public AuctionClientClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuctionClientClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionClientClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuctionClientClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string AddPerson(string FirstName, string SecondName, string Email, string Password, bool Gender, byte[] Img) {
            return base.Channel.AddPerson(FirstName, SecondName, Email, Password, Gender, Img);
        }
        
        public System.Threading.Tasks.Task<string> AddPersonAsync(string FirstName, string SecondName, string Email, string Password, bool Gender, byte[] Img) {
            return base.Channel.AddPersonAsync(FirstName, SecondName, Email, Password, Gender, Img);
        }
        
        public string Authorization(string email, string password) {
            return base.Channel.Authorization(email, password);
        }
        
        public System.Threading.Tasks.Task<string> AuthorizationAsync(string email, string password) {
            return base.Channel.AuthorizationAsync(email, password);
        }
        
        public string AddLot(string Name, string About, int StartPrice, System.DateTime Start, System.DateTime Finish, byte[] Img) {
            return base.Channel.AddLot(Name, About, StartPrice, Start, Finish, Img);
        }
        
        public System.Threading.Tasks.Task<string> AddLotAsync(string Name, string About, int StartPrice, System.DateTime Start, System.DateTime Finish, byte[] Img) {
            return base.Channel.AddLotAsync(Name, About, StartPrice, Start, Finish, Img);
        }
        
        public string Bet(int lotId, int money) {
            return base.Channel.Bet(lotId, money);
        }
        
        public System.Threading.Tasks.Task<string> BetAsync(int lotId, int money) {
            return base.Channel.BetAsync(lotId, money);
        }
        
        public ConsoleTestClient.ServiceReference1.Lot[] OldLots() {
            return base.Channel.OldLots();
        }
        
        public System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> OldLotsAsync() {
            return base.Channel.OldLotsAsync();
        }
        
        public ConsoleTestClient.ServiceReference1.Lot[] AllLots() {
            return base.Channel.AllLots();
        }
        
        public System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> AllLotsAsync() {
            return base.Channel.AllLotsAsync();
        }
        
        public ConsoleTestClient.ServiceReference1.Lot[] FutureLots() {
            return base.Channel.FutureLots();
        }
        
        public System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> FutureLotsAsync() {
            return base.Channel.FutureLotsAsync();
        }
        
        public ConsoleTestClient.ServiceReference1.Lot[] NowLots() {
            return base.Channel.NowLots();
        }
        
        public System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot[]> NowLotsAsync() {
            return base.Channel.NowLotsAsync();
        }
        
        public string TellMeAboutStartLot(int LotId) {
            return base.Channel.TellMeAboutStartLot(LotId);
        }
        
        public System.Threading.Tasks.Task<string> TellMeAboutStartLotAsync(int LotId) {
            return base.Channel.TellMeAboutStartLotAsync(LotId);
        }
        
        public void SendMessage(string Thema, string Message, ConsoleTestClient.ServiceReference1.Person to) {
            base.Channel.SendMessage(Thema, Message, to);
        }
        
        public System.Threading.Tasks.Task SendMessageAsync(string Thema, string Message, ConsoleTestClient.ServiceReference1.Person to) {
            return base.Channel.SendMessageAsync(Thema, Message, to);
        }
        
        public void ForgetPassword(string email, string FirstName) {
            base.Channel.ForgetPassword(email, FirstName);
        }
        
        public System.Threading.Tasks.Task ForgetPasswordAsync(string email, string FirstName) {
            return base.Channel.ForgetPasswordAsync(email, FirstName);
        }
        
        public string LotHistory(int LotId) {
            return base.Channel.LotHistory(LotId);
        }
        
        public System.Threading.Tasks.Task<string> LotHistoryAsync(int LotId) {
            return base.Channel.LotHistoryAsync(LotId);
        }
        
        public int LastBet(int LotId) {
            return base.Channel.LastBet(LotId);
        }
        
        public System.Threading.Tasks.Task<int> LastBetAsync(int LotId) {
            return base.Channel.LastBetAsync(LotId);
        }
        
        public ConsoleTestClient.ServiceReference1.Lot AboutLot(int LotId) {
            return base.Channel.AboutLot(LotId);
        }
        
        public System.Threading.Tasks.Task<ConsoleTestClient.ServiceReference1.Lot> AboutLotAsync(int LotId) {
            return base.Channel.AboutLotAsync(LotId);
        }
        
        public void SingOut() {
            base.Channel.SingOut();
        }
        
        public System.Threading.Tasks.Task SingOutAsync() {
            return base.Channel.SingOutAsync();
        }
    }
}
