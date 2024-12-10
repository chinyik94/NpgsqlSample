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

Partial Public Class Audit_PatientWoundDraft
    Public Property AuditAction As String
    Public Property ActionTime As Date
    Public Property PatientWoundDraftID As Integer
    Public Property VisitDate As Nullable(Of Date)
    Public Property OccurDate As Nullable(Of Date)
    Public Property SeenDate As Nullable(Of Date)
    Public Property LocationOfWound As String
    Public Property Site As String
    Public Property Category As String
    Public Property Stage As String
    Public Property WoundStatusID_FK As Nullable(Of Integer)
    Public Property Comments As String
    Public Property SizeLength As Nullable(Of Decimal)
    Public Property SizeDepth As Nullable(Of Decimal)
    Public Property SizeWidth As Nullable(Of Decimal)
    Public Property Size As Nullable(Of Decimal)
    Public Property SurfaceArea As Nullable(Of Decimal)
    Public Property Perimeter As Nullable(Of Decimal)
    Public Property AverageDepth As Nullable(Of Decimal)
    Public Property MaximumDepth As Nullable(Of Decimal)
    Public Property MinimumDepth As Nullable(Of Decimal)
    Public Property Volume As Nullable(Of Decimal)
    Public Property Granulation As Nullable(Of Decimal)
    Public Property Slough As Nullable(Of Decimal)
    Public Property Necrosis As Nullable(Of Decimal)
    Public Property Epithelizing As Nullable(Of Decimal)
    Public Property Others As Nullable(Of Decimal)
    Public Property Exudate As String
    Public Property ExudateNature As String
    Public Property ExudatedConsistency As String
    Public Property Edges As String
    Public Property PeriWound As String
    Public Property Suffering As Nullable(Of Integer)
    Public Property IsRedness As Nullable(Of Boolean)
    Public Property IsSwelling As Nullable(Of Boolean)
    Public Property IsWarmToTouch As Nullable(Of Boolean)
    Public Property IsSmell As Nullable(Of Boolean)
    Public Property IsAccept As Nullable(Of Boolean)
    Public Property Reason As String
    Public Property ImageUpload As String
    Public Property OriginalImage As String
    Public Property WoundBedImage As String
    Public Property AnnotatedImage As String
    Public Property PatientWoundID_FK As Nullable(Of Integer)
    Public Property PatientWoundVisitID_FK As Nullable(Of Integer)
    Public Property AssignDate As Nullable(Of Date)
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Date
    Public Property CreatedBy_FK As Integer
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property DepthImage As String
    Public Property DepthMax As Nullable(Of Decimal)
    Public Property DepthEighty As Nullable(Of Decimal)
    Public Property DepthSixty As Nullable(Of Decimal)
    Public Property DepthForty As Nullable(Of Decimal)
    Public Property DepthTwenty As Nullable(Of Decimal)
    Public Property DepthNegative As Nullable(Of Decimal)
    Public Property DepthNans As Nullable(Of Decimal)
    Public Property UnderMining As String
    Public Property PatientID_FK As Nullable(Of Integer)
    Public Property Rotation As Nullable(Of Decimal)
    Public Property OriginalImageMeasurement As String
    Public Property WoundBedImageMeasurement As String
    Public Property DepthImageMeasurement As String
    Public Property AnnotatedImageMeasurement As String
    Public Property SizeLength_Auto As Nullable(Of Decimal)
    Public Property SizeDepth_Auto As Nullable(Of Decimal)
    Public Property SizeWidth_Auto As Nullable(Of Decimal)
    Public Property MeasurementUpdateRemark As String
    Public Property TCUpdateRemark As String
    Public Property isTCModified As Nullable(Of Boolean)
    Public Property isWMModified As Nullable(Of Boolean)
    Public Property isUploadImageModified As Nullable(Of Boolean)
    Public Property woundOverlaysImageDistance As Nullable(Of Decimal)
    Public Property woundOverlaysImage As String
    Public Property TO_Comments As String
    Public Property NextReviewDate As Nullable(Of Date)
    Public Property NextTreatmentDate As Nullable(Of Date)
    Public Property TreatmentRemarks As String
    Public Property LocationRemark As String

End Class
