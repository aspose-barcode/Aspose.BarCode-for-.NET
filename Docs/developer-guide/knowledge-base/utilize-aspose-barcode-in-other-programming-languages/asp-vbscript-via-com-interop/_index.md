---
title: ASP - VBScript via COM Interop
type: docs
weight: 30
url: /net/asp-vbscript-via-com-interop/
---

## **Installation and Configuration**
ASP support is included with all Windows operating systems that support IIS. You need to install and configure IIS for your operating system before using Aspose.BarCode for .NET with ASP. For Windows XP or Windows 2003 Server, ASP can be made available from:

1. Go to the Control Panel.
1. Select **Add/Remove Programs**.
1. Select **Windows Components Wizard**. See the screenshot below for details.
1. Make sure that **Active Server Pages** is checked.

After the installation, create a Virtual Directory using IIS. This maps a folder on the hard disk to the virtual directory. Create the ASP files in that folder and run the script using any browser (Internet Explorer, Firefox etc.) using a URL like <http://localhost/VirtualDirectory/Filename.asp> .
### **Simple ASP - VBScript to Generate a Barcode**
This section describes how to write a simple script that generates a barcode:

1. An HTML form is displayed, where the user enters the codetext.
1. When the form is submitted, the code takes the value of the CodeText variable,
1. Generates a barcode, and saves the barcode image in a folder on the web server.




#### **Vb Script**


The code above defines SymbologyType = 15 which generates a Pdf417 barcode. Generate other barcodes by referring to the SymbologyType enumeration from the Object Browser, as shown below.

**Selecting a barcode with the Object Browser** 

![todo:image_alt_text](/plugins/servlet/confluence/placeholder/unknown-attachment)
### **Simple ASP – VBScript to Recognize BarCode**
This section shows a simple script that recognizes a barcode.

1. An HTML form is displayed, where the user enters a file name with a fully defined path.
1. When the form is submitted, the code recognize the barcode, and
1. displays the barcode's CodeText in a browser.


#### **Vb Script**


For queries, please visit the support forum for Aspose.BarCode for .NET at <http://www.aspose.com/community/forums/aspose.barcode-product-family/193/showforum.aspx>.
