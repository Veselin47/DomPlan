{
    public class Property
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        // Връзка към потребителя (ИД-то от Identity)
        public Guid UserId { get; set; }

        public string Name { get; set; } = string.Empty; // "Апартамент ВТУ"
        public string? Address { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        // Релации
        public virtual ICollection<UtilityAccount> UtilityAccounts { get; set; } = new List<UtilityAccount>();
    }
}