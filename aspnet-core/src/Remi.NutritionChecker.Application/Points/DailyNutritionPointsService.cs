using System;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Remi.NutritionChecker.Contract;

namespace Remi.NutritionChecker.Contract.Points
{
    public class DailyNutritionPointsService :
        CrudAppService<
            DailyNutritionPoints, //The Book entity
            DailyNutritionPointsDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CreateUpdateDailyNutritionPointsDto>, //Used to create/update a book
        IDailyNutritionPointsAppService //implement the IBookAppService
    {
        public DailyNutritionPointsService(IRepository<DailyNutritionPoints, Guid> repository)
            : base(repository)
        {

        }
    }
}
