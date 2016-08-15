using MoneyControl.Entities.Base;
using MoneyControl.Entities.Enums;

namespace MoneyControl.Entities.Accounts
{
    public class Recurrence : EntityBase
    {
        public RecurrenceType RecurrenceType { get;set;}
        public int? CustomRecurrentDays { get; set; }
    }
}