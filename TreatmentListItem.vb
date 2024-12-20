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

Partial Public Class TreatmentListItem
    Public Property TListItemID As Integer
    Public Property ItemName As String
    Public Property TListTypeID_FK As Integer
    Public Property IsActive As Nullable(Of Boolean)
    Public Property IsSystemUsed As Nullable(Of Boolean)
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Integer
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property ItemBrand As String
    Public Property Cost As Nullable(Of Decimal)
    Public Property StartDate As Nullable(Of Date)
    Public Property EndDate As Nullable(Of Date)

    Public Overridable Property Code As Code
    Public Overridable Property PatientWoundDraftTreatmentList As ICollection(Of PatientWoundDraftTreatmentList) = New HashSet(Of PatientWoundDraftTreatmentList)
    Public Overridable Property PatientWoundVisitTreatmentList As ICollection(Of PatientWoundVisitTreatmentList) = New HashSet(Of PatientWoundVisitTreatmentList)
    Public Overridable Property TreatmentTOL As ICollection(Of TreatmentTOL) = New HashSet(Of TreatmentTOL)

End Class
