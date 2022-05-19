namespace ExpenseApp.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string CurrencyType { get; set; } = "Peso";
        public string? Depositer { get; set; } = "";

        public string? Receiver { get; set; } = "";

        public DateTime TransactionDate { get; set; } = DateTime.Today;

        public string TransactionType { get; set; } = String.Empty;

        public string TransactionDescription { get; set; } = String.Empty;

        public float Amount { get; set; }

    }
}
