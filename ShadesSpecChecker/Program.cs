using System;

namespace ShadesSpecChecker
{
    class Program
    {
        static void Main()
        {
            Class.WriteLine("=========================== " + DateTime.Now.ToString() + " =========================== By Shade#0122" + "\n", ConsoleColor.DarkGray);

            Class.WriteLine("Computer System Hardware:", ConsoleColor.Cyan);
            Class.Write("CPU: ", ConsoleColor.DarkYellow); Class.Win32Component("Win32_Processor", "Name");
            Class.Write("CPU Threads: ", ConsoleColor.DarkYellow); Class.NumberOfCPU();
            Class.Write("Motherboard: ", ConsoleColor.DarkYellow); Class.Win32Component("Win32_BaseBoard", "Product");
            Class.Write("USB Controller: ", ConsoleColor.DarkYellow); Class.Win32Component("Win32_USBController", "Name");
            Class.Write("Desktop Monitor: ", ConsoleColor.DarkYellow); Class.Win32Component("Win32_DesktopMonitor", "MonitorType");
            Class.Write("Video Controller: ", ConsoleColor.DarkYellow); Class.Win32Component("Win32_VideoController", "Name");
            Class.Write("Disk Drive: ",ConsoleColor.DarkYellow); Class.Win32Component("Win32_DiskDrive", "Model");
            Class.Write("Network Adapter: ", ConsoleColor.DarkYellow); Class.Win32Component("Win32_NetworkAdapter", "Name");

            Class.WriteLine("\n" + "Computer Information:", ConsoleColor.Cyan);
            Class.Write("User Name: ", ConsoleColor.DarkYellow); Class.UserName();
            Class.Write("Machine Name: ", ConsoleColor.DarkYellow); Class.MachineName();
            Class.Write("Windows Version: ", ConsoleColor.DarkYellow); Class.WindowsVersion();
            Class.Write("Machine Guid: ", ConsoleColor.DarkYellow); Class.MachineGuid();
            Class.Write("IP: ", ConsoleColor.DarkYellow); Class.IP();
            Class.Write("Direct3D Version: ", ConsoleColor.DarkYellow); Class.Direct3DVersion();
            Class.Write(".NET Framework Version: ", ConsoleColor.DarkYellow); Class.NETFrameworkVersion();
            Class.Write("Is Visual C++ Installed: ", ConsoleColor.DarkYellow); Class.IsVisualCPPInstalled();
            Class.Write("Is 64 Bit Operating System: ", ConsoleColor.DarkYellow); Class.Is64BitOperatingSystem();

            Class.WriteLine("\n"+ "Information was last logged: " + DateTime.Now.ToString() + "\n", ConsoleColor.DarkGray);
            Class.Log();
            Class.WriteLine("All information successfully logged in Log.txt, press any key to exit.", ConsoleColor.Green);
            Console.ReadKey();
        }
    }
}
