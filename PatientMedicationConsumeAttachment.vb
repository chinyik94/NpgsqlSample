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

Partial Public Class PatientMedicationConsumeAttachment
    Public Property PatientMedicationConsumeAttachmentID As Integer
    Public Property PatientMedicationConsumeID_FK As Integer
    Public Property Filename As String
    Public Property Physical As String
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean
    Public Property IsEndDate As Nullable(Of Boolean)

    Public Overridable Property PatientMedicationConsume As PatientMedicationConsume

End Class
