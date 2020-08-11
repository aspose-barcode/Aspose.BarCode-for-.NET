---
title: Using Aspose.BarCode for .NET via COM Interop
type: docs
weight: 20
url: /net/using-aspose-barcode-for-net-via-com-interop/
---

## **Using Aspose.BarCode for .NET via COM Interop**
You can use Aspose.BarCode for .NET via COM interop with the following languages:

- ASP
- Delphi
- JScript
- Perl
- PHP
- PowerBuilder
- Python
- VBScript
- Visual Basic
### **Working with COM Interop**
Aspose.BarCode for .NET is designed to run in the .NET framework in managed code. Applications that run outside the .NET framework use un-managed code. COM Interop can be used to utilize Aspose.BarCode for .NET in an un-managed code. You need to master the following topics to use .NET class libraries (like Aspose.BarCode for .NET) in other programming languages using COM:

- Using COM objects in your programming language. See your programming language documentation and the language-specific topics in this documentation.
- Working with COM objects exposed by .NET COM Interop. See [Interoperating With Unmanaged Code](http://msdn.microsoft.com/en-us/library/sd10k43k.aspx) and [Exposing .NET Framework Components to COM](http://msdn.microsoft.com/en-us/library/zsfww439%28v=vs.110%29.aspx) in MSDN.
- Using th eAspose.BarCode API. See [Aspose.BarCode Programmer’s Guide](http://www.aspose.com/docs/display/barcodenet/Developer+Guide) and the [API Reference](http://www.aspose.com/docs/display/barcodenet/Aspose.BarCode+for+.NET+API+Reference).
### **Register Aspose.BarCode for .NET with COM Interop**
Aspose.BarCode for .NET muse be installed on the system and it must be registered with COM Interop to be used with the above listed languages. You can use the regasm command to register the .NET assembly with COM Interop. To access the regasm command:

1. From the **Start** menu, click **All Programs**, then **Microsoft Visual Studio** (any version), followed by **Visual Studio Tools** and finally **Visual Studio Command Prompt**.
1. Enter the command to register the assembly:
- .NET Framework 1.1
  regasm "C:\Program Files\Aspose\Aspose.BarCode\bin\net1.1\Aspose.BarCode.dll" /codebase
- .NET Framework 2.0
  regasm "C:\Program Files\Aspose\Aspose.BarCode\bin\net2\Aspose.BarCode.dll" /codebase
- .NET Framework 3.0 and 3.5
  regasm "C:\Program Files\Aspose\Aspose.BarCode\Bin\net3.5\Aspose.BarCode.dll" /codebase
### **View the Classes and Methods Available for use with COM Interop**
The TLB file is provided with the .NET assemblies and can be used to view the list of classes and methods available for use with COM Interop. To view the contents of the TLB file:

1. In Visual Studio, from the **View** menu, select **Object Browser** to open the object browser.
1. Click **Edit custom component set**.
1. Click **Browse** and locate and select the TLB file.
   (The default location is **C:\Program Files (x86)\Aspose\Aspose.BarCode\bin\net2.0\Aspose.BarCode.tlb**)

Use the TLB file as a reference for calling available methods. Please note that the overloaded methods are renamed, for example, the BarCodeBuilder.Save() method has a total of 5 overloads, so the methods are Save, Save_2 and so on to Save_5.
