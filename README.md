<h3 align="center">Shades Spec Checker</h3>

<p align="center">A fast, reliable and open source computer system hardware and information checker!
  <br />
    <a href="https://cdn.discordapp.com/attachments/713300799769280602/851893796400529408/QJ09sbCU.png">View The Demo</a>
  ·
    <a href="https://github.com/Shade0122/Shades-Spec-Checker/raw/main/ShadesSpecChecker/bin/Release/ShadesSpecChecker.exe">Download The Program</a>
  ·
    <a href="https://github.com/Shade0122/Shades-Spec-Checker/pulls">Request Features</a>
    ·
    <a href="https://github.com/Shade0122/Shades-Spec-Checker/issues">Report Issues</a>
</p>

<details open="open">
  <summary>Contents:</summary>
    <li><a>CPU & CPU Thread count</a></li>
    <li><a>Motherboard</a></li>
    <li><a>USB Controller</a></li>
    <li><a>Desktop Monitor</a></li>
    <li><a>Video Controller</a></li>
    <li><a>Disk Drive</a></li>
    <li><a>Network Adapter</a></li>
    <li><a>Username</a></li>
    <li><a>Machine Name</a></li>
    <li><a>Machine Guid</a></li>
    <li><a>IP</a></li>
    <li><a>Direct3D Version</a></li>
    <li><a>.NET Framework Version</a></li>
    <li><a>Is Visual C++ Installed</a></li>
    <li><a>Is 64 Bit Operating System</a></li>
</details>

## How is it made
Its made using C# and using [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/).

Most of the system hardware information that is being shown is from [https://docs.microsoft.com](https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/computer-system-hardware-classes?redirectedfrom=MSDN) regarding Win32, some use the environment class aswell as some others classes.

After completion, when all the information is gathered it saves in a text document named as `Log.txt`. This can be used for keeping track of your computers data, sharing and comparing information with others, etc.

It should look like this for example:
```
=========================== 10/06/2021 07:45:10 =========================== By Shade#0122

Computer System Hardware:
CPU: AMD A8-9600 RADEON R7, 10 COMPUTE CORES 4C+6G  
CPU Threads: 4
Motherboard: A320M-HDV R4.0
USB Controller: AMD USB 3.0 eXtensible Host Controller - 1.0 (Microsoft)
Standard Enhanced PCI to USB Host Controller
AMD USB 3.10 eXtensible Host Controller - 1.10 (Microsoft)
Desktop Monitor: Generic PnP Monitor
Video Controller: AMD Radeon R7 Graphics
Disk Drive: TOSHIBA HDWD110
Intenso SSD Sata III
Network Adapter: Microsoft Kernel Debug Network Adapter
Realtek PCIe GbE Family Controller
Realtek RTL8192EU Wireless LAN 802.11n USB 2.0 Network Adapter
Microsoft Wi-Fi Direct Virtual Adapter
Microsoft Wi-Fi Direct Virtual Adapter
WAN Miniport (SSTP)
WAN Miniport (IKEv2)
WAN Miniport (L2TP)
WAN Miniport (PPTP)
WAN Miniport (PPPOE)
WAN Miniport (IP)
WAN Miniport (IPv6)
WAN Miniport (Network Monitor)
Kaspersky Security Data Escort Adapter

Computer Information:
User Name: dboua
Machine Name: DESKTOP-GC4M7UF
Windows Version: Windows 10
Machine Guid: 1f669990-96f2-2853-96dd-bcb1dff5a624
IP: 75.14.69.101
Direct3D Version: Direct3D 12
.NET Framework Version: .NET Framework 4.8 Or Later
Is Visual C++ Installed: True
Is 64 Bit Operating System: True

Information was last logged: 10/06/2021 07:45:14
```
But of course people have different computers meaning different specs and information being gathered by the program, so obviously outputs will vary in information depending on the users computer.

## How do I add my own contents
Its very simple and easy todo, using the [Computer System Hardware Class provided by Microsoft Docs](https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/computer-system-hardware-classes?redirectedfrom=MSDN) you can add many other classes such as [Win32_Fan](https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/win32-fan) and alot more.

Using the class `Win32Component` which we already have provided to said user you can use the classes in the [Computer System Hardware Class](https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/computer-system-hardware-classes?redirectedfrom=MSDN).

## Example
Using `Win32_Fan` class:
```CS
Class.Write("Fan: " /*The name of what you want the content to be called.*/, ConsoleColor.DarkYellow /*Color of what the name is when being written.*/); Class.Win32Component("Win32_Fan" /*The name of the class.*/, "Name" /*The classes syntax. (The Win32Component class only accepts syntaxs that are strings but you can edit that by finding the class within the code.)*/);
```
And so on you can add as many classes as you want, all syntaxs give out different information like the devices ID, its status and even manufacturer. 

## Insight
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

[contributors-shield]: https://img.shields.io/github/contributors/Shade0122/Shades-Spec-Checker.svg?style=for-the-badge
[contributors-url]: https://github.com/Shade0122/Shades-Spec-Checker/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Shade0122/Shades-Spec-Checker.svg?style=for-the-badge
[forks-url]: https://github.com/Shade0122/Shades-Spec-Checker/network/members
[stars-shield]: https://img.shields.io/github/stars/Shade0122/Shades-Spec-Checker.svg?style=for-the-badge
[stars-url]: https://github.com/Shade0122/Shades-Spec-Checker/stargazers
[issues-shield]: https://img.shields.io/github/issues/Shade0122/Shades-Spec-Checker.svg?style=for-the-badge
[issues-url]: https://github.com/Shade0122/Shades-Spec-Checker/issues
