using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace InventoryManagement
{
    public class inventoryDetails
    {
        public List <ProductDetail> productDetail;
    }
    public class ProductDetail{
        public int PCode;
        public string PName;
        public string Category;
        public double Mrp;       
    }
}