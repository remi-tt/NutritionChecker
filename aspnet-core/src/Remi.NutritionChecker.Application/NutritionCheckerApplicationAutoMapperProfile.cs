using AutoMapper;
using Remi.NutritionChecker.Points;
using Remi.NutritionChecker.Contract.Points;

namespace Remi.NutritionChecker;

public class NutritionCheckerApplicationAutoMapperProfile : Profile
{
    public NutritionCheckerApplicationAutoMapperProfile()
    {
        CreateMap<DailyNutritionPoints, DailyNutritionPointsDto>();
        CreateMap<CreateUpdateDailyNutritionPointsDto, DailyNutritionPoints>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
