using DomPlan.Domain.Enums;

namespace DomPlan.Domain.Entites
{
    public class Bill
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UtilityAccountId { get; set; }
        public virtual UtilityAccount UtilityAccount { get; set; } = null!;

        public decimal Amount { get; set; }
        public DateTime DueDate { get; set; } // Краен срок за плащане
        public string? InvoiceNumber { get; set; } // Номер на фактура от дружеството

        public BillStatus Status { get; set; } = BillStatus.Unpaid;

        public DateTime DiscoveredAt { get; set; } = DateTime.UtcNow; // Кога ботът я е засякъл
        public DateTime? PaidAt { get; set; } // Кога е платена

        // Връзка към трансакцията при плащане
        public Guid? PaymentId { get; set; }
        public virtual Payment? Payment { get; set; }
    }
}