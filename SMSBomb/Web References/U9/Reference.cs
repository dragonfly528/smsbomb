﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// 此源代码是由 Microsoft.VSDesigner 4.0.30319.42000 版自动生成。
// 
#pragma warning disable 1591

namespace SMSBomb.U9 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_CustomerServiceInter.ICSService", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExceptionDetail))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ThreadContext))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlatformContext))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationContext))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Exception[]))]
    public partial class CSServiceStub : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CSServiceStub() {
            this.Url = global::SMSBomb.Properties.Settings.Default.SMSBomb_U9_CSServiceStub;
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
        public event DoCompletedEventHandler DoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://www.UFIDA.org/CustomerServiceInter.ICSService/Do", RequestNamespace="http://www.UFIDA.org", ResponseNamespace="http://www.UFIDA.org", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Do([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] object context, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string jSON, [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string iCode, [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)] [System.Xml.Serialization.XmlArrayItemAttribute(Namespace="UFSoft.UBF.Exceptions")] out MessageBase[] outMessages) {
            object[] results = this.Invoke("Do", new object[] {
                        context,
                        jSON,
                        iCode});
            outMessages = ((MessageBase[])(results[1]));
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DoAsync(object context, string jSON, string iCode) {
            this.DoAsync(context, jSON, iCode, null);
        }
        
        /// <remarks/>
        public void DoAsync(object context, string jSON, string iCode, object userState) {
            if ((this.DoOperationCompleted == null)) {
                this.DoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDoOperationCompleted);
            }
            this.InvokeAsync("Do", new object[] {
                        context,
                        jSON,
                        iCode}, this.DoOperationCompleted, userState);
        }
        
        private void OnDoOperationCompleted(object arg) {
            if ((this.DoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DoCompleted(this, new DoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="UFSoft.UBF.Exceptions")]
    public partial class MessageBase {
        
        private string attributeMetadataIDField;
        
        private string attributeNameField;
        
        private string entityFullNameField;
        
        private long entityIDField;
        
        private bool entityIDFieldSpecified;
        
        private string entityMetadataIDField;
        
        private short errorLevelField;
        
        private bool errorLevelFieldSpecified;
        
        private MessageBaseFormatState formatedField;
        
        private bool formatedFieldSpecified;
        
        private MessageBase[] innerMessagesField;
        
        private bool isValidEntityIDField;
        
        private bool isValidEntityIDFieldSpecified;
        
        private string localMessageField;
        
        private string orginalEntityFullNameField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string attributeMetadataID {
            get {
                return this.attributeMetadataIDField;
            }
            set {
                this.attributeMetadataIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string attributeName {
            get {
                return this.attributeNameField;
            }
            set {
                this.attributeNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string entityFullName {
            get {
                return this.entityFullNameField;
            }
            set {
                this.entityFullNameField = value;
            }
        }
        
        /// <remarks/>
        public long entityID {
            get {
                return this.entityIDField;
            }
            set {
                this.entityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool entityIDSpecified {
            get {
                return this.entityIDFieldSpecified;
            }
            set {
                this.entityIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string entityMetadataID {
            get {
                return this.entityMetadataIDField;
            }
            set {
                this.entityMetadataIDField = value;
            }
        }
        
        /// <remarks/>
        public short errorLevel {
            get {
                return this.errorLevelField;
            }
            set {
                this.errorLevelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool errorLevelSpecified {
            get {
                return this.errorLevelFieldSpecified;
            }
            set {
                this.errorLevelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public MessageBaseFormatState formated {
            get {
                return this.formatedField;
            }
            set {
                this.formatedField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool formatedSpecified {
            get {
                return this.formatedFieldSpecified;
            }
            set {
                this.formatedFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public MessageBase[] innerMessages {
            get {
                return this.innerMessagesField;
            }
            set {
                this.innerMessagesField = value;
            }
        }
        
        /// <remarks/>
        public bool isValidEntityID {
            get {
                return this.isValidEntityIDField;
            }
            set {
                this.isValidEntityIDField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool isValidEntityIDSpecified {
            get {
                return this.isValidEntityIDFieldSpecified;
            }
            set {
                this.isValidEntityIDFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string localMessage {
            get {
                return this.localMessageField;
            }
            set {
                this.localMessageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string orginalEntityFullName {
            get {
                return this.orginalEntityFullNameField;
            }
            set {
                this.orginalEntityFullNameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(TypeName="MessageBase.FormatState", Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Exceptions")]
    public enum MessageBaseFormatState {
        
        /// <remarks/>
        None,
        
        /// <remarks/>
        Formatting,
        
        /// <remarks/>
        Formatted,
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceExceptionDetail))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System.ServiceModel")]
    public partial class ExceptionDetail {
        
        private string helpLinkField;
        
        private ExceptionDetail innerExceptionField;
        
        private string messageField;
        
        private string stackTraceField;
        
        private string typeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string HelpLink {
            get {
                return this.helpLinkField;
            }
            set {
                this.helpLinkField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ExceptionDetail InnerException {
            get {
                return this.innerExceptionField;
            }
            set {
                this.innerExceptionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string StackTrace {
            get {
                return this.stackTraceField;
            }
            set {
                this.stackTraceField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string Type {
            get {
                return this.typeField;
            }
            set {
                this.typeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Service")]
    public partial class ServiceExceptionDetail : ExceptionDetail {
        
        private ExceptionBase exceptionField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ExceptionBase Exception {
            get {
                return this.exceptionField;
            }
            set {
                this.exceptionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceLostException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNotExistException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeInValidException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttrsContainerException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnknownException))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF")]
    public partial class ExceptionBase : Exception {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExceptionBase))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceLostException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNotExistException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeInValidException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttrsContainerException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(UnknownException))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/System")]
    public partial class Exception {
        
        private System.Xml.XmlElement[] anyField;
        
        private System.Xml.XmlQualifiedName factoryTypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return this.anyField;
            }
            set {
                this.anyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://schemas.microsoft.com/2003/10/Serialization/")]
        public System.Xml.XmlQualifiedName FactoryType {
            get {
                return this.factoryTypeField;
            }
            set {
                this.factoryTypeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Service")]
    public partial class ServiceException : ExceptionBase {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Service")]
    public partial class ServiceLostException : ExceptionBase {
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EntityNotExistException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeInValidException))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AttrsContainerException))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Business")]
    public partial class BusinessException : ExceptionBase {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Business")]
    public partial class EntityNotExistException : BusinessException {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Business")]
    public partial class AttributeInValidException : BusinessException {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Business")]
    public partial class AttrsContainerException : BusinessException {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF")]
    public partial class UnknownException : ExceptionBase {
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF")]
    public partial class ErrorDescriptor {
        
        private string categoryField;
        
        private string erroridField;
        
        private ErrorLevel levelField;
        
        private bool levelFieldSpecified;
        
        private string ownerField;
        
        private System.DateTime timeStampField;
        
        private bool timeStampFieldSpecified;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string errorid {
            get {
                return this.erroridField;
            }
            set {
                this.erroridField = value;
            }
        }
        
        /// <remarks/>
        public ErrorLevel level {
            get {
                return this.levelField;
            }
            set {
                this.levelField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool levelSpecified {
            get {
                return this.levelFieldSpecified;
            }
            set {
                this.levelFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string owner {
            get {
                return this.ownerField;
            }
            set {
                this.ownerField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime timeStamp {
            get {
                return this.timeStampField;
            }
            set {
                this.timeStampField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool timeStampSpecified {
            get {
                return this.timeStampFieldSpecified;
            }
            set {
                this.timeStampFieldSpecified = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF")]
    public enum ErrorLevel {
        
        /// <remarks/>
        Debug,
        
        /// <remarks/>
        Info,
        
        /// <remarks/>
        Warn,
        
        /// <remarks/>
        Error,
        
        /// <remarks/>
        Fatal,
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF")]
    public partial class ErrorMessage {
        
        private ErrorDescriptor errDescriptorField;
        
        private string errorTypeField;
        
        private ErrorMessage[] innerMessagesField;
        
        private string messageField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public ErrorDescriptor errDescriptor {
            get {
                return this.errDescriptorField;
            }
            set {
                this.errDescriptorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string errorType {
            get {
                return this.errorTypeField;
            }
            set {
                this.errorTypeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public ErrorMessage[] innerMessages {
            get {
                return this.innerMessagesField;
            }
            set {
                this.innerMessagesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string message {
            get {
                return this.messageField;
            }
            set {
                this.messageField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Util.Context")]
    public partial class ThreadContext {
        
        private ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType[] nameValueHasField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfanyTypeanyType", Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType[] nameValueHas {
            get {
                return this.nameValueHasField;
            }
            set {
                this.nameValueHasField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays")]
    public partial class ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType {
        
        private object keyField;
        
        private object valueField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public object Key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public object Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Util.Context")]
    public partial class PlatformContext {
        
        private object ctxField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public object ctx {
            get {
                return this.ctxField;
            }
            set {
                this.ctxField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://schemas.datacontract.org/2004/07/UFSoft.UBF.Util.Context")]
    public partial class ApplicationContext {
        
        private ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType[] nameValueHasField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        [System.Xml.Serialization.XmlArrayItemAttribute("KeyValueOfanyTypeanyType", Namespace="http://schemas.microsoft.com/2003/10/Serialization/Arrays", IsNullable=false)]
        public ArrayOfKeyValueOfanyTypeanyTypeKeyValueOfanyTypeanyType[] nameValueHas {
            get {
                return this.nameValueHasField;
            }
            set {
                this.nameValueHasField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void DoCompletedEventHandler(object sender, DoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
        
        /// <remarks/>
        public MessageBase[] outMessages {
            get {
                this.RaiseExceptionIfNecessary();
                return ((MessageBase[])(this.results[1]));
            }
        }
    }
}

#pragma warning restore 1591