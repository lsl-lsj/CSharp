using System;

/*
 * 隐藏构造函数
 */

namespace Demo06
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Camera cma = Camera.GetInstantce;
            Console.WriteLine($"设备标识为 : {cma.DeviceID}");
        }
    }

    internal class Camera
    {
        private static Camera c1 = new Camera();

        private Guid _deviceID;

        private Camera()
        {
            _deviceID = Guid.NewGuid();
        }

        public Guid DeviceID => _deviceID;

        public static Camera GetInstantce => c1;
    }
}