﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.832
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.832.
// 
#pragma warning disable 1591

namespace com.sensepost.SPUDHelperClasses.com.google.api {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="GoogleSearchBinding", Namespace="urn:GoogleSearch")]
    [System.Xml.Serialization.SoapIncludeAttribute(typeof(ResultElement))]
    public partial class GoogleSearchService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback doGetCachedPageOperationCompleted;
        
        private System.Threading.SendOrPostCallback doSpellingSuggestionOperationCompleted;
        
        private System.Threading.SendOrPostCallback doGoogleSearchOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public GoogleSearchService() {
            this.Url = global::com.sensepost.SPUDHelperClasses.Properties.Settings.Default.SPUDHelperClasses_com_google_api_GoogleSearchService;
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
        public event doGetCachedPageCompletedEventHandler doGetCachedPageCompleted;
        
        /// <remarks/>
        public event doSpellingSuggestionCompletedEventHandler doSpellingSuggestionCompleted;
        
        /// <remarks/>
        public event doGoogleSearchCompletedEventHandler doGoogleSearchCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:GoogleSearchAction", RequestNamespace="urn:GoogleSearch", ResponseNamespace="urn:GoogleSearch")]
        [return: System.Xml.Serialization.SoapElementAttribute("return", DataType="base64Binary")]
        public byte[] doGetCachedPage(string key, string url) {
            object[] results = this.Invoke("doGetCachedPage", new object[] {
                        key,
                        url});
            return ((byte[])(results[0]));
        }
        
        /// <remarks/>
        public void doGetCachedPageAsync(string key, string url) {
            this.doGetCachedPageAsync(key, url, null);
        }
        
        /// <remarks/>
        public void doGetCachedPageAsync(string key, string url, object userState) {
            if ((this.doGetCachedPageOperationCompleted == null)) {
                this.doGetCachedPageOperationCompleted = new System.Threading.SendOrPostCallback(this.OndoGetCachedPageOperationCompleted);
            }
            this.InvokeAsync("doGetCachedPage", new object[] {
                        key,
                        url}, this.doGetCachedPageOperationCompleted, userState);
        }
        
        private void OndoGetCachedPageOperationCompleted(object arg) {
            if ((this.doGetCachedPageCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.doGetCachedPageCompleted(this, new doGetCachedPageCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:GoogleSearchAction", RequestNamespace="urn:GoogleSearch", ResponseNamespace="urn:GoogleSearch")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public string doSpellingSuggestion(string key, string phrase) {
            object[] results = this.Invoke("doSpellingSuggestion", new object[] {
                        key,
                        phrase});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void doSpellingSuggestionAsync(string key, string phrase) {
            this.doSpellingSuggestionAsync(key, phrase, null);
        }
        
        /// <remarks/>
        public void doSpellingSuggestionAsync(string key, string phrase, object userState) {
            if ((this.doSpellingSuggestionOperationCompleted == null)) {
                this.doSpellingSuggestionOperationCompleted = new System.Threading.SendOrPostCallback(this.OndoSpellingSuggestionOperationCompleted);
            }
            this.InvokeAsync("doSpellingSuggestion", new object[] {
                        key,
                        phrase}, this.doSpellingSuggestionOperationCompleted, userState);
        }
        
        private void OndoSpellingSuggestionOperationCompleted(object arg) {
            if ((this.doSpellingSuggestionCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.doSpellingSuggestionCompleted(this, new doSpellingSuggestionCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("urn:GoogleSearchAction", RequestNamespace="urn:GoogleSearch", ResponseNamespace="urn:GoogleSearch")]
        [return: System.Xml.Serialization.SoapElementAttribute("return")]
        public GoogleSearchResult doGoogleSearch(string key, string q, int start, int maxResults, bool filter, string restrict, bool safeSearch, string lr, string ie, string oe) {
            object[] results = this.Invoke("doGoogleSearch", new object[] {
                        key,
                        q,
                        start,
                        maxResults,
                        filter,
                        restrict,
                        safeSearch,
                        lr,
                        ie,
                        oe});
            return ((GoogleSearchResult)(results[0]));
        }
        
        /// <remarks/>
        public void doGoogleSearchAsync(string key, string q, int start, int maxResults, bool filter, string restrict, bool safeSearch, string lr, string ie, string oe) {
            this.doGoogleSearchAsync(key, q, start, maxResults, filter, restrict, safeSearch, lr, ie, oe, null);
        }
        
        /// <remarks/>
        public void doGoogleSearchAsync(string key, string q, int start, int maxResults, bool filter, string restrict, bool safeSearch, string lr, string ie, string oe, object userState) {
            if ((this.doGoogleSearchOperationCompleted == null)) {
                this.doGoogleSearchOperationCompleted = new System.Threading.SendOrPostCallback(this.OndoGoogleSearchOperationCompleted);
            }
            this.InvokeAsync("doGoogleSearch", new object[] {
                        key,
                        q,
                        start,
                        maxResults,
                        filter,
                        restrict,
                        safeSearch,
                        lr,
                        ie,
                        oe}, this.doGoogleSearchOperationCompleted, userState);
        }
        
        private void OndoGoogleSearchOperationCompleted(object arg) {
            if ((this.doGoogleSearchCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.doGoogleSearchCompleted(this, new doGoogleSearchCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.832")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:GoogleSearch")]
    public partial class GoogleSearchResult {
        
        private bool documentFilteringField;
        
        private string searchCommentsField;
        
        private int estimatedTotalResultsCountField;
        
        private bool estimateIsExactField;
        
        private ResultElement[] resultElementsField;
        
        private string searchQueryField;
        
        private int startIndexField;
        
        private int endIndexField;
        
        private string searchTipsField;
        
        private DirectoryCategory[] directoryCategoriesField;
        
        private double searchTimeField;
        
        /// <remarks/>
        public bool documentFiltering {
            get {
                return this.documentFilteringField;
            }
            set {
                this.documentFilteringField = value;
            }
        }
        
        /// <remarks/>
        public string searchComments {
            get {
                return this.searchCommentsField;
            }
            set {
                this.searchCommentsField = value;
            }
        }
        
        /// <remarks/>
        public int estimatedTotalResultsCount {
            get {
                return this.estimatedTotalResultsCountField;
            }
            set {
                this.estimatedTotalResultsCountField = value;
            }
        }
        
        /// <remarks/>
        public bool estimateIsExact {
            get {
                return this.estimateIsExactField;
            }
            set {
                this.estimateIsExactField = value;
            }
        }
        
        /// <remarks/>
        public ResultElement[] resultElements {
            get {
                return this.resultElementsField;
            }
            set {
                this.resultElementsField = value;
            }
        }
        
        /// <remarks/>
        public string searchQuery {
            get {
                return this.searchQueryField;
            }
            set {
                this.searchQueryField = value;
            }
        }
        
        /// <remarks/>
        public int startIndex {
            get {
                return this.startIndexField;
            }
            set {
                this.startIndexField = value;
            }
        }
        
        /// <remarks/>
        public int endIndex {
            get {
                return this.endIndexField;
            }
            set {
                this.endIndexField = value;
            }
        }
        
        /// <remarks/>
        public string searchTips {
            get {
                return this.searchTipsField;
            }
            set {
                this.searchTipsField = value;
            }
        }
        
        /// <remarks/>
        public DirectoryCategory[] directoryCategories {
            get {
                return this.directoryCategoriesField;
            }
            set {
                this.directoryCategoriesField = value;
            }
        }
        
        /// <remarks/>
        public double searchTime {
            get {
                return this.searchTimeField;
            }
            set {
                this.searchTimeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.832")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:GoogleSearch")]
    public partial class ResultElement {
        
        private string summaryField;
        
        private string uRLField;
        
        private string snippetField;
        
        private string titleField;
        
        private string cachedSizeField;
        
        private bool relatedInformationPresentField;
        
        private string hostNameField;
        
        private DirectoryCategory directoryCategoryField;
        
        private string directoryTitleField;
        
        /// <remarks/>
        public string summary {
            get {
                return this.summaryField;
            }
            set {
                this.summaryField = value;
            }
        }
        
        /// <remarks/>
        public string URL {
            get {
                return this.uRLField;
            }
            set {
                this.uRLField = value;
            }
        }
        
        /// <remarks/>
        public string snippet {
            get {
                return this.snippetField;
            }
            set {
                this.snippetField = value;
            }
        }
        
        /// <remarks/>
        public string title {
            get {
                return this.titleField;
            }
            set {
                this.titleField = value;
            }
        }
        
        /// <remarks/>
        public string cachedSize {
            get {
                return this.cachedSizeField;
            }
            set {
                this.cachedSizeField = value;
            }
        }
        
        /// <remarks/>
        public bool relatedInformationPresent {
            get {
                return this.relatedInformationPresentField;
            }
            set {
                this.relatedInformationPresentField = value;
            }
        }
        
        /// <remarks/>
        public string hostName {
            get {
                return this.hostNameField;
            }
            set {
                this.hostNameField = value;
            }
        }
        
        /// <remarks/>
        public DirectoryCategory directoryCategory {
            get {
                return this.directoryCategoryField;
            }
            set {
                this.directoryCategoryField = value;
            }
        }
        
        /// <remarks/>
        public string directoryTitle {
            get {
                return this.directoryTitleField;
            }
            set {
                this.directoryTitleField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.832")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="urn:GoogleSearch")]
    public partial class DirectoryCategory {
        
        private string fullViewableNameField;
        
        private string specialEncodingField;
        
        /// <remarks/>
        public string fullViewableName {
            get {
                return this.fullViewableNameField;
            }
            set {
                this.fullViewableNameField = value;
            }
        }
        
        /// <remarks/>
        public string specialEncoding {
            get {
                return this.specialEncodingField;
            }
            set {
                this.specialEncodingField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void doGetCachedPageCompletedEventHandler(object sender, doGetCachedPageCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class doGetCachedPageCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal doGetCachedPageCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public byte[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((byte[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void doSpellingSuggestionCompletedEventHandler(object sender, doSpellingSuggestionCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class doSpellingSuggestionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal doSpellingSuggestionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    public delegate void doGoogleSearchCompletedEventHandler(object sender, doGoogleSearchCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class doGoogleSearchCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal doGoogleSearchCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GoogleSearchResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GoogleSearchResult)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591