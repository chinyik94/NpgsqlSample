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

Partial Public Class Audit_DischargeSummaryReport
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property DischargeSummaryReportId As Integer
    Public Property PatientID_FK As Integer
    Public Property Status As String
    Public Property DischargeDate As Nullable(Of Date)
    Public Property VisitDateStart As Nullable(Of Date)
    Public Property VisitDateEnd As Nullable(Of Date)
    Public Property VisitedBy_FK As Nullable(Of Integer)
    Public Property SummaryCaseNote As String
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

End Class
