using System;
using System.IO;
using System.Text.Json;
using InventoryManagement;
using warehouseManagement;

namespace warehouse{
    public class Program{
        public static void Main(string[] args){
            string path= @"./inventory.json";
            FetchInventory fetchInventory=new FetchInventory();

            inventoryDetails data=fetchInventory.Read(path);
            Console.WriteLine("PCode\t\tPName\t\t\tCategory\tMRP");
            Console.WriteLine(data.productDetail.PCode+"\t"+data.productDetail.PName+"\t"+data.productDetail.Category+"\t"+data.productDetail.Mrp);
            // Console.WriteLine();
            // Console.WriteLine();
            // Console.WriteLine();
        }
    }
}
