<h3 align="center">Shades Spec Checker</h3>

<p align="center">A fast, reliable and open source computer system hardware and information checker!
  <br />
    <a href="https://cdn.discordapp.com/attachments/713300799769280602/851893796400529408/QJ09sbCU.png">View The Demo</a>
  ·
    <a href="https://github.com/Shade0122/Shades-Spec-Checker/raw/main/ShadesSpecChecker/bin/Release/ShadesSpecChecker.exe">Download The Program</a>
  ·
    <a href="https://github.com/Shade0122/Shades-Spec-Checker/pulls">Request Features</a>
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

## How do I add my own contents
Its very simple and easy todo, using the [Computer System Hardware Class provided by Microsoft Docs](https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/computer-system-hardware-classes?redirectedfrom=MSDN) you can add many other classes such as [Win32_Fan](https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/win32-fan) and alot more.

Using the class `Win32Component` which we already have provided to said user you can use the classes in the [Computer System Hardware Class](https://docs.microsoft.com/en-gb/windows/win32/cimwin32prov/computer-system-hardware-classes?redirectedfrom=MSDN).

## Example
Using `Win32_Fan` class:
```CS
Class.Write("Fan: " /*The name of what you want the content to be called.*/, ConsoleColor.DarkYellow /*Color of what the name is when being written.*/); Class.Win32Component("Win32_Fan" /*The name of the class.*/, "Name" /*The classes syntax. (The Win32Component class only accepts syntaxs that are strings but you can edit that by finding the class within the code.)*/);
```
And so on you can add as many classes as you want, all syntaxs give out different information like the devices ID, its status and even manufacturer. 

## Contact
If you want to contact me, report any issue with it or wanna suggest any contents wanting to be added you can either do the following:
* [Contact Me On Discord: Shade#0122](https://discord.com)
* [Request Features](https://github.com/Shade0122/Shades-Spec-Checker/pulls)
* [Report Issues](https://github.com/Shade0122/Shades-Spec-Checker/issues)

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
