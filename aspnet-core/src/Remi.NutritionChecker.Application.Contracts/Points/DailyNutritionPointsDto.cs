using System;
using Volo.Abp.Application.Dtos;

namespace Remi.NutritionChecker.Contract.Points
{
    public class DailyNutritionPointsDto : AuditedEntityDto<Guid>
    {
        public int DailyPoints { get; set; }

        public DateTime NutritionDate { get; set; }

        public int UsedPoints { get; set; }
    }
}