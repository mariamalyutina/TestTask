using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.DAL.DTOs
{
    public class SupplyContractDTO
    {
        public int ProviderId { get; set; }
        public string Name { get; set; }
        public string ContractNumber { get; set; }
    }
}
