using System;
using System.IO;
using System.Text.Json;
using ConsoleTables;
using InventoryManagement;
using warehouseManagement;

namespace warehouse{
    public class Program{
        public static void Main(string[] args){
            string path= @"./inventory.json";
            FetchInventory fetchInventory=new FetchInventory();

            inventoryDetails data=fetchInventory.Read(path);
            var table=new ConsoleTable("PCode","PName","Category","Mrp");

            for (int i = 0; i < data.productDetail.Count; i++)
            {
                table.AddRow(data.productDetail[i].PCode,data.productDetail[i].PName,data.productDetail[i].Category,data.productDetail[i].Mrp);
                // Console.Write("\n"+data.productDetail[i].PCode);
                // Console.Write(data.productDetail[i].PName);
                // Console.Write(data.productDetail[i].Category);
                // Console.Write(data.productDetail[i].Mrp);
                
            }
            Console.WriteLine(table);
           
        }
    }
}
