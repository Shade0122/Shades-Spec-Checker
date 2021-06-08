using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Net;
using System.Text;

namespace ShadesSpecChecker
{
    class Class
    {
        public static StringBuilder String = new StringBuilder();
        public static void MachineGuid()
        {
            if (RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Cryptography") == null)
                throw new KeyNotFoundException(string.Format("Registry key not found: {0}", @"SOFTWARE\Microsoft\Cryptography"));
            if (RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Cryptography").GetValue("MachineGuid") == null)
                throw new IndexOutOfRangeException(string.Format("Index not found: {0}", "MachineGuid"));
            WriteLine(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Cryptography").GetValue("MachineGuid").ToString(),ConsoleColor.White);
        }

        public static void IP()
        {
            WriteLine(new WebClient().DownloadString("http://ipv4bot.whatismyipaddress.com/"), ConsoleColor.White);
        }

        public static void IsVisualCPPInstalled()
        {
            if (File.Exists("C:\\Windows\\System32\\vcruntime140.dll")) WriteLine("True",ConsoleColor.Green); 
            else WriteLine("False - https://support.microsoft.com/en-us/topic/the-latest-supported-visual-c-downloads-2647da03-1eea-4433-9aff-95f26a218cc0",ConsoleColor.Red); 
        }

        public static void Is64BitOperatingSystem()
        {
            if (Environment.Is64BitOperatingSystem == true) WriteLine("True", ConsoleColor.Green);
            else WriteLine("False", ConsoleColor.Red);
        }

        public static void Direct3DVersion()
        {
            if (File.Exists("C:\\Windows\\System32\\D3D12.dll")) WriteLine("Direct3D 12", ConsoleColor.White);
            else if (File.Exists("C:\\Windows\\System32\\d3d11.dll")) WriteLine("Direct3D 11", ConsoleColor.White);
            else if (File.Exists("C:\\Windows\\System32\\d3d10.dll")) WriteLine("Direct3D 10", ConsoleColor.White);
            else if (File.Exists("C:\\Windows\\System32\\d3d9.dll")) WriteLine("Direct3D 9", ConsoleColor.White);
            else WriteLine("Undetected Direct 3D Version", ConsoleColor.White);
        }

        public static void NETFrameworkVersion()
        {
            WriteLine(NETVersionDecoder((int)RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(@"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\").GetValue("Release")),ConsoleColor.White);
        }

        private static string NETVersionDecoder(int releaseKey)
        {
            if (releaseKey >= 528040)
                return ".NET Framework 4.8 Or Later";
            if (releaseKey >= 461808)
                return ".NET Framework 4.7.2";
            if (releaseKey >= 461308)
                return ".NET Framework 4.7.1";
            if (releaseKey >= 460798)
                return ".NET Framework 4.7";
            if (releaseKey >= 394802)
                return ".NET Framework 4.6.2";
            if (releaseKey >= 394254)
                return ".NET Framework 4.6.1";
            if (releaseKey >= 393295)
                return ".NET Framework 4.6";
            if (releaseKey >= 379893)
                return ".NET Framework 4.5.2";
            if (releaseKey >= 378675)
                return ".NET Framework 4.5.1";
            if (releaseKey >= 378389)
                return ".NET Framework 4.5";
            else
                return "Undetected Version - Either Not Installed Or Older Than 4.5";
        }

        public static void UserName()
        {
            WriteLine(Environment.UserName, ConsoleColor.White);
        }

        public static void MachineName()
        {
            WriteLine(Environment.MachineName, ConsoleColor.White);
        }

        public static string WindowsVersionClass()
        {
            switch (Environment.OSVersion.Version.Major)
            {
                case 10: return "Windows 10";
                case 6:
                {
                        switch (Environment.OSVersion.Version.Minor)
                        {
                            case 0: return "Windows Vista";
                            case 1: return "Windows 7";
                            case 2: return "Windows 8";
                            case 3: return "Windows 8.1";
                            default: return "Undetected Windows Version";
                        }
                    }
                case 5: return "Windows XP";
                default: return "Undetected Windows Version - Likely Older Than XP.";
            }
        }

        public static void WindowsVersion()
        {
            WriteLine(WindowsVersionClass(), ConsoleColor.White);
        }

        public static void NumberOfCPU()
        {
            WriteLine("" + Environment.ProcessorCount, ConsoleColor.White);
        }

        public static void Win32Component(string Class, string Syntax) //https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/computer-system-hardware-classes?redirectedfrom=MSDN
        {
            foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "Select * FROM " + Class).Get())
            {
                WriteLine(Convert.ToString(managementObject[Syntax].ToString()) ,ConsoleColor.White);
            }
        }

        public static void WriteLine(string _string, ConsoleColor color)
        { 
            Console.WriteLine(_string, Console.ForegroundColor = color);
            String.Append(_string).Append(Environment.NewLine);
        }

        public static void Write(string _string, ConsoleColor color)
        {
            Console.Write(_string, Console.ForegroundColor = color);
            String.Append(_string);
        }

        public static void Log()
        {
            try
            {
                using (StreamWriter File = System.IO.File.AppendText("./Log.txt"))
                {
                    File.Write(String.ToString());
                    File.Close();
                    File.Dispose();
                }
            } 
            catch (Exception exception)
            {
                WriteLine("Failed to write file, exception caught: " + exception, ConsoleColor.Red);
            }
        }
    }
}