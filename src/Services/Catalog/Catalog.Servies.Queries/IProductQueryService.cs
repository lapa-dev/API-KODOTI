using Catalog.Servies.Queries.DTOs;
using Services.Common.Collection;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Servies.Queries
{
    public interface IProductQueryService
    {
       Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
       Task<ProductDto> GetAsync(int id);
    }
}
