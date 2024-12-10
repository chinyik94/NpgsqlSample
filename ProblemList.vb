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

Partial Public Class ProblemList
    Public Property ProblemListID As Integer
    Public Property DiseaseID_FK As Integer
    Public Property ProblemInfo As String
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property TypeOfGoal As Nullable(Of Integer)
    Public Property DiseaseSubInfoID_FK As Nullable(Of Integer)

    Public Overridable Property Activity As ICollection(Of Activity) = New HashSet(Of Activity)
    Public Overridable Property CarePlanSubProblemList As ICollection(Of CarePlanSubProblemList) = New HashSet(Of CarePlanSubProblemList)
    Public Overridable Property Disease As Disease
    Public Overridable Property ProblemListGoal As ICollection(Of ProblemListGoal) = New HashSet(Of ProblemListGoal)

End Class
