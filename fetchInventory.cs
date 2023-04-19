using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using warehouseManagement;
using InventoryManagement;
 

namespace warehouseManagement{
    public class FetchInventory{
        public inventoryDetails Read(string path){
            using (StreamReader file = new StreamReader(path))
            {    
                try
                {
                    string json=file.ReadToEnd();
                    return JsonConvert.DeserializeObject<inventoryDetails>(json);
                }
                catch (Exception ex)
                {
                    return null;
                }
            } 
        }
    }
}