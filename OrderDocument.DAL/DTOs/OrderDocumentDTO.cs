using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderDocument.DAL.DTOs
{
    public class OrderDocumentDTO
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int StorageID { get; set; }
        public string StorageName { get; set; }
        public int SupplyContractID { get; set; }
        public string ProviderName { get; set; }
        public string ContractNumber { get; set; }
    }
}
