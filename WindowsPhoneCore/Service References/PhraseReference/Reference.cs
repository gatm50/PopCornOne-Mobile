﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.544
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.Phone.ServiceReference, version 3.7.0.0
// 
namespace WindowsPhoneCore.PhraseReference {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Phrase", Namespace="http://schemas.datacontract.org/2004/07/PopCornOneWebApp.Models")]
    public partial class Phrase : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int AutorIdField;
        
        private int OriginIdField;
        
        private int TranslationIdField;
        
        private int phraseIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int AutorId {
            get {
                return this.AutorIdField;
            }
            set {
                if ((this.AutorIdField.Equals(value) != true)) {
                    this.AutorIdField = value;
                    this.RaisePropertyChanged("AutorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int OriginId {
            get {
                return this.OriginIdField;
            }
            set {
                if ((this.OriginIdField.Equals(value) != true)) {
                    this.OriginIdField = value;
                    this.RaisePropertyChanged("OriginId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TranslationId {
            get {
                return this.TranslationIdField;
            }
            set {
                if ((this.TranslationIdField.Equals(value) != true)) {
                    this.TranslationIdField = value;
                    this.RaisePropertyChanged("TranslationId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int phraseId {
            get {
                return this.phraseIdField;
            }
            set {
                if ((this.phraseIdField.Equals(value) != true)) {
                    this.phraseIdField = value;
                    this.RaisePropertyChanged("phraseId");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="PhraseReference.IPhraseService")]
    public interface IPhraseService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPhraseService/DisplayPhrases", ReplyAction="http://tempuri.org/IPhraseService/DisplayPhrasesResponse")]
        System.IAsyncResult BeginDisplayPhrases(System.AsyncCallback callback, object asyncState);
        
        System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase> EndDisplayPhrases(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPhraseService/CreatePhrase", ReplyAction="http://tempuri.org/IPhraseService/CreatePhraseResponse")]
        System.IAsyncResult BeginCreatePhrase(WindowsPhoneCore.PhraseReference.Phrase phrase, System.AsyncCallback callback, object asyncState);
        
        int EndCreatePhrase(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPhraseService/EditPhrase", ReplyAction="http://tempuri.org/IPhraseService/EditPhraseResponse")]
        System.IAsyncResult BeginEditPhrase(WindowsPhoneCore.PhraseReference.Phrase phrase, System.AsyncCallback callback, object asyncState);
        
        bool EndEditPhrase(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IPhraseService/DeletePhrase", ReplyAction="http://tempuri.org/IPhraseService/DeletePhraseResponse")]
        System.IAsyncResult BeginDeletePhrase(int id, System.AsyncCallback callback, object asyncState);
        
        bool EndDeletePhrase(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IPhraseServiceChannel : WindowsPhoneCore.PhraseReference.IPhraseService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DisplayPhrasesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DisplayPhrasesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CreatePhraseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public CreatePhraseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public int Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EditPhraseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public EditPhraseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DeletePhraseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public DeletePhraseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public bool Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((bool)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class PhraseServiceClient : System.ServiceModel.ClientBase<WindowsPhoneCore.PhraseReference.IPhraseService>, WindowsPhoneCore.PhraseReference.IPhraseService {
        
        private BeginOperationDelegate onBeginDisplayPhrasesDelegate;
        
        private EndOperationDelegate onEndDisplayPhrasesDelegate;
        
        private System.Threading.SendOrPostCallback onDisplayPhrasesCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreatePhraseDelegate;
        
        private EndOperationDelegate onEndCreatePhraseDelegate;
        
        private System.Threading.SendOrPostCallback onCreatePhraseCompletedDelegate;
        
        private BeginOperationDelegate onBeginEditPhraseDelegate;
        
        private EndOperationDelegate onEndEditPhraseDelegate;
        
        private System.Threading.SendOrPostCallback onEditPhraseCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeletePhraseDelegate;
        
        private EndOperationDelegate onEndDeletePhraseDelegate;
        
        private System.Threading.SendOrPostCallback onDeletePhraseCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public PhraseServiceClient() {
        }
        
        public PhraseServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public PhraseServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhraseServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public PhraseServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<DisplayPhrasesCompletedEventArgs> DisplayPhrasesCompleted;
        
        public event System.EventHandler<CreatePhraseCompletedEventArgs> CreatePhraseCompleted;
        
        public event System.EventHandler<EditPhraseCompletedEventArgs> EditPhraseCompleted;
        
        public event System.EventHandler<DeletePhraseCompletedEventArgs> DeletePhraseCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsPhoneCore.PhraseReference.IPhraseService.BeginDisplayPhrases(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDisplayPhrases(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase> WindowsPhoneCore.PhraseReference.IPhraseService.EndDisplayPhrases(System.IAsyncResult result) {
            return base.Channel.EndDisplayPhrases(result);
        }
        
        private System.IAsyncResult OnBeginDisplayPhrases(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).BeginDisplayPhrases(callback, asyncState);
        }
        
        private object[] OnEndDisplayPhrases(System.IAsyncResult result) {
            System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase> retVal = ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).EndDisplayPhrases(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDisplayPhrasesCompleted(object state) {
            if ((this.DisplayPhrasesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DisplayPhrasesCompleted(this, new DisplayPhrasesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DisplayPhrasesAsync() {
            this.DisplayPhrasesAsync(null);
        }
        
        public void DisplayPhrasesAsync(object userState) {
            if ((this.onBeginDisplayPhrasesDelegate == null)) {
                this.onBeginDisplayPhrasesDelegate = new BeginOperationDelegate(this.OnBeginDisplayPhrases);
            }
            if ((this.onEndDisplayPhrasesDelegate == null)) {
                this.onEndDisplayPhrasesDelegate = new EndOperationDelegate(this.OnEndDisplayPhrases);
            }
            if ((this.onDisplayPhrasesCompletedDelegate == null)) {
                this.onDisplayPhrasesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDisplayPhrasesCompleted);
            }
            base.InvokeAsync(this.onBeginDisplayPhrasesDelegate, null, this.onEndDisplayPhrasesDelegate, this.onDisplayPhrasesCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsPhoneCore.PhraseReference.IPhraseService.BeginCreatePhrase(WindowsPhoneCore.PhraseReference.Phrase phrase, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreatePhrase(phrase, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        int WindowsPhoneCore.PhraseReference.IPhraseService.EndCreatePhrase(System.IAsyncResult result) {
            return base.Channel.EndCreatePhrase(result);
        }
        
        private System.IAsyncResult OnBeginCreatePhrase(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WindowsPhoneCore.PhraseReference.Phrase phrase = ((WindowsPhoneCore.PhraseReference.Phrase)(inValues[0]));
            return ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).BeginCreatePhrase(phrase, callback, asyncState);
        }
        
        private object[] OnEndCreatePhrase(System.IAsyncResult result) {
            int retVal = ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).EndCreatePhrase(result);
            return new object[] {
                    retVal};
        }
        
        private void OnCreatePhraseCompleted(object state) {
            if ((this.CreatePhraseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreatePhraseCompleted(this, new CreatePhraseCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreatePhraseAsync(WindowsPhoneCore.PhraseReference.Phrase phrase) {
            this.CreatePhraseAsync(phrase, null);
        }
        
        public void CreatePhraseAsync(WindowsPhoneCore.PhraseReference.Phrase phrase, object userState) {
            if ((this.onBeginCreatePhraseDelegate == null)) {
                this.onBeginCreatePhraseDelegate = new BeginOperationDelegate(this.OnBeginCreatePhrase);
            }
            if ((this.onEndCreatePhraseDelegate == null)) {
                this.onEndCreatePhraseDelegate = new EndOperationDelegate(this.OnEndCreatePhrase);
            }
            if ((this.onCreatePhraseCompletedDelegate == null)) {
                this.onCreatePhraseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreatePhraseCompleted);
            }
            base.InvokeAsync(this.onBeginCreatePhraseDelegate, new object[] {
                        phrase}, this.onEndCreatePhraseDelegate, this.onCreatePhraseCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsPhoneCore.PhraseReference.IPhraseService.BeginEditPhrase(WindowsPhoneCore.PhraseReference.Phrase phrase, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginEditPhrase(phrase, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool WindowsPhoneCore.PhraseReference.IPhraseService.EndEditPhrase(System.IAsyncResult result) {
            return base.Channel.EndEditPhrase(result);
        }
        
        private System.IAsyncResult OnBeginEditPhrase(object[] inValues, System.AsyncCallback callback, object asyncState) {
            WindowsPhoneCore.PhraseReference.Phrase phrase = ((WindowsPhoneCore.PhraseReference.Phrase)(inValues[0]));
            return ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).BeginEditPhrase(phrase, callback, asyncState);
        }
        
        private object[] OnEndEditPhrase(System.IAsyncResult result) {
            bool retVal = ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).EndEditPhrase(result);
            return new object[] {
                    retVal};
        }
        
        private void OnEditPhraseCompleted(object state) {
            if ((this.EditPhraseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.EditPhraseCompleted(this, new EditPhraseCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void EditPhraseAsync(WindowsPhoneCore.PhraseReference.Phrase phrase) {
            this.EditPhraseAsync(phrase, null);
        }
        
        public void EditPhraseAsync(WindowsPhoneCore.PhraseReference.Phrase phrase, object userState) {
            if ((this.onBeginEditPhraseDelegate == null)) {
                this.onBeginEditPhraseDelegate = new BeginOperationDelegate(this.OnBeginEditPhrase);
            }
            if ((this.onEndEditPhraseDelegate == null)) {
                this.onEndEditPhraseDelegate = new EndOperationDelegate(this.OnEndEditPhrase);
            }
            if ((this.onEditPhraseCompletedDelegate == null)) {
                this.onEditPhraseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnEditPhraseCompleted);
            }
            base.InvokeAsync(this.onBeginEditPhraseDelegate, new object[] {
                        phrase}, this.onEndEditPhraseDelegate, this.onEditPhraseCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult WindowsPhoneCore.PhraseReference.IPhraseService.BeginDeletePhrase(int id, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDeletePhrase(id, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        bool WindowsPhoneCore.PhraseReference.IPhraseService.EndDeletePhrase(System.IAsyncResult result) {
            return base.Channel.EndDeletePhrase(result);
        }
        
        private System.IAsyncResult OnBeginDeletePhrase(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int id = ((int)(inValues[0]));
            return ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).BeginDeletePhrase(id, callback, asyncState);
        }
        
        private object[] OnEndDeletePhrase(System.IAsyncResult result) {
            bool retVal = ((WindowsPhoneCore.PhraseReference.IPhraseService)(this)).EndDeletePhrase(result);
            return new object[] {
                    retVal};
        }
        
        private void OnDeletePhraseCompleted(object state) {
            if ((this.DeletePhraseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeletePhraseCompleted(this, new DeletePhraseCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeletePhraseAsync(int id) {
            this.DeletePhraseAsync(id, null);
        }
        
        public void DeletePhraseAsync(int id, object userState) {
            if ((this.onBeginDeletePhraseDelegate == null)) {
                this.onBeginDeletePhraseDelegate = new BeginOperationDelegate(this.OnBeginDeletePhrase);
            }
            if ((this.onEndDeletePhraseDelegate == null)) {
                this.onEndDeletePhraseDelegate = new EndOperationDelegate(this.OnEndDeletePhrase);
            }
            if ((this.onDeletePhraseCompletedDelegate == null)) {
                this.onDeletePhraseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeletePhraseCompleted);
            }
            base.InvokeAsync(this.onBeginDeletePhraseDelegate, new object[] {
                        id}, this.onEndDeletePhraseDelegate, this.onDeletePhraseCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override WindowsPhoneCore.PhraseReference.IPhraseService CreateChannel() {
            return new PhraseServiceClientChannel(this);
        }
        
        private class PhraseServiceClientChannel : ChannelBase<WindowsPhoneCore.PhraseReference.IPhraseService>, WindowsPhoneCore.PhraseReference.IPhraseService {
            
            public PhraseServiceClientChannel(System.ServiceModel.ClientBase<WindowsPhoneCore.PhraseReference.IPhraseService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginDisplayPhrases(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("DisplayPhrases", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase> EndDisplayPhrases(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase> _result = ((System.Collections.ObjectModel.ObservableCollection<WindowsPhoneCore.PhraseReference.Phrase>)(base.EndInvoke("DisplayPhrases", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginCreatePhrase(WindowsPhoneCore.PhraseReference.Phrase phrase, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = phrase;
                System.IAsyncResult _result = base.BeginInvoke("CreatePhrase", _args, callback, asyncState);
                return _result;
            }
            
            public int EndCreatePhrase(System.IAsyncResult result) {
                object[] _args = new object[0];
                int _result = ((int)(base.EndInvoke("CreatePhrase", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginEditPhrase(WindowsPhoneCore.PhraseReference.Phrase phrase, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = phrase;
                System.IAsyncResult _result = base.BeginInvoke("EditPhrase", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndEditPhrase(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("EditPhrase", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginDeletePhrase(int id, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = id;
                System.IAsyncResult _result = base.BeginInvoke("DeletePhrase", _args, callback, asyncState);
                return _result;
            }
            
            public bool EndDeletePhrase(System.IAsyncResult result) {
                object[] _args = new object[0];
                bool _result = ((bool)(base.EndInvoke("DeletePhrase", _args, result)));
                return _result;
            }
        }
    }
}
