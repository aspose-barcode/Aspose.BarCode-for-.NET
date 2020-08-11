---
title: Programming Styles of .NET &amp; Java Platforms
type: docs
weight: 10
url: /net/programming-styles-of-net-&amp;-java-platforms/
---

Aspose.BarCode is available for both .NET and Java platforms. The APIs of both.NET and Java versions are almost same but they have a few differences, these differences are only because of the different programming styles or standards of.NET and Java platforms. Therefore, Aspose.BarCode for .NET follows programming guidelines widely accepted by .NET developers and Aspose.BarCode for Java follows guidelines accepted in the Java community. These differences in programming styles of .NET & Java versions are discussed below in more detail.
## **Programming Style Comparisons**
### **Namespaces vs Packages**
The names of packages in the Java version of Aspose.BarCode are different from the namespaces in .NET version:

|**Namespace in Aspose.BarCode for .NET**|**Package in Aspose.BarCode for Java**|
| :- | :- |
|Aspose.BarCode|com.aspose.barcode|
### **Classes**
Class names are same between .NET and Java versions.

|**Class Name in Aspose.BarCode for .NET**|**Class Name in Aspose.BarCode for Java**|
| :- | :- |
|BarcodeGenerator|BarCodeGenerator|
|BarCodeReader|BarCodeReader|
|MarginsF|Margins|
### **Enumerations vs Integer Constants**
Enumerations in the .NET version were ported to Java as classes with public integer constants.

|**Enumeration in Aspose.BarCode for .NET**|**Constant in Aspose.BarCode for Java**|
| :- | :- |
|Symbology.Code128|Symbology.CODE128|
All constants are integer values in Aspose.BarCode for Java where as in the .NET version, a parameter, return value or a property is of an enumerated type.
#### **C#**
{{< gist "aspose-barcode" "2224aabcdb4d2a259b10" "Aspose.BarCode-for-.NET" >}}



The main reason why we didn't use Java enum is to stay compatible with J2SE 1.4.x as Java enum appeared only in J2SE 5.0.
### **Methods**
Method names follow the accepted programming practices for each platform and therefore differ in the coding style.

|**Method Name in Aspose.BarCode for .NET**|**Method Name in Aspose.BarCode for Java**|
| :- | :- |
|BarCodeReader.Read()|BarCodeReader.read()|
|BarcodeGenerator.Save()|BarCodeGenerator.save()|
The methods are different in the casing only (method names in the Java version start with a lowercase letter).
### **Properties vs Get/Set Methods**
Properties of .NET classes are ported to Java as getter and setter methods. The original name of the method has get and set prefixes added to it.

|**Property Name in Aspose.BarCode for .NET**|**Getter and Setter in Aspose.BarCode for Java**|
| :- | :- |
|BarcodeGenerator.CodeText|BarCodeGenerator.setCodeText(), BarCodeGenerator.getCodeText()|
### **Indexed Properties**
Indexed properties in .NET are ported to Java as get() and set() methods in most cases.
