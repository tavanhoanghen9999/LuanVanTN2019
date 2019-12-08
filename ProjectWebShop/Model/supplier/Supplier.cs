using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectWebShop.Model.supplier
{
    public class Supplier
    {
        public int suplid { get; set; }
        public string suplname { get; set; }
        public string supladdress {get;set;}
        public int suplphone { get; set; }
        public Boolean status { get; set; }
    }
}
