﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace wsDefault
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.CollectionDataContractAttribute(Name:="ArrayOfString", [Namespace]:="http://tempuri.org/", ItemName:="string"),  _
     System.SerializableAttribute()>  _
    Public Class ArrayOfString
        Inherits System.Collections.Generic.List(Of String)
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="wsDefault.ServiceSoap")>  _
    Public Interface ServiceSoap
        
        'CODEGEN: Generating message contract since element name To from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/MailSendList", ReplyAction:="*")>  _
        Function MailSendList(ByVal request As wsDefault.MailSendListRequest) As wsDefault.MailSendListResponse
        
        'CODEGEN: Generating message contract since element name mail_to from namespace http://tempuri.org/ is not marked nillable
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/MailSend", ReplyAction:="*")>  _
        Function MailSend(ByVal request As wsDefault.MailSendRequest) As wsDefault.MailSendResponse
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class MailSendListRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="MailSendList", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As wsDefault.MailSendListRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As wsDefault.MailSendListRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class MailSendListRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public [To] As wsDefault.ArrayOfString
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public Subject As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public Body As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public From As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public FromAliasName As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public Cc As wsDefault.ArrayOfString
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public Bcc As wsDefault.ArrayOfString
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public Signature As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=8)>  _
        Public Authentication As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal [To] As wsDefault.ArrayOfString, ByVal Subject As String, ByVal Body As String, ByVal From As String, ByVal FromAliasName As String, ByVal Cc As wsDefault.ArrayOfString, ByVal Bcc As wsDefault.ArrayOfString, ByVal Signature As String, ByVal Authentication As Boolean)
            MyBase.New
            Me.[To] = [To]
            Me.Subject = Subject
            Me.Body = Body
            Me.From = From
            Me.FromAliasName = FromAliasName
            Me.Cc = Cc
            Me.Bcc = Bcc
            Me.Signature = Signature
            Me.Authentication = Authentication
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class MailSendListResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="MailSendListResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As wsDefault.MailSendListResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As wsDefault.MailSendListResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class MailSendListResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public MailSendListResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal MailSendListResult As Boolean)
            MyBase.New
            Me.MailSendListResult = MailSendListResult
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class MailSendRequest
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="MailSend", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As wsDefault.MailSendRequestBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As wsDefault.MailSendRequestBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class MailSendRequestBody
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=0)>  _
        Public mail_to As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=1)>  _
        Public mail_subject As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=2)>  _
        Public mail_body As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=3)>  _
        Public mail_from As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=4)>  _
        Public mail_from_aliasname As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=5)>  _
        Public mail_cc As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=6)>  _
        Public mail_bcc As String
        
        <System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue:=false, Order:=7)>  _
        Public mail_signature As String
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=8)>  _
        Public useAuthen As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal mail_to As String, ByVal mail_subject As String, ByVal mail_body As String, ByVal mail_from As String, ByVal mail_from_aliasname As String, ByVal mail_cc As String, ByVal mail_bcc As String, ByVal mail_signature As String, ByVal useAuthen As Boolean)
            MyBase.New
            Me.mail_to = mail_to
            Me.mail_subject = mail_subject
            Me.mail_body = mail_body
            Me.mail_from = mail_from
            Me.mail_from_aliasname = mail_from_aliasname
            Me.mail_cc = mail_cc
            Me.mail_bcc = mail_bcc
            Me.mail_signature = mail_signature
            Me.useAuthen = useAuthen
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=false)>  _
    Partial Public Class MailSendResponse
        
        <System.ServiceModel.MessageBodyMemberAttribute(Name:="MailSendResponse", [Namespace]:="http://tempuri.org/", Order:=0)>  _
        Public Body As wsDefault.MailSendResponseBody
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal Body As wsDefault.MailSendResponseBody)
            MyBase.New
            Me.Body = Body
        End Sub
    End Class
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced),  _
     System.Runtime.Serialization.DataContractAttribute([Namespace]:="http://tempuri.org/")>  _
    Partial Public Class MailSendResponseBody
        
        <System.Runtime.Serialization.DataMemberAttribute(Order:=0)>  _
        Public MailSendResult As Boolean
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal MailSendResult As Boolean)
            MyBase.New
            Me.MailSendResult = MailSendResult
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServiceSoapChannel
        Inherits wsDefault.ServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of wsDefault.ServiceSoap)
        Implements wsDefault.ServiceSoap
        
        Public Sub New()
            MyBase.New
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function wsDefault_ServiceSoap_MailSendList(ByVal request As wsDefault.MailSendListRequest) As wsDefault.MailSendListResponse Implements wsDefault.ServiceSoap.MailSendList
            Return MyBase.Channel.MailSendList(request)
        End Function
        
        Public Function MailSendList(ByVal [To] As wsDefault.ArrayOfString, ByVal Subject As String, ByVal Body As String, ByVal From As String, ByVal FromAliasName As String, ByVal Cc As wsDefault.ArrayOfString, ByVal Bcc As wsDefault.ArrayOfString, ByVal Signature As String, ByVal Authentication As Boolean) As Boolean
            Dim inValue As wsDefault.MailSendListRequest = New wsDefault.MailSendListRequest()
            inValue.Body = New wsDefault.MailSendListRequestBody()
            inValue.Body.[To] = [To]
            inValue.Body.Subject = Subject
            inValue.Body.Body = Body
            inValue.Body.From = From
            inValue.Body.FromAliasName = FromAliasName
            inValue.Body.Cc = Cc
            inValue.Body.Bcc = Bcc
            inValue.Body.Signature = Signature
            inValue.Body.Authentication = Authentication
            Dim retVal As wsDefault.MailSendListResponse = CType(Me,wsDefault.ServiceSoap).MailSendList(inValue)
            Return retVal.Body.MailSendListResult
        End Function
        
        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Function wsDefault_ServiceSoap_MailSend(ByVal request As wsDefault.MailSendRequest) As wsDefault.MailSendResponse Implements wsDefault.ServiceSoap.MailSend
            Return MyBase.Channel.MailSend(request)
        End Function
        
        Public Function MailSend(ByVal mail_to As String, ByVal mail_subject As String, ByVal mail_body As String, ByVal mail_from As String, ByVal mail_from_aliasname As String, ByVal mail_cc As String, ByVal mail_bcc As String, ByVal mail_signature As String, ByVal useAuthen As Boolean) As Boolean
            Dim inValue As wsDefault.MailSendRequest = New wsDefault.MailSendRequest()
            inValue.Body = New wsDefault.MailSendRequestBody()
            inValue.Body.mail_to = mail_to
            inValue.Body.mail_subject = mail_subject
            inValue.Body.mail_body = mail_body
            inValue.Body.mail_from = mail_from
            inValue.Body.mail_from_aliasname = mail_from_aliasname
            inValue.Body.mail_cc = mail_cc
            inValue.Body.mail_bcc = mail_bcc
            inValue.Body.mail_signature = mail_signature
            inValue.Body.useAuthen = useAuthen
            Dim retVal As wsDefault.MailSendResponse = CType(Me,wsDefault.ServiceSoap).MailSend(inValue)
            Return retVal.Body.MailSendResult
        End Function
    End Class
End Namespace