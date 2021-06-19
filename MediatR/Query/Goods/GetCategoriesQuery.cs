using MediatR;
using System.Collections.Generic;
using WeedStore.Models.Goods;

namespace WeedStore.MediatR.Query
{
    public class GetCategoriesQuery : IRequest<List<CategoryModel>>
    {

    }
}
