---
title: Choosing the Platform and Interoperability Technology
type: docs
weight: 10
url: /net/choosing-the-platform-and-interoperability-technology/
---

## **Choosing the Platform and Interoperability Technology**
Aspose.BarCode is a set of barcode generation and recognition components built to allow developers to add barcode functionality in their .NET and Java applications. It is available as two separate products for two different platforms.
### **Platforms**
**Aspose.BarCode for .NET:**

for .NET applications that run on .NET framework, written in any supported language (C# or VB.NET)

**Aspose.BarCode for Java:**

for Java applications (J2SE and J2EE) It is possible to use both .NET and Java version of Aspose.BarCode with other programming languages depending on the language’s support to run .NET or Java applications. The following table lists a summary for selecting the .NET or Java version of Aspose.BarCode for each language: || Programming Language || Aspose.BarCode to Use || Interoperability Technology ||| ASP | .NET | COM Interop || Delphi | .NET | COM Interop || Perl | .NET | COM Interop || | Java | Inline::Java || PHP | .NET | COM Interop || | Java | Java Bridge || PowerBuilder | .NET | COM Interop || Python | .NET | COM Interop || | Java | JPype || VBScript | .NET | COM Interop || Visual Basic | .NET | COM Interop |

As you can see from the table, for some languages like ASP, Delphi, Visual Basic and PowerBuilder, we can only use Aspose.BarCode for .NET using COM Interop. But other languages like PHP, Perl and Python offers support for both Aspose.BarCode for .NET (using COM Interop) and Java (using Inline::Java, Java Bridge and JType). The following table lists pros and cons for choosing the interoperability technology.

|**Interoperability Technology** |**Pros and Cons** |
| :- | :- |
|Aspose.BarCode for .NET via COM Interop |<p>Pros:</p><p>1. New features first appear in Aspose.BarCode for .NET and as a result, it has more features than Aspose.BarCode for Java <br>   Cons:</p><p>- Available on Microsoft Windows platforms only.</p><p>- Cannot call static methods.</p><p>- Hard to call overloaded methods (suffixes added to names).</p><p>- Hard to use enumerated values (need to look up and use a constant value).</p><p>- Cannot invoke constructors with parameters.</p>|


|Aspose.BarCode for Java via Java Bridge or Inline::Java |<p>Pros:</p><p>- Available on any platform where Java is available.</p><p>- Easy to call static methods, constructors with parameters, overloaded methods and use enumerated values. <br>  Cons:</p><p>- Has less frequent releases and fewer features than Aspose.BarCode for .NET</p>|
| :- | :- |

