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

Partial Public Class Audit_APIOrder
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property APIOrderId As Integer
    Public Property OrderID As String
    Public Property ResourceType As String
    Public Property PatientID As Nullable(Of Integer)
    Public Property PatientNRIC As String
    Public Property PatientFirstName As String
    Public Property PatientLastName As String
    Public Property OrderedByID As Nullable(Of Integer)
    Public Property OrderedByName As String
    Public Property OrderedByInstitution As String
    Public Property OrderedByInstitutionID As Nullable(Of Integer)
    Public Property DoctorMCR As String
    Public Property AcceptedBy As Nullable(Of Integer)
    Public Property AcceptedByName As String
    Public Property AcceptedInstitutionName As String
    Public Property AcceptedInstitutionID As Nullable(Of Integer)
    Public Property Clinicalsynopsis As String
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

End Class