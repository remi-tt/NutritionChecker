using System;
using System.ComponentModel.DataAnnotations;

namespace Remi.NutritionChecker.Contract.Points
{
    public class CreateUpdateDailyNutritionPointsDto
    {

        [Required]
         public int DailyPoints { get; set; }

        [Required]
        public DateTime NutritionDate { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public int UsedPoints { get; set; }
       
    }
}