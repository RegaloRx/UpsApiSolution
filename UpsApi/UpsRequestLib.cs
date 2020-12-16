

namespace UpsRequestLib
{
    // Request Class Structures
    public class AccessRequestClass
    {
        public string AccessLicenseNumber { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
    }

    public class TransactionReferenceClass
    {
        public string CustomerContext { get; set; }
    }

    public class RequestClass
    {
        public TransactionReferenceClass TransactionReference { get; set; }
        public string RequestAction { get; set; }
    }

    public class SubscriptionRequestDateTimeRangeClass
    {
        public string BeginDateTime { get; set; }
        public string EndDateTime { get; set; }
    }
    public class SubscriptionRequestClass
    {
        public string Name { get; set; }
        public SubscriptionRequestDateTimeRangeClass DateTimeRange { get; set; }
        public string FileName { get; set; }
    }

    public class QuantumViewRequestClass
    {
        public RequestClass Request { get; set; }
        public SubscriptionRequestClass SubscriptionRequest { get; set; }
    }

    public class QVRequest
    {
        public AccessRequestClass AccessRequest { get; set; }
        public QuantumViewRequestClass QuantumViewRequest { get; set; }
    }
}