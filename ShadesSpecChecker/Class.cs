using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Text;
using System.Threading;
using System.Xml;

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
            WriteLine(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Cryptography").GetValue("MachineGuid").ToString());
        }

        public static void IP()
        {
            WriteLine(new WebClient().DownloadString("http://ipv4bot.whatismyipaddress.com/"));
        }
        public static bool IsVisualCPPInstalled()
        {
            return File.Exists("C:\\Windows\\System32\\vcruntime140.dll");
        }
        public static string Direct3DVersion()
        {
            if (File.Exists("C:\\Windows\\System32\\D3D12.dll")) return "Direct3D 12";
            else if (File.Exists("C:\\Windows\\System32\\d3d11.dll")) return "Direct3D 11";
            else if (File.Exists("C:\\Windows\\System32\\d3d10.dll")) return "Direct3D 10";
            else if (File.Exists("C:\\Windows\\System32\\d3d9.dll")) return "Direct3D 9";
            else return "Undetected Direct 3D Version";
        }
        public static string NETFrameworkVersion() // https://docs.microsoft.com/en-us/dotnet/framework/migration-guide/how-to-determine-which-versions-are-installed
        {
            const string subkey = @"SOFTWARE\Microsoft\NET Framework Setup\NDP\v4\Full\";

            using (var ndpKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry32).OpenSubKey(subkey))
            {
                return NETVersionDecoder((int)ndpKey.GetValue("Release"));
            }
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
            return "Undetected Version - Either Not Installed Or Older Than 4.5";
        }
        public static string WindowsVersion()
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
        public static void Win32Component(string Class, string Syntax) //https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/computer-system-hardware-classes?redirectedfrom=MSDN
        {
            foreach (ManagementObject managementObject in new ManagementObjectSearcher("root\\CIMV2", "Select * FROM " + Class).Get())
            {
                WriteLine(Convert.ToString(managementObject[Syntax].ToString()));
            }
        }

        public static void WriteLine(string _string)
        { 
            if(_string == "") _string = "Error - This Could Be Because The Specific Hardware Item Does Not Apply To Your Device\n";
            Console.WriteLine(_string);
            String.Append(_string).Append(Environment.NewLine);
        }

        public static void Write(string _string)
        {
            if (_string == "") _string = "Error - This Could Be Because The Specific Hardware Item Does Not Apply To Your Device\n";
            Console.Write(_string);
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
                WriteLine("Failed to write file, exception caught: " + exception);
            }
        }
    }
}