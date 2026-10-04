namespace DomPlan.Domain.Enums
{
    public enum BillStatus
    {
        Unpaid = 1,      // Очаква плащане
        Processing = 2,  // В процес на обработка през платежния шлюз
        Paid = 3,        // Успешно платена
        Overdue = 4      // Изтекъл срок (Просрочена)
    }
}