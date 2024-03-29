﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model
{
    public class ProductRespont
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int prid { get; set; }
        public string prname { get; set; }
        public string image { get; set; }
        public int total { get; set; }
        public long importprice { get; set; }
        public long price { get; set; }
        public long oldprice { get; set; }
        public int lineprid { get; set; }
        public int totalview { get; set; }
        public int totallike { get; set; }
        public string mnday { get; set; }
        public string note { get; set; }
        public string expirydate { get; set; }
        public string createday { get; set; }
        public int highlight { get; set; }
        public IFormFile imagerq { get; set; }
        public List<IFormFile> files { get; set; }
    }
}
