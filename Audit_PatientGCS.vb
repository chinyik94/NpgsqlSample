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

Partial Public Class Audit_PatientGCS
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property PatientGCSID As Integer
    Public Property Type As String
    Public Property VitalSignDetailID_FK As Nullable(Of Integer)
    Public Property Score1 As Nullable(Of Integer)
    Public Property Score2 As Nullable(Of Integer)
    Public Property Score3 As Nullable(Of Integer)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

End Class
