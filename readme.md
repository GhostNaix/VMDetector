Detects whether your application is running inside a Virtual Machine.

At a glance:
---
**C#:**
```csharp
var hypervisorName = "";

// check without the need to know the hypervisor name
if (VirtualMachineDetector.Assert())
   Console.WriteLine("VIRTUAL MACHINE DETECTED !");

// check and obtain hypervisor name, if available
if (VirtualMachineDetector.Assert(out hypervisorName))
   Console.WriteLine("DETECTED {0}!", hypervisorName);
```

Platform status:
---
  - VMWare Workstation Player - **COMPLETED**
  - Microsoft Hyper-V under Windows Server Datacenter 2012 - **COMPLETED**
  - Microsoft Virtual PC - **COMPLETED**
  - QEMU - **PARTIALLY COMPLETED**
  - VirtualBox - **IN PROGRESS**
  - Xen - **TBD**
  - Citrix - **TBD**

Compatibility:
---
  - .NET Framework 4.0+

Latest Changes:
---
	- 2017-07-17 - initial version

Contact:
---

Robson Felix
	- robson dot felix at gmail dot com (_use this for everything that is not available via GitHub features_)