---
title: Use Checksum and Supplement Data
type: docs
weight: 70
url: /net/use-checksum-and-supplement-data/
---

## **Use Checksum and Supplement Data**
### **What is Checksum**
A Checksum is an error detection scheme in which some additional characters are added to a barcode to protect the integrity of barcode data. Checksums are not necessary for all kinds of barcodes. For example, Code128 and Code39 are self-checking and checksums for such symbologies are not necessary. But on the other hand, another symbology like Interleaved2Of5, which can only represent numeric data, has very little spaces between its bars and is prone to substitution errors. So, for such symbologies, checksums are necessary. There are also some symbologies such as UPC (Universal Product Code) that require a checksum.
### **What is Supplemental Barcode**
UPCA, UPCE, EAN13 and EAN8 symbologies may all include an additional barcode to the right of the main barcode. This second barcode that is usually not as tall as the main barcode, is called Supplemental Barcode and is used to encode additional information for newspapers, books, and other periodicals. The above BarCodes are generated using EAN13 symbology. The supplemental barcode may either encode 2 or 5 digits of information.

- 2 Digit Supplemental Barcodes are mostly used with magazines, newspapers and other such periodicals. The 2 Digit Supplement represents the issue number of the magazine that can be used to track which issue of the magazine is being sold, perhaps for sales analysis or restocking purposes.
- 5 Digit Supplemental Barcodes are used on books to indicate a suggested retail price. The first digit of the supplement indicates the currency in which the price is expressed. A "0" represents a price expressed in British Pounds whereas a "5" represents a price expressed in US Dollars. The remaining 4 digits of the supplement indicate the price.
### **Aspose.BarCode and Checksum**
Using [Aspose.BarCode](https://apireference.aspose.com/net/barcode), developers can enable Checksum for the barcode by setting the IsChecksumEnabled[ ](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/checksumproperties/properties/enable)property of the BarcodeGenerator class to EnableChecksum.Yes. The checksum can also be made visible or hidden in the barcode image by setting the ChecksumAlwaysShow property to true or false.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-ChecksumSupplementData-ChecksumSupplementData.cs" >}}



Once the Checksum.Enable property is set to true, the Checksum is shown on the barcode image.

Applicable symbology:

- Code11
- Code39Extended
- Code39Standard
- Code93Extended
- Code93Standard
- Interleaved2of5
- Standard2of5

The following Symbology always includes checksum:

- EAN13
- EAN8
- BooklandEAN
### **Aspose.BarCode and Supplement Data**
It is possible to encode 2 or 5 Digit Supplement Data in the barcode using Supplement.SupplementData[ ](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/supplementproperties/properties/data)property of BarcodeGenerator class. Moreover, the space between the main barcode and supplemental barcode can also be customized by using the Supplement.SupplementData property of all barcode generating classes.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-SetSupplementData-SetSupplementData.cs" >}}



The barcode symbologies, which support supplemental barcodes are as follows:

- UPCA
- UPCE
- EAN13
- EAN8
- BooklandEAN
- Interleaved2of5
- Standard2of5

SupplementSpace is the space between the main barcode and the supplement data, this setting generally will not affect the scan result.
### **Always Display Checksum character on Code128 and EAN128 Barcodes**
Code128 and EAN128 barcode symbologies also support checksum characters. To display the checksum character on the barcode image in a human-readable form, ChecksumAlwaysShow  property needs to be set. The below code example generates a Code128 barcode. The checksum character is also displayed on the barcode image.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-ChecksumSupplementData-ChecksumSupplementData.cs" >}}



The ChecksumAlwaysShow  property can be set like this:
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-DisplayChecksumCharacter-DisplayChecksumCharacter.cs" >}}
## **Applying Checksum Validation On OneCode And AustraliaPost Barcodes**
Aspose.BarCode for .NET allows developers to apply checksum validation on OneCode and AustraliaPost barcodes.
### **Applying Checksum Validation**
A new Property **ChecksumValidation** has been introduced to perform validation on **OneCode** and **AustraliaPost** barcodes. Following is the sample code demonstrating how **ChecksumValidation** can be set to off and on to perform validation.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-ApplyingChecksumValidation-ApplyingChecksumValidation.cs" >}}
## **Applying Checksum Validation On Codabar**
Aspose.BarCode for .NET allows developers to apply checksum validation on Codabar. CodabarChecksumMode enumeration has been added. It specifies the checksum algorithm for Codabar barcodes. Following is the sample code demonstrating how CodabarChecksumMode can be used.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-CodabarChecksumMode-CodabarChecksumMode.cs" >}}
## **Get Barcode With Checksum Value**
Aspose.BarCode for .NET allows developers to get barcode text along with checksum value. Following is the simple lines of code showing how to get barcode text with a checksum.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-BarcodeWithChecksumValue-BarcodeWithChecksumValue.cs" >}}
## **Identify The Type of Code128 Coded Barcode**
Aspose.BarCode for .NET allows developers to identify the type of Code128 coded barcode. Following is the sample code demonstrating how to identify the type of Code128.

{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-IdentifyTypeOfCode128-IdentifyTypeOfCode128.cs" >}}
## **Select an ECC Type to Encode a Barcode**
[Aspose.BarCode for .NET APIs](https://www.aspose.com/products/barcode/net) allows developers to select an ECC 000 to 140 and ECC 200 levels to encode a DataMatrix barcode. The new [DataMatrix](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/barcodegenerator/properties/datamatrix).[ECC ](https://apireference.aspose.com/net/barcode/aspose.barcode.generation/datamatrixproperties/properties/ecc)property is added to the BarcodeGenerator class in order to select an appropriate ECC level while encoding DataMatrix barcode. DataMatrix symbology adopts two types of error correction algorithm, depending on the ECC level employed. The ECC levels 000 to 140, which offer five different error correction levels. However, the commonly used ECC 200 level uses Reed-Solomon error correction. The new [DataMatrixEccType ](https://apireference.aspose.com/net/barcode/aspose.barcode/datamatrixecctype)Enum has been added to specify the type of the ECC to encode.

- EccAuto - Specifies that encoded ECC type is defined by default Reed-Solomon error correction or ECC 200.
- Ecc000 - Specifies that encoded ECC type is defined as ECC 000.
- Ecc050 - Specifies that encoded ECC type is defined as ECC 050.
- Ecc080 - Specifies that encoded ECC type is defined as ECC 080.
- Ecc100 - Specifies that encoded ECC type is defined as ECC 100.
- Ecc140 - Specifies that encoded ECC type is defined as ECC 140.
- Ecc200 - Specifies that encoded ECC type is defined as ECC 200.
  (This is recommended to use)
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageAndOptimizeBarcodeRecognition-ECCTypeToEnCodeBarcode-ECCTypeToEnCodeBarcode.cs" >}}
