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

Namespace ServiceReference1
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="CompositeType", [Namespace]:="http://schemas.datacontract.org/2004/07/WcfService13"),  _
     System.SerializableAttribute()>  _
    Partial Public Class CompositeType
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private BoolValueField As Boolean
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private StringValueField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property BoolValue() As Boolean
            Get
                Return Me.BoolValueField
            End Get
            Set
                If (Me.BoolValueField.Equals(value) <> true) Then
                    Me.BoolValueField = value
                    Me.RaisePropertyChanged("BoolValue")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property StringValue() As String
            Get
                Return Me.StringValueField
            End Get
            Set
                If (Object.ReferenceEquals(Me.StringValueField, value) <> true) Then
                    Me.StringValueField = value
                    Me.RaisePropertyChanged("StringValue")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.ISQLService")>  _
    Public Interface ISQLService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISQLService/GetData", ReplyAction:="http://tempuri.org/ISQLService/GetDataResponse")>  _
        Function GetData(ByVal value As String) As String
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISQLService/GetData", ReplyAction:="http://tempuri.org/ISQLService/GetDataResponse")>  _
        Function GetDataAsync(ByVal value As String) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISQLService/GetDataUsingDataContract", ReplyAction:="http://tempuri.org/ISQLService/GetDataUsingDataContractResponse")>  _
        Function GetDataUsingDataContract(ByVal composite As ServiceReference1.CompositeType) As ServiceReference1.CompositeType
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/ISQLService/GetDataUsingDataContract", ReplyAction:="http://tempuri.org/ISQLService/GetDataUsingDataContractResponse")>  _
        Function GetDataUsingDataContractAsync(ByVal composite As ServiceReference1.CompositeType) As System.Threading.Tasks.Task(Of ServiceReference1.CompositeType)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface ISQLServiceChannel
        Inherits ServiceReference1.ISQLService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class SQLServiceClient
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.ISQLService)
        Implements ServiceReference1.ISQLService
        
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
        
        Public Function GetData(ByVal value As String) As String Implements ServiceReference1.ISQLService.GetData
            Return MyBase.Channel.GetData(value)
        End Function
        
        Public Function GetDataAsync(ByVal value As String) As System.Threading.Tasks.Task(Of String) Implements ServiceReference1.ISQLService.GetDataAsync
            Return MyBase.Channel.GetDataAsync(value)
        End Function
        
        Public Function GetDataUsingDataContract(ByVal composite As ServiceReference1.CompositeType) As ServiceReference1.CompositeType Implements ServiceReference1.ISQLService.GetDataUsingDataContract
            Return MyBase.Channel.GetDataUsingDataContract(composite)
        End Function
        
        Public Function GetDataUsingDataContractAsync(ByVal composite As ServiceReference1.CompositeType) As System.Threading.Tasks.Task(Of ServiceReference1.CompositeType) Implements ServiceReference1.ISQLService.GetDataUsingDataContractAsync
            Return MyBase.Channel.GetDataUsingDataContractAsync(composite)
        End Function
    End Class
End Namespace
