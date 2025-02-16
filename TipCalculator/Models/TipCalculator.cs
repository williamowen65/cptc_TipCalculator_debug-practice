using System.ComponentModel.DataAnnotations;

namespace TipCalculator.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Please enter a value for cost of meal.")]
        [Range(0.0, 10000000.0, ErrorMessage = "Cost of meal must be greater than zero.")]
        public double? MealCost { get; set; }

        public decimal CalculateTip(decimal percent)
        {
            if (MealCost.HasValue)
            {
                var tip = (decimal)MealCost.Value * percent ;
                return tip;
            }
            else
            {
                return 0;
            }
        }
    }
}