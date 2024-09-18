﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DtoLayer.DTO
{
    public class CreateCargoDetailDto
    {
        public string SenderCustomerId { get; set; }
        public string ReceiverCustomer { get; set; }
        public int Barcode { get; set; }
        public int CargoCompanyId { get; set; }
    }
    public class UpdateCargoDetailDto
    {
        public int CargoDetailId { get; set; }
        public string SenderCustomerId { get; set; }
        public string ReceiverCustomer { get; set; }
        public int Barcode { get; set; }
        public int CargoCompanyId { get; set; }     
    }
}
