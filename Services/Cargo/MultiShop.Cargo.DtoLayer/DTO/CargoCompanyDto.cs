﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiShop.Cargo.DtoLayer.DTO
{
    public class CreateCargoCompanyDto
    {
        public string CargoCompanyName { get; set; }

    }
    public class UpdateCargoCompanyDto
    {
        public int CargoCompanyId { get; set; }
        public string CargoCompanyName { get; set; }

    }

}
