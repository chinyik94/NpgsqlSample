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

Partial Public Class PatientOtherAllergy
    Public Property OtherAllergyID As Integer
    Public Property PatientID_FK As Nullable(Of Integer)
    Public Property InitialCareAssessmentID_FK As Nullable(Of Integer)
    Public Property ReactionID_FK As Nullable(Of Integer)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean
    Public Property DescriptionID_FK As Nullable(Of Integer)
    Public Property OtherDescription As String
    Public Property ReferID_FK As Nullable(Of Integer)

    Public Overridable Property Code As Code
    Public Overridable Property Code1 As Code
    Public Overridable Property InitialCareAssessment As InitialCareAssessment
    Public Overridable Property Patient As Patient
    Public Overridable Property PatientOtherAllergy1 As ICollection(Of PatientOtherAllergy) = New HashSet(Of PatientOtherAllergy)
    Public Overridable Property PatientOtherAllergy2 As PatientOtherAllergy

End Class
