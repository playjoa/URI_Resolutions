using System;
using Inputs;
using ProductSystem;
using Barcodes;

namespace URI_1038_Snack
{
    class Program
    {
        static void Main(string[] args)
        {
            Product productHolder;
            ProductShelf productShelf = new ProductShelf();
            Order productsOrder = new Order();

            productHolder = new Product(1, "Cachorro Quente", 4);
            productShelf.AddProductToShelf(productHolder);

            productHolder = new Product(2, "X-Salada", 4.5);
            productShelf.AddProductToShelf(productHolder);

            productHolder = new Product(3, "X-Bacon", 5);
            productShelf.AddProductToShelf(productHolder);

            productHolder = new Product(4, "Torrada Simples", 2);
            productShelf.AddProductToShelf(productHolder);

            productHolder = new Product(5, "Refrigerante", 1.5);
            productShelf.AddProductToShelf(productHolder);

            string barCodeRead = InputSystem.ReadLine;

            BarCodeReader codeReader = new BarCodeReader(barCodeRead);

            Product productToAdd = productShelf.ProductInShelfWithID(codeReader.ReadNumberInBarCode(0));
            int productQty = codeReader.ReadNumberInBarCode(1);

            productsOrder.AddProductToOrder(productToAdd, productQty);

            productsOrder.ListTotalOrder();
            Console.ReadLine();
        }
    }
}