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

Partial Public Class Audit_BillingInvoice
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property BillingInvoiceID As Integer
    Public Property PatientID_FK As Integer
    Public Property InvoiceNumber As String
    Public Property InvoiceDueDate As Nullable(Of Date)
    Public Property CaseNumber As String
    Public Property InitialCareAssessmentID_FK As Nullable(Of Integer)
    Public Property CareReportID_FK As Nullable(Of Integer)
    Public Property Consumable As Nullable(Of Boolean)
    Public Property SendEmail As Nullable(Of Boolean)
    Public Property EmailPatient As Nullable(Of Boolean)
    Public Property EmailTo As String
    Public Property EmailCC As String
    Public Property EmailBCC As String
    Public Property CurrencyID_FK As Integer
    Public Property TotalCost As Decimal
    Public Property Status As String
    Public Property GroupNumber As String
    Public Property Version As Short
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Integer
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean
    Public Property InvoiceDate As Nullable(Of Date)

End Class
