namespace DomPlan.Domain.Entites
{
    public class Vehicle
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public Guid UserId { get; set; }

        public string MakeModel { get; set; } = string.Empty; // "VW Golf 7"
        public string LicensePlate { get; set; } = string.Empty; // "ВТ1234АВ"
        public string? TalonNumber { get; set; } // Номер на малък талон (ако се изисква за данъка)

        // Извлечени дати от регистрите (BGTOLL, ГФ, ДАИ)
        public DateTime? VignetteValidUntil { get; set; }
        public DateTime? InspectionValidUntil { get; set; } // ГТП
        public DateTime? InsuranceValidUntil { get; set; }  // Гражданска отговорност

        public DateTime? LastSyncedAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}