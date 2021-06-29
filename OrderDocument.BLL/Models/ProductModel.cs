using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.BLL.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string StockNumber { get; set; }
        public int MeasureUnitID { get; set; }
        public string MeasureUnit { get; set; }
        public int VatRate { get; set; }
    }
}
