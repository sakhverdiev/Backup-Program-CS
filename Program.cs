using Backup.Models;

namespace Backup
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            Storage flashDrive = new Flash("Flash Drive", "HP", 3.0, 240);
            Storage dvdDisk = new DVD("DVD Disk", "Sony", 1.5, "One sided");
            Storage hddDrive = new HDD("HDD Drive", "Samsung", 2.0, 1000);

            // Devices Info
            flashDrive.PrintDeviceInfo();
            Console.WriteLine($"Storage Capacity: {flashDrive.GetStorageCapacity()} GB");
            Console.WriteLine($"Operation started: {flashDrive.CopyData(780) * 60} hours");
            Console.WriteLine($"Free space: {flashDrive.FreeMemory()} GB");
            Console.WriteLine("\n---------------------\n");

            dvdDisk.PrintDeviceInfo();
            Console.WriteLine($"Storage Capacity: {dvdDisk.GetStorageCapacity()} GB");
            Console.WriteLine($"Operation started: {dvdDisk.CopyData(780) * 60} hours");
            Console.WriteLine($"Free space: {dvdDisk.FreeMemory()} GB");
            Console.WriteLine("\n---------------------\n");

            hddDrive.PrintDeviceInfo();
            Console.WriteLine($"Storage Capacity: {hddDrive.GetStorageCapacity()} GB");
            Console.WriteLine($"Operation started: {hddDrive.CopyData(780)* 60} hours");
            Console.WriteLine($"Free space: {hddDrive.FreeMemory()} GB");
        }
    }
}

