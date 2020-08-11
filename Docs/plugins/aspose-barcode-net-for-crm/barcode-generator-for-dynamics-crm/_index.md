---
title: BarCode Generator for Dynamics CRM
type: docs
weight: 10
url: /net/barcode-generator-for-dynamics-crm/
---

**Contents Summary**

- [Introduction](#BarCodeGeneratorforDynamicsCRM-Introduction)
- [System Requirements and Supported Platforms](#BarCodeGeneratorforDynamicsCRM-SystemRequirementsandSupportedPlatforms) 
  - [System Requirements](#BarCodeGeneratorforDynamicsCRM-SystemRequirements)
  - [Supported Platforms](#BarCodeGeneratorforDynamicsCRM-SupportedPlatforms)
- [Downloading](#BarCodeGeneratorforDynamicsCRM-Downloading)
- [Installing or Uninstalling](#BarCodeGeneratorforDynamicsCRM-InstallingorUninstalling) 
  - [How to Install](#BarCodeGeneratorforDynamicsCRM-HowtoInstall)
  - [Applying License](#BarCodeGeneratorforDynamicsCRM-ApplyingLicense)
  - [How to Uninstall](#BarCodeGeneratorforDynamicsCRM-HowtoUninstall)
- [Using](#BarCodeGeneratorforDynamicsCRM-Using) 
  - [Create BarCode Configuration](#BarCodeGeneratorforDynamicsCRM-CreateBarCodeConfiguration)
  - [Get Token for BarCode in E-Mail](#BarCodeGeneratorforDynamicsCRM-GetTokenforBarCodeinE-Mail)
- [Video Demo](#BarCodeGeneratorforDynamicsCRM-VideoDemo)
- [Support, Extend and Contribute](#BarCodeGeneratorforDynamicsCRM-Support,ExtendandContribute) 
  - [Support](#BarCodeGeneratorforDynamicsCRM-Support)
  - [Extend and Contribute](#BarCodeGeneratorforDynamicsCRM-ExtendandContribute)
## **Introduction**
Aspose .NET BarCode Generator is open source add-on used to generate and send BarCodes from CRM via E-mail. You can configure multiple BarCodes with in CRM and and generate BarCode in e-mail as you want. Configuration provides multiple symbologies option and you can also select these configurations while creating e-mail. Aspose .NET BarCode Generator can be used with CRM on-premises and CRM Online.

The release of this add-on supports the following features:

- Create and Configure Multiple BarCode styles.
- Select different Symbologies while creating BarCode styles.
- Get Token button on e-mail entity.
- Insert Token with in e-mail body.
- Generate BarCode and replace inside e-mail when sending.
- BarCode generation functionality is seperated with other plugins.
## **System Requirements and Supported Platforms**
### **System Requirements**
In order to install and use Aspose .NET BarCode Generator for Microsoft Dynamics CRM you need to have one of the following CRM version installed.

- Microsoft Dynamics CRM 2013 On-Premises.
- Microsoft Dynamics CRM 2015 On-Premises.
- Microsoft Dynamics CRM Online.

Please feel free to contact us if you find any issues in installing or using this Add-on.
### **Supported Platforms**
This addon will work with all version of Microsoft Dynamics CRM:

- Microsoft Dynamics CRM 2013 On-Premises.
- Microsoft Dynamics CRM 2015 On-Premises.
- Microsoft Dynamics CRM Online.
## **Downloading**
You can download the latest solution for Microsoft Dynamics CRM 2013 at:

- [Codeplex](https://asposenetcrm.codeplex.com/releases/view/617992)
- [Codeplex](https://asposebarcodenet.codeplex.com/releases/view/618001)
- [Github](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET/releases/tag/AsposeNetBarCodeGenerator2013)
- [Code.MSDN](https://code.msdn.microsoft.com/Aspose-NET-BarCodeGenerator-ecd5b561)

You can download the latest solution for Microsoft Dynamics CRM 2015 at:

- [Codeplex](https://asposenetcrm.codeplex.com/releases/view/617991)
- [Codeplex](https://asposebarcodenet.codeplex.com/releases/view/618000)
- [Github](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET/releases/tag/AsposeNetBarCodeGenerator2015)
- [Code.MSDN](https://code.msdn.microsoft.com/Aspose-NET-BarCodeGenerator-ecd5b561)
## **Installing or Uninstalling**
### **How to Install**
**Importing the Solution**

- Download the Solution File. (Managed if you intent to uninstall it)
- Open CRM and go to Import Solution.
- Click Browse and select the downloaded solution file and click next.
- Click Next and wait for the solution to import.
- Click close when the solution is imported successfully.

**Configuring Web Page**

- Download the source code for website.
- Copy on server. (Recomended under inetpub)
- Open IIS. (On server where you intent to deploy website, accessible from CRM server)
- Create a new Website.
- Choose physical path and configure website.
- Browse to check if it is accessible.
- Update Plugin code with correct URL.
### **Applying License**
- Copy the license File on the server and copy the path of the file. 
  - Recomended: "C:\Aspose\Aspose.Total.Lic".
- Use the license file on the website code.
### **How to Uninstall**
- Delete Website from IIS.
- Go to solution and select "Aspose .NET BarCode Generator".
- Press the Delete button. press OK for confirmation.
## **Using**
### **Create BarCode Configuration**
- Go to BarCode Configuration Entity in CRM.
- Create a new record select name, data and Symbology.
- ` `Save the record.
### **Get Token for BarCode in E-Mail**
- Open E-mail.
- Create email as you want.
- Press the Get Token Button on the top to insert token in email body.
- Select the BarCode Configuration and click insert.
- Once sent, the token in email body is replaced by the BarCode.
## **Video Demo**
Please check [the video](https://youtu.be/KbAOdIPbTDM) below to see the plugin in action.
## **Support, Extend and Contribute**
### **Support**
We offer free support. Anyone who uses our product, whether they have bought them or are using an evaluation, deserves our full attention and respect.

You can log any issues or suggestions related to Aspose .NET AutoMerge using any of the following platforms:

- [Codeplex](https://asposenetcrm.codeplex.com/workitem/list/basic)
- [Codeplex](https://asposebarcodenet.codeplex.com/workitem/list/basic)
- [Github](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET/issues)
- [Code.MSDN](https://code.msdn.microsoft.com/Aspose-NET-BarCodeGenerator-ecd5b561)
### **Extend and Contribute**
You can download the latest source code at:

- [CodePlex](https://asposenetcrm.codeplex.com/SourceControl/latest#Aspose .NET BarCode Generator/Source Code/).
- [CodePlex](https://asposebarcodenet.codeplex.com/SourceControl/latest#Aspose .NET BarCode Generator/Source Code/).
- [GitHub](https://github.com/aspose-barcode/Aspose.BarCode-for-.NET/tree/master/Plugins/Dynamics%20CRM/Aspose%20.NET%20BarCode%20Generator).
- [Code.MSDN](https://code.msdn.microsoft.com/Aspose-NET-BarCodeGenerator-ecd5b561).

In this scenario we have used Aspose.BarCode.dll to generate document from a template.

{{< highlight csharp >}}

 string CodeText = Request.QueryString["codetext"];

string Symbology = Request.QueryString["symbology"];

if (String.IsNullOrEmpty(CodeText))

    CodeText = "Aspose .NET BarCode Generator for Dynamics CRM";

//Instantiate barcode object

BarCodeBuilder BarCode = new BarCodeBuilder();

//Set the Code text for the barcode

BarCode.CodeText = CodeText;

//Set the symbology type to Code128

string SymbologyText = Symbology;

BarCode.SymbologyType = GetSymbologyType(SymbologyText);

//Create an instance of resolution and apply on the barcode image with

//customized resolution settings

BarCode.Resolution = new Resolution(200f, 400f, ResolutionMode.Customized);

MemoryStream MemoryStream = new MemoryStream();

BarCode.Save(MemoryStream, BarCodeImageFormat.Png);

byte[] byteData = MemoryStream.ToArray();

Response.Clear();

Response.ContentType = "image/jpeg";

Response.BinaryWrite(byteData);

Response.End();

{{< /highlight >}}
