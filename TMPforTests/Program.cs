using OrderDocument.DAL;
using OrderDocument.DAL.DTOs;
using System;


namespace TMPforTests
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderDocumentData orderDocData = new OrderDocumentData(@"Server=localhost;Database=TestTask;Trusted_Connection=True;");
            orderDocData.AddProductToOrderDocument(1, 5, 11, 333);
            orderDocData.GetProductsOfOrderDocument(1);
            orderDocData.UpdateProductInfoInOrderDocument(1, 5, 13, 444);
            orderDocData.GetProductsOfOrderDocument(1);
        }
    }
}
