namespace DomPlan.Domain.Entites
{
    public class NotificationLog
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public string Title { get; set; } = string.Empty; // "Наближаващ падеж"
        public string Message { get; set; } = string.Empty; // "Сметката за ток (45.20 лв.) изтича след 3 дни."
        public string Type { get; set; } = "Email"; // "Email", "SMS", "Push"

        public bool IsRead { get; set; } = false;
        public DateTime SentAt { get; set; } = DateTime.UtcNow;
    }
}