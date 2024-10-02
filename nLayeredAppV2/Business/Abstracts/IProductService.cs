using Business.DTOs.Requests;
using Business.DTOs.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IProductService
    {
        Task<Paginate<GetListProductResponse>> GetListAsync();  //değiştir
        Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest);
    }
}
