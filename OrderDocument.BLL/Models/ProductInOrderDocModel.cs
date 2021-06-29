using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.BLL.Models
{
    public class ProductInOrderDocModel
    {
        public string Name { get; set; }
        public string StockNumber { get; set; }
        public int MeasureUnitID { get; set; }
        public string MeasureUnitName { get; set; }
        public float Amount { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
        public int VatRate { get; set; }
        public float CostWithoutVat { get; set; }
        public float VatAmount { get; set; }
    }
}
