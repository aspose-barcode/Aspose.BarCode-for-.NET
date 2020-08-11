---
title: Public API Changes in Aspose.BarCode 7.0.0
type: docs
weight: 50
url: /net/public-api-changes-in-aspose-barcode-7-0-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.BarCode API from version 6.9.0 to 7.0.0, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode. 

{{% /alert %}} 
### **Property BarCodeBuilder.QREncodeType is added**
Added a QREncodeType property in [BarCodeBuilder](/pages/createpage.action?spaceKey=barcodenet&title=Aspose.BarCode.BarCodeBuilder+Class&linkCreation=true&fromPageId=12943444) Class. This new property works as QR / MicroQR selector. Select ForceQR (default) for standard QR symbols, Auto for MicroQR.
### **Property BarCodeBuilder.ECIEncoding is added**
Added a ECIEncoding property in [BarCodeBuilder](/pages/createpage.action?spaceKey=barcodenet&title=Aspose.BarCode.BarCodeBuilder+Class&linkCreation=true&fromPageId=12943444) Class. It is used to tell the barcode reader details about the used references for encoding the data in the symbol by the Extended Channel Interpretation Identifiers.
### **The Enum QREncodeType is added**
Description of the new Enum QREncodeType:

1. **Auto** - mode starts barcode version negotiation from MicroQR V1
1. **ForceQR** – mode starts barcode version negotiation from QR V1
1. **ForceMicroQR** - mode starts barcode version negotiation from MicroQR V1 to V4. If data cannot be encoded into MicroQR, exception is thrown.
### **The Enum QREncodeMode is added**
Description of the new Enum QREncodeMode:

1. **Auto** - encode codetext as is non-unicode charset. If there is any unicode character, the codetext will be encoded with value which is set in CodeTextEncoding.
1. **Bytes** - encode codetext as plain bytes. If it detects any unicode character, the character will be encoded as two bytes, lower byte first;
1. **Utf8BOM** - encode codetext with UTF8 encoding with first ByteOfMark character;
1. **Utf16BEBOM** - encode codetext with UTF8 encoding with first ByteOfMark character. It can be problems with some barcode scaners;
1. **ECIEncoding** - encode codetext with value set in the ECIEncoding property. It can be problems with some old (pre 2006) barcode scaners.
1. **ExtendedCodetext** - encode codetext in Extended Channel mode which supports FNC1 first position, FNC1 second position and multi ECI modes.
### **The Enum ECIEncodings is added**
Description of the new Enum ECIEncodings:

1. **ISO_8859_1** - ISO/IEC 8859-1 Latin alphabet No. 1 encoding. ECI Id:"\000003".
1. **ISO_8859_2** - ISO/IEC 8859-2 Latin alphabet No. 2 encoding. ECI Id:"\000004".
1. **ISO_8859_3** - ISO/IEC 8859-3 Latin alphabet No. 3 encoding. ECI Id:"\000005".
1. **ISO_8859_4** - ISO/IEC 8859-4 Latin alphabet No. 4 encoding. ECI Id:"\000006".
1. **ISO_8859_5** - ISO/IEC 8859-5 Latin/Cyrillic alphabet encoding. ECI Id:"\000007".
1. **ISO_8859_6** - ISO/IEC 8859-6 Latin/Arabic alphabet encoding. ECI Id:"\000008".
1. **ISO_8859_7** - ISO/IEC 8859-7 Latin/Greek alphabet encoding. ECI Id:"\000009".
1. **ISO_8859_8** - ISO/IEC 8859-8 Latin/Hebrew alphabet encoding. ECI Id:"\000010".
1. **ISO_8859_9** - ISO/IEC 8859-9 Latin alphabet No. 5 encoding. ECI Id:"\000011".
1. **ISO_8859_10** - ISO/IEC 8859-10 Latin alphabet No. 6 encoding. ECI Id:"\000012".
1. **ISO_8859_11** - ISO/IEC 8859-11 Latin/Thai alphabet encoding. ECI Id:"\000013".
1. **ISO_8859_13** - ISO/IEC 8859-13 Latin alphabet No. 7 (Baltic Rim) encoding. ECI Id:"\000015".
1. **ISO_8859_14** - ISO/IEC 8859-14 Latin alphabet No. 8 (Celtic) encoding. ECI Id:"\000016".
1. **ISO_8859_15** - ISO/IEC 8859-15 Latin alphabet No. 9 encoding. ECI Id:"\000017".
1. **ISO_8859_16** - ISO/IEC 8859-16 Latin alphabet No. 10 encoding. ECI Id:"\000018".
1. **Shift_JIS** - Shift JIS (JIS X 0208 Annex 1 + JIS X 0201) encoding. ECI Id:"\000020".
1. **Win1250** - Windows 1250 Latin 2 (Central Europe) encoding. ECI Id:"\000021".
1. **Win1251** - Windows 1251 Cyrillic encoding. ECI Id:"\000022".
1. **Win1252** - Windows 1252 Latin 1 encoding. ECI Id:"\000023".
1. **Win1256** - Windows 1256 Arabic encoding. ECI Id:"\000024".
1. **UTF16BE** - ISO/IEC 10646 UCS-2 (High order byte first) encoding. ECI Id:"\000025".
1. **UTF8** - ISO/IEC 10646 UTF-8 encoding. ECI Id:"\000026".
1. **US_ASCII** - ISO/IEC 646:1991 International Reference Version of ISO 7-bit coded character set encoding. ECI Id:"\000027".
1. **Big5** - Big 5 (Taiwan) Chinese Character Set encoding. ECI Id:"\000028".
1. **GB18030** - GB (PRC) Chinese Character Set encoding. ECI Id:"\000029".
1. **EUC_KR** - Korean Character Set encoding. ECI Id:"\000030".
### **The Class QrExtCodetextBuilder is added**
Description of the new Enum QrExtCodetextBuilder:

- **Clear()** method - clears extended codetext items.
- **AddPlainCodetext(System.String)** method - adds plain codetext to the extended codetext items.
- **AddECICodetext(Aspose.BarCode.ECIEncodings,System.String)** method - Adds codetext with Extended Channel Identifier.
- **AddFNC1FirstPosition()** method - adds FNC1 in first position to the extended codetext items.
- **AddFNC1SecondPosition(System.String)** method - adds FNC1 in second position to the extended codetext items.
- **AddFNC1GroupSeparator()** method - Adds Group Separator (GS - '\u001D') to the extended codetext items.
- **GetExtendedCodetext()** method - generates extended codetext from generation items list.
