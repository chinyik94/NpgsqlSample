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

Partial Public Class TeleconsultationReport
    Public Property TeleReportID As Integer
    Public Property MediaType As Integer
    Public Property TaskID_FK As Integer
    Public Property PatientID_FK As Integer
    Public Property Memo As String
    Public Property Status As String
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)

End Class