using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQContinue_9
{
    public class ProductComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product? product, Product? anotherProduct)
        {
            return product?.Id == anotherProduct?.Id;
        }

        public override int GetHashCode([DisallowNull] Product product)
        {
            return product.Id.GetHashCode();
        }
    }
}
