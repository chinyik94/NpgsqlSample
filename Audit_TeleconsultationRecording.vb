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

Partial Public Class Audit_TeleconsultationRecording
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property RecordingID As Integer
    Public Property RecordingType As Integer
    Public Property PatientID_FK As Integer
    Public Property Sid As String
    Public Property StartTime As Date
    Public Property EndTime As Date
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)

End Class
