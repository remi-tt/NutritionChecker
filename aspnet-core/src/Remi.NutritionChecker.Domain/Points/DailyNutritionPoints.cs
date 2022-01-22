using System;
using Volo.Abp.Domain.Entities.Auditing;

namespace Remi.NutritionChecker.Points
{
    public class DailyNutritionPoints : AuditedAggregateRoot<Guid>
    {
        public Guid UserId { get; set; }

        public int DailyPoints { get; set; }

        public DateTime NutritionDate { get; set; }

        public int UsedPoints { get; set; }
    }
}