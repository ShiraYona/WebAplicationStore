﻿using Entytess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> getAllProducts(string? desc, int? minPrice, int? maxPrice,
          int?[] categoryIds);
   
        //Task<Product> CreatNewProduct(Product product);
    }
}
