using DomPlan.Domain.Enums;

namespace DomPlan.Domain.Entites
{
    public class UtilityAccount
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public Guid? PropertyId { get; set; }
        public virtual Property? Property { get; set; }

        public ProviderType ProviderType { get; set; }
        public string ProviderName { get; set; } = string.Empty; // "Електрохолд", "ВиК Йовковци"

        // Номерът, по който ботът прави автоматична проверка
        public string SubscriberNumber { get; set; } = string.Empty; // Абонатен / Клиентски №
        public string? SecondaryIdentifier { get; set; } // ИТН, ЕИК или номер на договора (при нужда)
        public string? CustomName { get; set; } // "Токът в гаража"

        public bool IsActiveMonitoring { get; set; } = true;
        public DateTime? LastCheckedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Релация към месечните сметки
        public virtual ICollection<Bill> Bills { get; set; } = new List<Bill>();
    }
}