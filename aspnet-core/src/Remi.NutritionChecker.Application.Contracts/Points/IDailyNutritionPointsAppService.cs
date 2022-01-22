using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Remi.NutritionChecker.Contract.Points
{
    public interface IDailyNutritionPointsAppService :
        ICrudAppService< //Defines CRUD methods
            DailyNutritionPointsDto, //Used to show books
            Guid, //Primary key of the daily nutrition points
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateDailyNutritionPointsDto> //Used to create/update a book
    {

    }
}