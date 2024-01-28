namespace Data_Layer.Models
{
    public class UserRate
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Date { get; set; }
        public string Unit { get; set; }
        public string Currency { get; set; }
        public string CurrentRate { get; set; }

        public UserRate(int userId, string date, string unit, string currency, string currentRate)
        {
            UserId = userId;
            Date = date;
            Unit = unit;
            Currency = currency;
            CurrentRate = currentRate;
        }
    }
}
