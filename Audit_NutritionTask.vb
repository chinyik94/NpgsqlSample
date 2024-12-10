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

Partial Public Class Audit_NutritionTask
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property NutritionTaskID As Integer
    Public Property ActionTypeID_FK As Integer
    Public Property PatientID_FK As Nullable(Of Integer)
    Public Property Food As String
    Public Property Liquid As String
    Public Property Method As String
    Public Property BeforeImage As String
    Public Property AfterImage As String
    Public Property Remarks As String
    Public Property TypeReferenceID_FK As Nullable(Of Integer)
    Public Property AmountReferenceID_FK As Nullable(Of Integer)
    Public Property ColorReferenceID_FK As Nullable(Of Integer)
    Public Property StartTime As Date
    Public Property EndTime As Nullable(Of Date)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean
    Public Property GivenAmount As Nullable(Of Integer)
    Public Property TakenAmount As Nullable(Of Integer)
    Public Property Unit As String

End Class
