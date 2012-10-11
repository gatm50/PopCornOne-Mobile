﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.17929.
// 
#pragma warning disable 1591

namespace Core.LanguageReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ILanguageService", Namespace="http://tempuri.org/")]
    public partial class LanguageServiceClient : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DisplayLanguagesOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateLanguageOperationCompleted;
        
        private System.Threading.SendOrPostCallback EditLanguageOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteLanguageOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LanguageServiceClient() {
            this.Url = "http://192.168.75.10:59027/WebServices/LanguageService.svc";
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DisplayLanguagesCompletedEventHandler DisplayLanguagesCompleted;
        
        /// <remarks/>
        public event CreateLanguageCompletedEventHandler CreateLanguageCompleted;
        
        /// <remarks/>
        public event EditLanguageCompletedEventHandler EditLanguageCompleted;
        
        /// <remarks/>
        public event DeleteLanguageCompletedEventHandler DeleteLanguageCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILanguageService/DisplayLanguages", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [return: System.Xml.Serialization.XmlArrayItemAttribute(Namespace="http://schemas.datacontract.org/2004/07/PopCornOneWebApp.Models")]
        public Language[] DisplayLanguages() {
            object[] results = this.Invoke("DisplayLanguages", new object[0]);
            return ((Language[])(results[0]));
        }
        
        /// <remarks/>
        public void DisplayLanguagesAsync() {
            this.DisplayLanguagesAsync(null);
        }
        
        /// <remarks/>
        public void DisplayLanguagesAsync(object userState) {
            if ((this.DisplayLanguagesOperationCompleted == null)) {
                this.DisplayLanguagesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDisplayLanguagesOperationCompleted);
            }
            this.InvokeAsync("DisplayLanguages", new object[0], this.DisplayLanguagesOperationCompleted, userState);
        }
        
        private void OnDisplayLanguagesOperationCompleted(object arg) {
            if ((this.DisplayLanguagesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DisplayLanguagesCompleted(this, new DisplayLanguagesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILanguageService/CreateLanguage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void CreateLanguage([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Language language, out bool CreateLanguageResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool CreateLanguageResultSpecified) {
            object[] results = this.Invoke("CreateLanguage", new object[] {
                        language});
            CreateLanguageResult = ((bool)(results[0]));
            CreateLanguageResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void CreateLanguageAsync(Language language) {
            this.CreateLanguageAsync(language, null);
        }
        
        /// <remarks/>
        public void CreateLanguageAsync(Language language, object userState) {
            if ((this.CreateLanguageOperationCompleted == null)) {
                this.CreateLanguageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateLanguageOperationCompleted);
            }
            this.InvokeAsync("CreateLanguage", new object[] {
                        language}, this.CreateLanguageOperationCompleted, userState);
        }
        
        private void OnCreateLanguageOperationCompleted(object arg) {
            if ((this.CreateLanguageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateLanguageCompleted(this, new CreateLanguageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILanguageService/EditLanguage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void EditLanguage([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] Language language, out bool EditLanguageResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool EditLanguageResultSpecified) {
            object[] results = this.Invoke("EditLanguage", new object[] {
                        language});
            EditLanguageResult = ((bool)(results[0]));
            EditLanguageResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void EditLanguageAsync(Language language) {
            this.EditLanguageAsync(language, null);
        }
        
        /// <remarks/>
        public void EditLanguageAsync(Language language, object userState) {
            if ((this.EditLanguageOperationCompleted == null)) {
                this.EditLanguageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEditLanguageOperationCompleted);
            }
            this.InvokeAsync("EditLanguage", new object[] {
                        language}, this.EditLanguageOperationCompleted, userState);
        }
        
        private void OnEditLanguageOperationCompleted(object arg) {
            if ((this.EditLanguageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EditLanguageCompleted(this, new EditLanguageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ILanguageService/DeleteLanguage", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DeleteLanguage(int id, [System.Xml.Serialization.XmlIgnoreAttribute()] bool idSpecified, out bool DeleteLanguageResult, [System.Xml.Serialization.XmlIgnoreAttribute()] out bool DeleteLanguageResultSpecified) {
            object[] results = this.Invoke("DeleteLanguage", new object[] {
                        id,
                        idSpecified});
            DeleteLanguageResult = ((bool)(results[0]));
            DeleteLanguageResultSpecified = ((bool)(results[1]));
        }
        
        /// <remarks/>
        public void DeleteLanguageAsync(int id, bool idSpecified) {
            this.DeleteLanguageAsync(id, idSpecified, null);
        }
        
        /// <remarks/>
        public void DeleteLanguageAsync(int id, bool idSpecified, object userState) {
            if ((this.DeleteLanguageOperationCompleted == null)) {
                this.DeleteLanguageOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteLanguageOperationCompleted);
            }
            this.InvokeAsync("DeleteLanguage", new object[] {
                        id,
                        idSpecified}, this.DeleteLanguageOperationCompleted, userState);
        }
        
        private void OnDeleteLanguageOperationCompleted(object arg) {
            if ((this.DeleteLanguageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteLanguageCompleted(this, new DeleteLanguageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.17929")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/PopCornOneWebApp.Models")]
    public partial class Language {
        
        private int languageIdField;
        
        private bool languageIdFieldSpecified;
        
        private string languageNameField;
        
        /// <remarks/>
        public int LanguageId {
            get {
                return this.languageIdField;
            }
            set {
                this.languageIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool LanguageIdSpecified {
            get {
                return this.languageIdFieldSpecified;
            }
            set {
                this.languageIdFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string LanguageName {
            get {
                return this.languageNameField;
            }
            set {
                this.languageNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DisplayLanguagesCompletedEventHandler(object sender, DisplayLanguagesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DisplayLanguagesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DisplayLanguagesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Language[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Language[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void CreateLanguageCompletedEventHandler(object sender, CreateLanguageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateLanguageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateLanguageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool CreateLanguageResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool CreateLanguageResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void EditLanguageCompletedEventHandler(object sender, EditLanguageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EditLanguageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EditLanguageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool EditLanguageResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool EditLanguageResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    public delegate void DeleteLanguageCompletedEventHandler(object sender, DeleteLanguageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.17929")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteLanguageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteLanguageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public bool DeleteLanguageResult {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
        
        /// <remarks/>
        public bool DeleteLanguageResultSpecified {
            get {
                this.RaiseExceptionIfNecessary();
                return ((bool)(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591