namespace DeviceDetectorNET.Results.Device
{
    public class DeviceMatchResult : IDeviceMatchResult
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public int? Type { get; set; }
    }
}