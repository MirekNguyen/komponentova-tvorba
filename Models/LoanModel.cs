namespace komponentova_tvorba.Models
{
    public class Loan
    {
        public int Id { get; set; }
        public required Book Book { get; set; }
        public DateOnly LoanDate { get; set; }
        public DateOnly? ReturnDate { get; set; }
        public DateOnly DueDate { get; set; }
        public int Amount { get; set; }
        public required Reader Reader { get; set; }

        public int DaysLeft
        {
            get
            {
                var dueDateTime = DueDate.ToDateTime(new TimeOnly(0, 0));
                return (dueDateTime - DateTime.Today).Days;
            }
        }

        public bool IsReturned => ReturnDate.HasValue;

        public bool IsLateReturn
        {
            get
            {
                return IsReturned && ReturnDate.HasValue && ReturnDate.Value > DueDate;
            }
        }

        public bool IsOverdue
        {
            get
            {
                return !IsReturned && DateTime.Today > DueDate.ToDateTime(TimeOnly.MinValue);
            }
        }
    }
}

