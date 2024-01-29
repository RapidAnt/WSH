using System;
using System.ComponentModel.DataAnnotations;

namespace Data_Layer.Models
{
    public class UserRate
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Unit { get; set; }
        public string Currency { get; set; }
        public string CurrentRate { get; set; }
        [MaxLength(100)]
        public string Comment { get; set; }

        public UserRate() { }

        public UserRate(int userId, DateTime date, string unit, string currency, string currentRate, string comment)
        {
            UserId = userId;
            Date = date;
            Unit = unit;
            Currency = currency;
            CurrentRate = currentRate;
            Comment = comment;
        }
    }
}
