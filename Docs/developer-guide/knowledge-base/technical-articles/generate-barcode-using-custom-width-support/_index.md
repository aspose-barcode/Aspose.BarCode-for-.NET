---
title: Generate Barcode Using Custom Width Support
type: docs
weight: 110
url: /net/generate-barcode-using-custom-width-support/
---

## **Generate Barcode Using Custom Width Support**
Originally, barcodes systematically represented data by varying the widths and spacings of parallel lines. Now, you can generate and recognize barcodes with custom widths. The idea is to calculate the widths for all supported properties and generate a barcode that fits in the space left. Barcodes with custom widths support these properties:

- The caption above and below (but not located to the left, center or right).
- Code text (only at the bottom).
- Margins.
- Supports different graphics unit as usual.
- Limited to 2 lines for each type of text. More would flatten the barcode image.
- If no license has been applied (if you're testing Aspose.BarCode) Aspose wording automatically appears at the top left corner.
- To get a barcode image with no text or margins, turn off those properties.
### **Create an Image With Exact Barcode Only**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-CreateImageWithExactBarcodeOnly-CreateImageWithExactBarcodeOnly.cs" >}}
### **Create and Set Size for the Whole Picture With Barcode inside**
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-CreateAndSetSizeForImageWithBarcode-CreateAndSetSizeForImageWithBarcode.cs" >}}
