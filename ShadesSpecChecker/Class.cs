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
            WriteLine(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).OpenSubKey(@"SOFTWARE\Microsoft\Cryptography").GetValue("MachineGuid").ToString());
        }

        public static void IP()
        {
            WriteLine(new WebClient().DownloadString("http://ipv4bot.whatismyipaddress.com/"));
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
            Console.WriteLine(_string);
            String.Append(_string).Append(Environment.NewLine);
        }

        public static void Write(string _string)
        {
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