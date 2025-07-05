using EFCodeFirst_HardDel_List.Data;
using EFCodeFirst_SoftDel_List.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

var db = new ApplicationDbContext();
//Console.WriteLine("Add Vegtables List");
//Console.Write("Enter number of names: ");
//int nameCount = int.Parse(Console.ReadLine());

//var vlist = new List<Vegtables>();
//for (int i = 0; i < nameCount; i++)
//{
//    Console.Write($"Enter name {i + 1}: ");

//    var VegName = Console.ReadLine();
//    vlist.Add(new Vegtables { Name = VegName });

//}
//db.Vegtables.AddRange(vlist);
//db.SaveChanges();

////******************************************************************
//bool isValid = false;
//int number = 0;

//do
//{
//    Console.Write("Enter a number: ");
//    try
//    {
//        number = int.Parse(Console.ReadLine());
//        isValid = true;
//    }
//    catch
//    {
//        Console.WriteLine("Invalid input. Please enter a valid integer.");
//    }

//} while (!isValid);

//Console.WriteLine("You entered: " + number);
//var VegList = db.Vegtables.Where(f => f.Id == number).ToList();
//if (VegList.Any() && VegList != null)
//{
//    foreach (var Fruits in VegList)
//    {
//        Fruits.Name = "Healthy Food";
//    }
//}
//db.Vegtables.UpdateRange(VegList);
//db.SaveChanges();

//******************************************************************

//Delete 
//Console.Write("Enter Vegtable ID: ");
//var id = int.Parse(Console.ReadLine());
//var VegById = db.Vegtables.FirstOrDefault(v => v.Id == id);
//VegById.IsDeleted = true;
//db.Vegtables.Update(VegById);
//db.SaveChanges();

//******************************************************************
//Search by ID
//Console.Write("Enter Vegtable ID: ");
//var id = int.Parse(Console.ReadLine());
//var VegById = db.Vegtables.Where(v => v.Id == id).ToList();
//Console.WriteLine("\nVegtable with Id :");
//foreach (Vegtables vegtables in VegById)
//{
//    Console.WriteLine("Vegtable Id =" + vegtables.Id + ", Vegtable Name =" + vegtables.Name);
//}

//******************************************************************

//Console.WriteLine("Get List");
//var vlist = db.Vegtables.ToList();
//foreach (var vegtables in vlist)
//{
//    Console.WriteLine("Vegtable Id =" + vegtables.Id + ", Vegtable Name =" + vegtables.Name);
//}


//********************************************************************
//restore list
//Console.WriteLine("Get restore List");
//var Veglist = db.Vegtables.Where(v => v.IsDeleted == true).ToList();
//foreach (var vegtables in Veglist)
//{
//   Console.WriteLine("Vegtable Id =" + vegtables.Id + ", Vegtable Name =" + vegtables.Name);
//}

