﻿using GeekShopping.ProductApi.Data.ValueObjects;

namespace GeekShopping.ProductApi.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAll();

        Task<ProductVO> FindById(Guid id);

        Task<ProductVO> Create(ProductVO vo);

        Task<ProductVO> Update(ProductVO vo);

        Task<bool> Delete(Guid id);
    }
}
