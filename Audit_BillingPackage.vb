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

Partial Public Class Audit_BillingPackage
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property ID As Nullable(Of Integer)
    Public Property Name As String
    Public Property Description As String
    Public Property Type As String
    Public Property Session As Nullable(Of Integer)
    Public Property TotalPrice As Nullable(Of Decimal)
    Public Property UnitPrice As Nullable(Of Decimal)
    Public Property Validity As Nullable(Of Integer)
    Public Property Status As String
    Public Property Remarks As String
    Public Property BillingServiceID As Integer
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Integer
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

End Class
