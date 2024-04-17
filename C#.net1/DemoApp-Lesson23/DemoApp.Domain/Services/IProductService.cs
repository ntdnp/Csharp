﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoApp.Domain.Models.Products;
using DemoApp.Domain.Models;

namespace DemoApp.Domain.Services
{
    public interface IProductService
    {
        GenericData<ProductViewModel> GetProducts(ProductPage model);
        Task<ProductDetailViewModel> GetProductDetail(Guid productId);
        
    }
}
