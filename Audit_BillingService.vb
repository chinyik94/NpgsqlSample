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

Partial Public Class Audit_BillingService
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property ServiceID As Integer
    Public Property Title As String
    Public Property CategoryID_FK As Integer
    Public Property CostPerSession As Decimal
    Public Property Weekend As Boolean
    Public Property Status As String
    Public Property Remarks As String
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Integer
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

End Class