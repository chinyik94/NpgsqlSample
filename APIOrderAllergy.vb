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

Partial Public Class APIOrderAllergy
    Public Property APIOrderAllergyID As Integer
    Public Property APIOrderID_FK As Integer
    Public Property AllergyAgentID As Nullable(Of Integer)
    Public Property AllergyAgent As String
    Public Property AllergyReactionID As Nullable(Of Integer)
    Public Property AllergyReaction As String
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property IsDeleted As Boolean

    Public Overridable Property APIOrder As APIOrder

End Class