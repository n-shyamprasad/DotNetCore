using System;
using System.Linq;
using System.Collections.Generic;
using model;

namespace aggregate
{
    class AverageSample3
    {
        //Query syntax to get the average price of each category's products.
        public static void QuerySyntaxExample()
        {
            List<Product> products = Data.Products;
            var Categories = 
                from _product in products
                group _product by _product.Category into _productGrp
                select new {CategoryName = _productGrp.Key, 
                            AveragePrice = _productGrp.Average(p => p.UnitPrice)};
            foreach (var _prodCate in Categories)
            {
                Console.WriteLine($"Avg price for the product in the {_prodCate.CategoryName} category is {_prodCate.AveragePrice} ");
            }
        }

        //Method syntax to get the average price of each category's products
        public static void MethodSyntaxExample()
        {
            List<Product> _products = Data.Products;
            var Categories = 
            _products.GroupBy(_product => _product.Category)
                     .Select(_prdGrp => new {CategoryName = _prdGrp.Key, AveragePrice = _prdGrp.Average(p => p.UnitPrice)});
            foreach (var _category in Categories)
            {
                Console.WriteLine($"Avg. price for the product in the {_category.CategoryName} cateogry is {_category.AveragePrice}");
            }
        }
    }
}