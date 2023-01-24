﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELIXIRETD.DATA.DATA_ACCESS_LAYER.DTOs.SETUP_DTO
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string SupplierCode { get; set; }
        public string SupplierName { get; set; }
        public string SupplierAddress { get; set; }
        public bool IsActive { get; set; }
        public string DateAdded { get; set; }
        public string AddedBy { get; set; }
     
    }

}
