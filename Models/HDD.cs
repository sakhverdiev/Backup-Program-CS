namespace Backup.Models
{
    internal class HDD : Storage
    {
        public double UsbSpeed { get; set; }
        public double TotalSize { get; set; }
        public double UsedStorage { get; set; }

        public HDD(string mediaName, string model, double usbSpeed, double totalSize)
        {
            MediaName = mediaName;
            Model = model;
            UsbSpeed = usbSpeed;
            TotalSize = totalSize;
        }

        public override double GetStorageCapacity()
        {
            return TotalSize;
        }

        public override double CopyData(double dataSize)
        {
            double timeInHours = dataSize / (UsbSpeed * 1024); // MB cinsindən GB cinsinə çeviririk
            return timeInHours;
        }

        public override double FreeMemory()
        {
            double usedSpace = UsedStorage;
            double totalSpace = TotalSize;

            double freeSpace = totalSpace - usedSpace;
            return freeSpace;
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media name: {MediaName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"USB speed: {UsbSpeed} GB/hour");
            Console.WriteLine($"Total size: {TotalSize} GB");
        }
    }
}