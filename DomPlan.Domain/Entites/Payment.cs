using DomPlan.Domain.Enums;

namespace DomPlan.Domain.Entites
{
    public class Payment
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public decimal TotalAmount { get; set; }
        public string? GatewayTransactionId { get; set; } // ИД на трансакцията от ePay / Stripe / Борика
        public PaymentStatus Status { get; set; } = PaymentStatus.Pending;
        public string PaymentMethod { get; set; } = "Card"; // "Card", "ePay", "ApplePay"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Сметките, платени с тази трансакция
        public virtual ICollection<Bill> PaidBills { get; set; } = new List<Bill>();
    }
}