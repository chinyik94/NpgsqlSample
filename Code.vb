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

Partial Public Class Code
    Public Property CodeId As Integer
    Public Property CodeTypeId_FK As Integer
    Public Property CodeName As String
    Public Property Ordering As Nullable(Of Integer)
    Public Property IsSystemUsed As Boolean
    Public Property IsDeleted As Boolean
    Public Property CreatedDate As Nullable(Of Date)
    Public Property CreatedBy_FK As Nullable(Of Integer)
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy_FK As Nullable(Of Integer)
    Public Property Indication_Acute As Nullable(Of Boolean)
    Public Property Indication_PRN As Nullable(Of Boolean)
    Public Property Referral_Code As String
    Public Property AllergyReaction_Drug As Nullable(Of Boolean)
    Public Property AllergyReaction_Others As Nullable(Of Boolean)
    Public Property MedicationGroupID_FK As Nullable(Of Integer)
    Public Property Status As String
    Public Property CurrencyCodeA As String
    Public Property CurrencyCodeN As String
    Public Property CurrencyInvoiceFooter As String
    Public Property Critical As Nullable(Of Boolean)

    Public Overridable Property BillingInvoice As ICollection(Of BillingInvoice) = New HashSet(Of BillingInvoice)
    Public Overridable Property BillingProposal As ICollection(Of BillingProposal) = New HashSet(Of BillingProposal)
    Public Overridable Property BillingService As ICollection(Of BillingService) = New HashSet(Of BillingService)
    Public Overridable Property Branch As ICollection(Of Branch) = New HashSet(Of Branch)
    Public Overridable Property CarePlanSubProblemListGoal As ICollection(Of CarePlanSubProblemListGoal) = New HashSet(Of CarePlanSubProblemListGoal)
    Public Overridable Property CarePlanSubProblemListGoal1 As ICollection(Of CarePlanSubProblemListGoal) = New HashSet(Of CarePlanSubProblemListGoal)
    Public Overridable Property CareReport As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport1 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport2 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport3 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport4 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport5 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport6 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport7 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport8 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport9 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport10 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport11 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport12 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport13 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property CareReport14 As ICollection(Of CareReport) = New HashSet(Of CareReport)
    Public Overridable Property Code1 As ICollection(Of Code) = New HashSet(Of Code)
    Public Overridable Property Code2 As Code
    Public Overridable Property CodeType As CodeType
    Public Overridable Property Enquiry As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property Enquiry1 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property Enquiry2 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property Enquiry3 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property Enquiry4 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property Enquiry5 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property Enquiry6 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property [Event] As ICollection(Of [Event]) = New HashSet(Of [Event])
    Public Overridable Property Event1 As ICollection(Of [Event]) = New HashSet(Of [Event])
    Public Overridable Property Facility As ICollection(Of Facility) = New HashSet(Of Facility)
    Public Overridable Property Item As ICollection(Of Item) = New HashSet(Of Item)
    Public Overridable Property Item1 As ICollection(Of Item) = New HashSet(Of Item)
    Public Overridable Property MedicationVitalSignType As ICollection(Of MedicationVitalSignType) = New HashSet(Of MedicationVitalSignType)
    Public Overridable Property NutritionTask As ICollection(Of NutritionTask) = New HashSet(Of NutritionTask)
    Public Overridable Property NutritionTaskReference As ICollection(Of NutritionTaskReference) = New HashSet(Of NutritionTaskReference)
    Public Overridable Property Patient As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient1 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient2 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient3 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient4 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient5 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient6 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient7 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property Patient8 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property PatientDrugAllergy As ICollection(Of PatientDrugAllergy) = New HashSet(Of PatientDrugAllergy)
    Public Overridable Property PatientDrugAllergy1 As ICollection(Of PatientDrugAllergy) = New HashSet(Of PatientDrugAllergy)
    Public Overridable Property PatientMedicalHistory As ICollection(Of PatientMedicalHistory) = New HashSet(Of PatientMedicalHistory)
    Public Overridable Property PatientMedicationConsume As ICollection(Of PatientMedicationConsume) = New HashSet(Of PatientMedicationConsume)
    Public Overridable Property PatientMedicationConsume1 As ICollection(Of PatientMedicationConsume) = New HashSet(Of PatientMedicationConsume)
    Public Overridable Property PatientMedicationConsume2 As ICollection(Of PatientMedicationConsume) = New HashSet(Of PatientMedicationConsume)
    Public Overridable Property PatientMedicationConsume3 As ICollection(Of PatientMedicationConsume) = New HashSet(Of PatientMedicationConsume)
    Public Overridable Property PatientMedicationConsume4 As ICollection(Of PatientMedicationConsume) = New HashSet(Of PatientMedicationConsume)
    Public Overridable Property PatientMedicationConsume5 As ICollection(Of PatientMedicationConsume) = New HashSet(Of PatientMedicationConsume)
    Public Overridable Property PatientMedicationConsume6 As ICollection(Of PatientMedicationConsume) = New HashSet(Of PatientMedicationConsume)
    Public Overridable Property PatientOtherAllergy As ICollection(Of PatientOtherAllergy) = New HashSet(Of PatientOtherAllergy)
    Public Overridable Property PatientOtherAllergy1 As ICollection(Of PatientOtherAllergy) = New HashSet(Of PatientOtherAllergy)
    Public Overridable Property PatientProfile As ICollection(Of PatientProfile) = New HashSet(Of PatientProfile)
    Public Overridable Property PatientProfile1 As ICollection(Of PatientProfile) = New HashSet(Of PatientProfile)
    Public Overridable Property PatientProfile2 As ICollection(Of PatientProfile) = New HashSet(Of PatientProfile)
    Public Overridable Property PatientSocialSupport As ICollection(Of PatientSocialSupport) = New HashSet(Of PatientSocialSupport)
    Public Overridable Property PatientSocialSupport1 As ICollection(Of PatientSocialSupport) = New HashSet(Of PatientSocialSupport)
    Public Overridable Property PatientSocialSupport2 As ICollection(Of PatientSocialSupport) = New HashSet(Of PatientSocialSupport)
    Public Overridable Property PatientSocialSupport3 As ICollection(Of PatientSocialSupport) = New HashSet(Of PatientSocialSupport)
    Public Overridable Property PatientWound As ICollection(Of PatientWound) = New HashSet(Of PatientWound)
    Public Overridable Property PatientWoundDraft As ICollection(Of PatientWoundDraft) = New HashSet(Of PatientWoundDraft)
    Public Overridable Property ProblemListGoal As ICollection(Of ProblemListGoal) = New HashSet(Of ProblemListGoal)
    Public Overridable Property ProblemListGoal1 As ICollection(Of ProblemListGoal) = New HashSet(Of ProblemListGoal)
    Public Overridable Property Receipt As ICollection(Of Receipt) = New HashSet(Of Receipt)
    Public Overridable Property Receipt1 As ICollection(Of Receipt) = New HashSet(Of Receipt)
    Public Overridable Property Resource As ICollection(Of Resource) = New HashSet(Of Resource)
    Public Overridable Property ServiceForBilling As ICollection(Of ServiceForBilling) = New HashSet(Of ServiceForBilling)
    Public Overridable Property ServiceForBillingCost As ICollection(Of ServiceForBillingCost) = New HashSet(Of ServiceForBillingCost)
    Public Overridable Property Task As ICollection(Of Task) = New HashSet(Of Task)
    Public Overridable Property Task1 As ICollection(Of Task) = New HashSet(Of Task)
    Public Overridable Property Task2 As ICollection(Of Task) = New HashSet(Of Task)
    Public Overridable Property Task3 As ICollection(Of Task) = New HashSet(Of Task)
    Public Overridable Property TD_WoundAssessmentFactor As ICollection(Of TD_WoundAssessmentFactor) = New HashSet(Of TD_WoundAssessmentFactor)
    Public Overridable Property TeleconsultationRecording As ICollection(Of TeleconsultationRecording) = New HashSet(Of TeleconsultationRecording)
    Public Overridable Property TreatmentListItem As ICollection(Of TreatmentListItem) = New HashSet(Of TreatmentListItem)
    Public Overridable Property UserCategory As ICollection(Of UserCategory) = New HashSet(Of UserCategory)
    Public Overridable Property Enquiry7 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property Enquiry8 As ICollection(Of Enquiry) = New HashSet(Of Enquiry)
    Public Overridable Property InitialCareAssessment As ICollection(Of InitialCareAssessment) = New HashSet(Of InitialCareAssessment)
    Public Overridable Property Patient9 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property PatientMedication As ICollection(Of PatientMedication) = New HashSet(Of PatientMedication)
    Public Overridable Property PatientReferral As ICollection(Of PatientReferral) = New HashSet(Of PatientReferral)
    Public Overridable Property Patient10 As ICollection(Of Patient) = New HashSet(Of Patient)
    Public Overridable Property PatientWoundDraft1 As ICollection(Of PatientWoundDraft) = New HashSet(Of PatientWoundDraft)
    Public Overridable Property PatientWoundVisit As ICollection(Of PatientWoundVisit) = New HashSet(Of PatientWoundVisit)
    Public Overridable Property PatientWoundVisit1 As ICollection(Of PatientWoundVisit) = New HashSet(Of PatientWoundVisit)
    Public Overridable Property PatientWoundVisit2 As ICollection(Of PatientWoundVisit) = New HashSet(Of PatientWoundVisit)
    Public Overridable Property Code11 As ICollection(Of Code) = New HashSet(Of Code)
    Public Overridable Property Code3 As ICollection(Of Code) = New HashSet(Of Code)
    Public Overridable Property Task4 As ICollection(Of Task) = New HashSet(Of Task)
    Public Overridable Property Users As ICollection(Of Users) = New HashSet(Of Users)
    Public Overridable Property Users1 As ICollection(Of Users) = New HashSet(Of Users)
    Public Overridable Property Users2 As ICollection(Of Users) = New HashSet(Of Users)

End Class
