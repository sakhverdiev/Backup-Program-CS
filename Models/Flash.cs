namespace Backup.Models
{
    internal class Flash : Storage
    {
        public double UsbSpeed { get; set; }
        public double Memory { get; set; }
        public double UsedMemory { get; set; }

        public Flash(string mediaName, string model, double usbSpeed, double memory)
        {
            MediaName = mediaName;
            Model = model;
            UsbSpeed = usbSpeed;
            Memory = memory;
        }

        public override double GetStorageCapacity()
        {
            return Memory;
        }

        public override double CopyData(double dataSize)
        {
            double timeInHours = dataSize / (UsbSpeed * 1024); // MB to GB
            return timeInHours;
        }

        public override double FreeMemory()
        {
            double usedSpace = UsedMemory;
            double totalSpace = Memory;

            double freeSpace = totalSpace - usedSpace;
            return freeSpace;
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media name: {MediaName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"USB speed: {UsbSpeed} GB/hour");
            Console.WriteLine($"Overall memory size: {Memory} GB");
        }
    }
}
