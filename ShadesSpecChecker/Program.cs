using System;

namespace ShadesSpecChecker
{
    class Program
    {
        static void Main()
        {
            Class.WriteLine("=========================== " + DateTime.Now.ToString() + " =========================== By Shade#0122" + "\n");

            Class.WriteLine("Computer System Hardware: ");
            Class.Write("Processor: "); Class.Win32Component("Win32_Processor", "Name");
            Class.Write("USB Controller: "); Class.Win32Component("Win32_USBController", "Name");
            Class.Write("Battery: "); Class.Win32Component("Win32_Battery", "Name");
            Class.Write("Voltage Probe: "); Class.Win32Component("Win32_VoltageProbe", "Name");
            Class.Write("Desktop Monitor: "); Class.Win32Component("Win32_DesktopMonitor", "Name");
            Class.Write("Video Controller: "); Class.Win32Component("Win32_VideoController", "Name");

            Class.WriteLine("\n" + "Computer Information:");
            Class.Write("Machine Guid: "); Class.MachineGuid();
            Class.Write("IP: "); Class.IP();
            Class.Write("User Name: " + Environment.UserName + "\n");
            Class.Write("Machine Name: " + Environment.MachineName + "\n");
            Class.Write("Windows Version: " + Class.WindowsVersion() + "\n");
            Class.Write("Direct3D Version: " + Class.Direct3DVersion() + "\n");
            Class.Write(".NET Framework Version: " + Class.NETFrameworkVersion() + "\n");
            Class.Write("Is Visual C++ Installed: " + Class.IsVisualCPPInstalled() + "\n");
            Class.WriteLine("\n" + "Information was last logged: " + DateTime.Now.ToString());

            Class.Log();

            Console.WriteLine("\n" + "Press any key to exit.");
            Console.ReadKey();
        }
    }
}
