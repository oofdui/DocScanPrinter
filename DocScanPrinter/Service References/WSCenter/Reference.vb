﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34014
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Data

Namespace WSCenter
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="WSCenter.ServiceSoap")>  _
    Public Interface ServiceSoap
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/InsertLogApplication", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Sub InsertLogApplication(ByVal strAppName As String, ByVal strUser As String, ByVal strIp As String, ByVal strComName As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/InsertLogApplicationBySite", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Sub InsertLogApplicationBySite(ByVal strAppName As String, ByVal strAppName_Sub As String, ByVal strSite As String, ByVal strUser As String, ByVal strIp As String, ByVal strComName As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/Usage_Log_Insert", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Sub Usage_Log_Insert(ByVal appname As String, ByVal usern As String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/checkAppAuthorize", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function checkAppAuthorize(ByVal usern As String, ByVal dept_id As String, ByVal app_id As String) As Boolean
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/LoginChecker", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function LoginChecker(ByVal usern As String, ByVal pwd As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/getDept", ReplyAction:="*"),  _
         System.ServiceModel.XmlSerializerFormatAttribute()>  _
        Function getDept() As System.Data.DataSet
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ServiceSoapChannel
        Inherits WSCenter.ServiceSoap, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class ServiceSoapClient
        Inherits System.ServiceModel.ClientBase(Of WSCenter.ServiceSoap)
        Implements WSCenter.ServiceSoap
        
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
        
        Public Sub InsertLogApplication(ByVal strAppName As String, ByVal strUser As String, ByVal strIp As String, ByVal strComName As String) Implements WSCenter.ServiceSoap.InsertLogApplication
            MyBase.Channel.InsertLogApplication(strAppName, strUser, strIp, strComName)
        End Sub
        
        Public Sub InsertLogApplicationBySite(ByVal strAppName As String, ByVal strAppName_Sub As String, ByVal strSite As String, ByVal strUser As String, ByVal strIp As String, ByVal strComName As String) Implements WSCenter.ServiceSoap.InsertLogApplicationBySite
            MyBase.Channel.InsertLogApplicationBySite(strAppName, strAppName_Sub, strSite, strUser, strIp, strComName)
        End Sub
        
        Public Sub Usage_Log_Insert(ByVal appname As String, ByVal usern As String) Implements WSCenter.ServiceSoap.Usage_Log_Insert
            MyBase.Channel.Usage_Log_Insert(appname, usern)
        End Sub
        
        Public Function checkAppAuthorize(ByVal usern As String, ByVal dept_id As String, ByVal app_id As String) As Boolean Implements WSCenter.ServiceSoap.checkAppAuthorize
            Return MyBase.Channel.checkAppAuthorize(usern, dept_id, app_id)
        End Function
        
        Public Function LoginChecker(ByVal usern As String, ByVal pwd As String) As String Implements WSCenter.ServiceSoap.LoginChecker
            Return MyBase.Channel.LoginChecker(usern, pwd)
        End Function
        
        Public Function getDept() As System.Data.DataSet Implements WSCenter.ServiceSoap.getDept
            Return MyBase.Channel.getDept
        End Function
    End Class
End Namespace
