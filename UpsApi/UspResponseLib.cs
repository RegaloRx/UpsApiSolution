using System.Collections.Generic;

namespace UpsQVResponseLib
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse); 

    public class ErrorLocation
    {
        public string ErrorLocationElementName { get; set; }
        public string ErrorLocationAttributeName { get; set; }
        public string ErrorDigest { get; set; }
    }
    public class Error
    {
        public string ErrorSeverity { get; set; }
        public string ErrorCode { get; set; }
        public string ErrorDescription { get; set; }
        public string MinimumRetrySeconds { get; set; }
        public ErrorLocation ErrorLocation { get; set; }
    }
    public class Response
    {
        public string TransactionReference { get; set; }
        public string ResponseStatusCode { get; set; }
        public string ResponseStatusDescription { get; set; }
        public Error Error { get; set; }
    }

    public class SubscriptionStatus
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class StatusType
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class AddressExtendedInformation
    {
        public string Type { get; set; }
        public string Low { get; set; }
        public string High { get; set; }
    }

    public class ResidentialAddressIndicator
    {
        public string Value = "True";
    }

    public class AddressArtifactFormat
    {
        public string ConsigneeName { get; set; }
        public string StreetNumberLow { get; set; }
        public string StreetPrefix { get; set; } 
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetSuffix { get; set; }
        public string BuildingName { get; set; }
        public List<AddressExtendedInformation> AddressExtendedInformation { get; set; }
        public string PoliticalDivision3 { get; set; }
        public string PoliticalDivision2 { get; set; }
        public string PoliticalDivision1 { get; set; }
        public string CountryCode { get; set; }
        public string PostcodePrimaryLow { get; set; }
        public string PostcodeExtendedLow { get; set; }
        public ResidentialAddressIndicator ResidentialAddressIndicator { get; set; }
    }

    public class ActivityLocation
    {
        public AddressArtifactFormat AddressArtifactFormat { get; set; }
    }

    public class PackageReferenceNumber
    {
        public string Number { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }

    public class ShipmentReferenceNumber
    {
        public string Number { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }

    public class BillToAccount
    {
        public string Option { get; set; }
        public string Number { get; set; }
    }

    public class Origin
    {
        public string ShipperNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public ActivityLocation ActivityLocation { get; set; }
        public List<PackageReferenceNumber> PackageReferenceNumber { get; set; }
        public List<ShipmentReferenceNumber> ShipmentReferenceNumber { get; set; }
        public BillToAccount BillToAccount { get; set; }
        public string ScheduledDeliveryDate { get; set; }
        public string ScheduledDeliveryTime { get; set; }
    }

    public class CODAmount
    {
        public string CurrencyCode { get; set; }
        public string MonetaryValue { get; set; }
    }

    public class COD
    {
        public CODAmount CODAmount { get; set; }
    }

    public class DeliveryLocation
    {
        public AddressArtifactFormat AddressArtifactFormat { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string SignedForByName { get; set; }
    }

    public class Delivery
    {
        public List<PackageReferenceNumber> PackageReferenceNumber { get; set; }
        public List<ShipmentReferenceNumber> ShipmentReferenceNumber { get; set; }
        public string ShipperNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public ActivityLocation ActivityLocation { get; set; }
        public DeliveryLocation DeliveryLocation { get; set; }
        public string DriverRelease { get; set; }
        public COD COD { get; set; }
        public BillToAccount BillToAccount { get; set; }
        public string LastPickuDate { get; set; }
        public string AccessPointLocationID { get; set; }

    }

    public class Address
    {
        public string ConsigneeName { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string StateProvinceCode { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
    }

    public class Shipper
    {
        public string Name { get; set; }
        public string AttentionName { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public string ShipperNumber { get; set; }
        public string EMailAddress { get; set; }
        public Address Address { get; set; }
    }

    public class ShipTo
    {
        public string LocationID { get; set; }
        public string ReceivingAddressName { get; set; }
        public string ShipperAssignedIdentificationNumber { get; set; }
        public string CompanyName { get; set; }
        public string AttentionName { get; set; }
        public string PhoneNumber { get; set; }
        public string TaxIdentificationNumber { get; set; }
        public string FaxNumber { get; set; }
        public Address Address { get; set; }
        public string Bookmark { get; set; }
    }

    public class ReferenceNumber
    {
        public string Number { get; set; }
        public string Code { get; set; }
        public string Value { get; set; }
    }

    public class Service
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class PackageServiceOptions
    {
        public string COD { get; set; }
        public string EarliestDeliveryTime { get; set; }
        public string HazardousMaterialsCode { get; set; }
        public string HoldForPickup { get; set; }
    }

    public class Activity
    {
        public string Date { get; set; }
        public string Time { get; set; }
    }

    public class Dimensions
    {
        public string Length { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
    }

    public class UnitOfMeasurement
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class DimensionalWeight
    {
        public UnitOfMeasurement UnitOfMeasurement { get; set; }
        public string Weight { get; set; }
    }

    public class PackageWeight
    {
        public string Weight { get; set; }
    }

    public class Package
    {
        public Activity Activity { get; set; }
        public string Description { get; set; }
        public Dimensions Dimensions { get; set; }
        public DimensionalWeight DimensionalWeight { get; set; }
        public PackageWeight PackageWeight { get; set; }
        public string LargePackage { get; set; }
        public string TrackingNumber { get; set; }
        public ReferenceNumber ReferenceNumber { get; set; }
        public PackageServiceOptions PackageServiceOptions { get; set; }
        public string UPSPremiumCareIndicator { get; set; }
    }

    public class SaturdayPickup
    {
        public string Value = "True";
    }

    public class SaturdayDelivery
    {
        public string Value = "True";
    }

    public class CallTagARS
    {
        public string Number { get; set; }
        public string Code { get; set; }
    }

    public class ShipmentServiceOptions
    {
        public SaturdayPickup SaturdayPickup { get; set; }
        public SaturdayDelivery SaturdayDelivery { get; set; }
        public CallTagARS CallTagARS { get; set; }
    }

    public class CustomsValue
    {
        public string MonetaryValue { get; set; }
    }

    public class ConsigneeBillIndicator
    {
        public string Value = "True";
    }

    public class CollectBillIndicator
    {
        public string Value = "True";
    }

    public class UAPAddress
    {
        public string CompanyName { get; set; }
        public string AttentionName { get; set; }
        public Address Address { get; set; }
        public string PhoneNumber { get; set; }
    }

    public class Manifest
    {
        public Shipper Shipper { get; set; }
        public ShipTo ShipTo { get; set; }
        public ReferenceNumber ReferenceNumber { get; set; }
        public Service Service { get; set; }
        public string PickupDate { get; set; }
        public string ScheduledDeliveryDate { get; set; }
        public string ScheduledDeliveryTime { get; set; }
        public string DocumentsOnly { get; set; }
        public Package Package { get; set; }
        public ShipmentServiceOptions ShipmentServiceOptions { get; set; }
        public string ManufactureCountry { get; set; }
        public string HarmonizedCode { get; set; }
        public CustomsValue CustomsValue { get; set; }
        public string SpecialInstructions { get; set; }
        public string ShipmentChargeType { get; set; }
        public BillToAccount BillToAccount { get; set; }
        public ConsigneeBillIndicator ConsigneeBillIndicator { get; set; }
        public CollectBillIndicator CollectBillIndicator { get; set; }
        public string LocationAssured { get; set; }
        public string ImportControl { get; set; }
        public string LabelDeliveryMethod { get; set; }
        public string CommercialInvoiceRemoval { get; set; }
        public string PostalServiceTrackingID { get; set; }
        public string ReturnsFlexibleAccess { get; set; }
        public string UPScarbonneutral { get; set; }
        public string Product { get; set; }
        public string UPSReturnsExchange { get; set; }
        public string LiftGateOnDelivery { get; set; }
        public string LiftGateOnPickUp { get; set; }
        public string PickupPreference { get; set; }
        public string DeliveryPreference { get; set; }
        public string HoldForPickupAtUPSAccessPoint { get; set; }
        public UAPAddress UAPAddress { get; set; }
        public string DeliverToAdresseeOnlyIndicator { get; set; }
        public string UPSAccessPointCODIndicator { get; set; }
        public string ClinicalTrialIndicator { get; set; }
        public string ClinicalTrialIndicationNumber { get; set; }
        public string CategoryAHazardousIndicator { get; set; }
        public string DirectDeliveryIndicator { get; set; }
        public string PackageReleaseCodeIndicator { get; set; }
        public string ProactiveResponseIndicator { get; set; }
        public string PackageCount { get; set; }
        public string WhiteGloveDeliveryInicator { get; set; }
        public string RoomOfChoiceIndicator { get; set; }
        public string InstallationDeliveryIndicator { get; set; }
        public string ItemDispositionalIndicator { get; set; }
        public string LeadShipmentTrackingNumber { get; set; }
        public string SaturdayNonPremiumCommercialDeliveryIndicator { get; set; }
        public string UPSPremierAccessorialIndicator { get; set; }
        public string UPSPrecierCategoryCode { get; set; }
    }

    public class UpdatedAddress
    {
        public string ConsigneeName { get; set; }
        public string StreetNumberLow { get; set; }
        public string StreetPrefix { get; set; }
        public string StreetName { get; set; }
        public string StreetType { get; set; }
        public string StreetSuffix { get; set; }
        public List<AddressExtendedInformation> AddressExtendedInformation { get; set; }
        public string PoliticalDivision3 { get; set; }
        public string PoliticalDivision2 { get; set; }
        public string PoliticalDivision1 { get; set; }
        public string CountryCode { get; set; }
        public string PostcodePrimaryLow { get; set; }
    }

    public class Resolution
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }

    public class Exception
    {
        public List<PackageReferenceNumber> PackageReferenceNumber { get; set; }
        public string ShipperNumber { get; set; }
        public string TrackingNumber { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public UpdatedAddress UpdatedAddress { get; set; }
        public string StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public string ReasonCode { get; set; }
        public string ReasonDescription { get; set; }
        public Resolution Resolution { get; set; }
        public string RescheduledDeliveryDate { get; set; }
        public ActivityLocation ActivityLocation { get; set; }
        public BillToAccount BillToAccount { get; set; }
        public string AccessPointLocationID { get; set; }
        public string SimplifiedText { get; set; }
    }

    public class FailureNotificationCode
    {
        public string Code { get; set; }
    }

    public class FailureNotification
    {
        public string FailedEmailAddress { get; set; }
        public FailureNotificationCode FailureNotificationCode { get; set; }
    }
    public class Generic
    {
        public string ActivityType { get; set; }
        public string TrackingNumber { get; set; }
        public string ShipperNumber { get; set; }
        public ShipmentReferenceNumber ShipmentReferenceNumber { get; set; }
        public PackageReferenceNumber PackageReferenceNumber { get; set; }
        public Service Service { get; set; }
        public Activity Activity { get; set; }
        public BillToAccount BillToAccount { get; set; }
        public ShipTo ShipTo { get; set; }
        public string RescheduledDeliveryDate { get; set; }
        public FailureNotification FailureNotification { get; set; }
    }
    public class SubscriptionFile
    {
        public string FileName { get; set; }
        public StatusType StatusType { get; set; }
        public List<Manifest> Manifest { get; set; }
        public Origin Origin { get; set; }
        public Exception Exception { get; set; }
        public List<Delivery> Delivery { get; set; }
        public Generic Generic { get; set; }
    }

    public class DateRange
    {
        public string BeginDate { get; set; }
        public string EndDate { get; set; }
    }

    public class SubscriptionEvent
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public SubscriptionStatus SubscriptionStatus { get; set; }
        public DateRange DateRange { get; set; }
        public List<SubscriptionFile> SubscriptionFile { get; set; }
    }

    public class QuantumViewEvents
    {
        public string SubscriberID { get; set; }
        public List<SubscriptionEvent> SubscriptionEvents { get; set; }
    }

    public class QuantumViewResponse
    {
        public Response Response { get; set; }
        public QuantumViewEvents QuantumViewEvents { get; set; }
    }

    public class QvRoot
    {
        public QuantumViewResponse QuantumViewResponse { get; set; }
        public string Bookmark { get; set; } 
    }


}