using AutoMapper;
using Business.Abstracts;
using Business.DTOs.Requests;
using Business.DTOs.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            Product product=_mapper.Map<Product>(createProductRequest); 
            Product createdProduct=await _productDal.AddAsync(product);

            CreatedProductResponse createdProductResponse=_mapper.Map<CreatedProductResponse>(createdProduct);

            return createdProductResponse;
        }

        public async Task<Paginate<GetListProductResponse>> GetListAsync()
        {
            var data=await _productDal.GetListAsync(
                include: p=>p.Include(p=>p.Category)
                ); //neden result içerisinde tanımladık
            var result = _mapper.Map<Paginate<GetListProductResponse>>(data);
            return result;
        }
    }
}
