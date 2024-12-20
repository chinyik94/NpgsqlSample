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

Partial Public Class PatientAdditionalInfo
    Public Property PatientAdditionalInfoID As Integer
    Public Property AICD As Nullable(Of Boolean)
    Public Property AICD_InsertDate As Nullable(Of Date)
    Public Property AICD_InsertedBy As String
    Public Property AICD_ReviewDate As Nullable(Of Date)
    Public Property ACP As Nullable(Of Boolean)
    Public Property ACP_DoneDate As Nullable(Of Date)
    Public Property ACP_ReviewDate As Nullable(Of Date)
    Public Property DNR As Nullable(Of Boolean)
    Public Property Pacemaker As Nullable(Of Boolean)
    Public Property Pacemaker_InsertDate As Nullable(Of Date)
    Public Property Pacemaker_InsertedBy As String
    Public Property Pacemaker_ReviewDate As Nullable(Of Date)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property DNR_DateInitiated As Nullable(Of Date)
    Public Property DNR_InitiatedBy As String
    Public Property DNR_DateTerminated As Nullable(Of Date)
    Public Property DNR_TerminatedBy As String
    Public Property CVCLine As Nullable(Of Boolean)
    Public Property CVCLine_InsertDate As Nullable(Of Date)
    Public Property CVCLine_InsertedBy As String
    Public Property CVCLine_ReviewDate As Nullable(Of Date)
    Public Property PICCLine As Nullable(Of Boolean)
    Public Property PICCLine_InsertDate As Nullable(Of Date)
    Public Property PICCLine_InsertedBy As String
    Public Property PICCLine_ReviewDate As Nullable(Of Date)
    Public Property IVLine As Nullable(Of Boolean)
    Public Property IVLine_InsertDate As Nullable(Of Date)
    Public Property IVLine_InsertedBy As String
    Public Property IVLine_ReviewDate As Nullable(Of Date)

    Public Overridable Property InitialCareAssessment As ICollection(Of InitialCareAssessment) = New HashSet(Of InitialCareAssessment)
    Public Overridable Property Patient As ICollection(Of Patient) = New HashSet(Of Patient)

End Class
