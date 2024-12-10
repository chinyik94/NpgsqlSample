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

Partial Public Class CareReportSystemInfo
    Public Property CareReportSystemInfoID As Integer
    Public Property IsUpdatePrimaryDoctor As Nullable(Of Boolean)
    Public Property PrimaryDoctorUserID_FK As Nullable(Of Integer)
    Public Property PrimaryDoctorName As String
    Public Property IsUpdateSecondaryDoctor As Nullable(Of Boolean)
    Public Property SecondaryDoctorUserID_FK As Nullable(Of Integer)
    Public Property SecondaryDoctorName As String
    Public Property IsUpdateKeyPerson1 As Nullable(Of Boolean)
    Public Property KeyPerson1UserID_FK As Nullable(Of Integer)
    Public Property IsUpdateKeyPerson2 As Nullable(Of Boolean)
    Public Property KeyPerson2UserID_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsUpdateFamily As Boolean

    Public Overridable Property CareReport As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property PatientClinician As PatientClinician
    Public Overridable Property PatientClinician1 As PatientClinician
    Public Overridable Property Users As Users
    Public Overridable Property Users1 As Users

End Class