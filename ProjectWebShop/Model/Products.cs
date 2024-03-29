﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class Products
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int prid { get; set; }
        public string prname { get; set; }
        public int total { get; set; }
        public long importprice { get; set; }
        public long price { get; set; }
        public long oldprice { get; set; }
        public int lineprid { get; set; }
        public int totalview { get; set; }
        public int totallike { get; set; }
        public string image { get; set; }
        public string note { get; set; }
        public int highlight { get; set; }
        public DateTime mnday { get; set; }
        public DateTime createday { get; set; }
        public DateTime expirydate { get; set; }
        public int status { get; set; }
    }
}
