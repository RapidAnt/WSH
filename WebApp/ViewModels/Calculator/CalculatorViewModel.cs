using Data_Layer.DTO_Models;

namespace WebApp.ViewModels.Calculator
{
    public class CalculatorViewModel
    {
        public Rate Rate { get; set; }

        public CalculatorViewModel(Rate rate)
        {
            Rate = rate;
        }
    }
}