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

Partial Public Class CarePlanSubGoal
    Public Property CarePlanSubGoalID As Integer
    Public Property CarePlanSubID_FK As Integer
    Public Property ScoreTypeID As Nullable(Of Integer)
    Public Property OperatorID As Nullable(Of Integer)
    Public Property Score1 As Nullable(Of Decimal)
    Public Property Score2 As Nullable(Of Decimal)
    Public Property CarePlanSubGoalName As String
    Public Property IsDeleted As Nullable(Of Boolean)
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property DiseaseID_FK As Nullable(Of Integer)

    Public Overridable Property CarePlanSub As CarePlanSub
    Public Overridable Property Disease As Disease

End Class