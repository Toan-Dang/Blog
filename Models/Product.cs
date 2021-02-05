﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace XuanThuLab.Models {

    [Table("Product")]
    public class Product {

        [Key]
        public int ProductId { set; get; }

        public string Name { set; get; }
        public string Description { set; get; }
        public decimal Price { set; get; }
    }
}