namespace Backup.Models
{
    internal class DVD : Storage
    {
        public double ReadWriteSpeed { get; set; }
        public string Type { get; set; }
        public double UsedSpace { get; set; }

        public DVD(string mediaName, string model, double readWriteSpeed, string type)
        {
            MediaName = mediaName;
            Model = model;
            ReadWriteSpeed = readWriteSpeed;
            Type = type;
        }

        public override double GetStorageCapacity()
        {
            if (Type == "One sided")
                return 4.7;
            else if (Type == "Two sided")
                return 9.0;
            else
                return 0.0;
        }

        public override double CopyData(double dataSize)
        {
            double timeInHours = dataSize / (ReadWriteSpeed * 1024); // MB to GB
            return timeInHours;
        }

        public override double FreeMemory()
        {
            double usedSpace = UsedSpace;
            double totalSpace = GetStorageCapacity();

            double freeSpace = totalSpace - usedSpace;
            return freeSpace;
        }

        public override void PrintDeviceInfo()
        {
            Console.WriteLine($"Media name: {MediaName}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Read Write speed: {ReadWriteSpeed} GB/hour");
            Console.WriteLine($"Type: {Type}");
        }
    }
}
