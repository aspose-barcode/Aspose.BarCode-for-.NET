---
title: Perl via COM Interop
type: docs
weight: 70
url: /net/perl-via-com-interop/
---

## **Installation and Configuration**
Perl binaries are available from <http://www.perl.com/download.csp>. Please download and install the binaries for your Windows Operating System.For adding COM support to Perl, you need Win32::OLE extension. Please visit [http://search.cpan.org/jdb/Win32-OLE-0.1709/lib/Win32/OLE.pm](http://search.cpan.org/~jdb/Win32-OLE-0.1709/lib/Win32/OLE.pm) for more information.
Alternatively, you can also get another free distribution of Perl from ActiveState. Please visit <http://www.activestate.com/Products/activeperl/index.mhtml> for details. ActivePerl comes with core Perl and Win32::OLE extension.
## **Perl Code to Generate BarCode**
The code below will generate barcode of type Pdf417 and save the barcode image in a folder in the hard disk.
#### **PERL**
{{< highlight java >}}

 # For complete examples and data files, please go to https://github.com/aspose-barcode/Aspose.BarCode-for-.NET

use Win32::OLE;  

\# Create an instance of BarCodeBuilder

my $barcode = CreateObject Win32::OLE 'Aspose.BarCode.BarCodeBuilder';

\# Set code text and symbology type and save the barcode image

$barcode->{CodeText} = "test-123";

$barcode->{SymbologyType} = 15;

$barcode->Save("testperl_out.png");

{{< /highlight >}}



Please note that the above code sample uses constant value 4096 for Symbology type which is for Pdf417. 
