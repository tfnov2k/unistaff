using System;
using System.ComponentModel.DataAnnotations;

namespace PerformanceEvaluation
{
    public class DateBeforeTodayAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if (value == null)
                return false;

            if (value is DateTime date)
                return date < DateTime.Today;

            return false;
        }
    }
}
