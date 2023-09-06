namespace Backup.Models
{
    // Main Class
    internal abstract class Storage
    {
        public string MediaName { get; set; }
        public string Model { get; set; }

        public abstract double GetStorageCapacity();
        public abstract double CopyData(double dataSize);
        public abstract double FreeMemory();
        public abstract void PrintDeviceInfo();
    }
}