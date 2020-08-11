---
title: Python via COM Interop
type: docs
weight: 50
url: /net/python-via-com-interop/
---

## **Installation and Configuration**
Python binaries are available from [http://www.python.org](http://www.python.org/). You need to download and install it before using Aspose.BarCode. After installing Python, you need to add COM interop support to it. Python Extensions for Windows is an open source library that supports COM interop support with Python. You can get it from <http://pypi.python.org/pypi/pywin32>. An alternate Python distribution is available from ActiveState ([http://www.activestate.com](http://www.activestate.com/)) that comes with the Windows extensions and Python WinEditor.
## **Python Code to Generate BarCode**
The sample code generates a barcode of Symbology type Pdf417.
#### **Python**
{{< highlight java >}}

 import win32com.client

\# Create an instance of BarCodeBuilder class using COM interop

barcodeBuilder = win32com.client.Dispatch("Aspose.BarCode.BarCodeBuilder")

\# Set codetext and symbology type and save the barcode image to file in disk

barcodeBuilder.CodeText = "testing-123"

barcodeBuilder.SymbologyType = 15

barcodeBuilder.Save("testPython.png")

{{< /highlight >}}



Note that the above code sample uses constant value 4096 for Symbology type which is for Pdf417. 
