using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DtoLayer.DTO
{
    public class CreateCargoOperationsDto
    {
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string OperationDate { get; set; }
    }
    public class UpdateCargoOperationsDto
    {
        public int CargoOperationId { get; set; }
        public string Barcode { get; set; }
        public string Description { get; set; }
        public string OperationDate { get; set; }
    }
}
