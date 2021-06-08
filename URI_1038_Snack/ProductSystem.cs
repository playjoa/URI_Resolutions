using System;
using System.Collections.Generic;

namespace ProductSystem
{
    public class Product
    {
        private int _productCode;
        private string _productName;
        private double _productPrice;

        public Product(int productCode, string productName, double productPrice)
        {
            _productCode = productCode;
            _productName = productName;
            _productPrice = productPrice;
        }

        public int ProductCode => _productCode;
        public string ProductName => _productName;
        public double ProductPrice => _productPrice;
    }

    public class Order
    {
        private Dictionary<Product, int> _productsInOrderDictionary;

        public Order()
        {
            _productsInOrderDictionary = new Dictionary<Product, int>();
        }

        public void AddProductToOrder(Product productWanted, int QtyProduct)
        {
            if (!_productsInOrderDictionary.ContainsKey(productWanted))
            {
                _productsInOrderDictionary.Add(productWanted, QtyProduct);
                return;
            }

            int previousQty = _productsInOrderDictionary[productWanted];
            _productsInOrderDictionary[productWanted] = previousQty + QtyProduct;
        }

        void ListTotalPrice(double valueToList)
        {
            Console.WriteLine("Total: R$ " + valueToList.ToString("0.00"));
        }

        public double OrderValue()
        {
            double totalValue = 0;
            foreach (KeyValuePair<Product, int> currentProductInOrder in _productsInOrderDictionary)
            {
                double currentProductPrice = currentProductInOrder.Key.ProductPrice;
                int currentProductQtyInOrder = currentProductInOrder.Value;

                double valueToAddToOrder = currentProductPrice * currentProductQtyInOrder;

                totalValue += valueToAddToOrder;
            }
            return totalValue;
        }

        public void ListTotalOrder()
        {
            ListTotalPrice(OrderValue());
        }
    }

    public class ProductShelf
    {
        private List<Product> _allProducts;
        private Product emptyProduct = new Product(-1, "empty", 0);

        public ProductShelf()
        {
            _allProducts = new List<Product>();
        }

        public void AddProductToShelf(Product newProductToAdd)
        {
            if (IsThisProductAddedToShelf(newProductToAdd))
                return;

            _allProducts.Add(newProductToAdd);
        }

        public void RemoveProductFromShelf(Product productToRemove)
        {
            if (!IsThisProductAddedToShelf(productToRemove))
                return;

            _allProducts.Remove(productToRemove);
        }

        public Product ProductInShelfWithID(int codeToCheck)
        {
            foreach (Product currentProduct in _allProducts)
            {
                if (currentProduct.ProductCode == codeToCheck)
                    return currentProduct;
            }
            return emptyProduct;
        }

        private bool IsThisProductAddedToShelf(Product productToCheck) => _allProducts.Contains(productToCheck);
    }
}