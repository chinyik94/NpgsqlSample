'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class MobileAppVersioning
    Public Property MobileVersionId As Integer
    Public Property AppName As String
    Public Property DeviceType As String
    Public Property Version As String
    Public Property Status As String
    Public Property IsDeleted As Nullable(Of Boolean)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)

    Public Overridable Property Users As Users
    Public Overridable Property Users1 As Users

End Class