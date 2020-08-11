---
title: 1D Barcodes with Optional Exception Message  in Case of Wrong Code Text
type: docs
weight: 140
url: /net/1d-barcodes-with-optional-exception-message-in-case-of-wrong-code-text/
---

The barcode generator Parameter's ThrowExceptionWhenCodeTextIncorrect property is only used for 1D barcodes. It allows developers to choose what happens if the code text used when generating a barcode is not valid. There are two choices:

- Filter the code text and generate with allowed chars.
- Throw an exception.

If the code text is incorrect and the value for the ThrowExceptionWhenCodeTextIncorrect property is set to true, an exception is thrown. Otherwise, the code text is corrected to match the barcode's specifications. An exception is always thrown for the Databar symbology if code text is incorrect. An exception is never thrown for AustraliaPost, SingapurePost, Code39Extended, Code93Extended, Code16K, Code128 symbologies, even if the code text is incorrect.
#### **C#**
{{< gist "aspose-com-gists" "f801733f5eb53b0777dd38da9db8366a" "Examples-CSharp-ManageBarCodes-OptionalExceptionMessageWith1DBarCode-OptionalExceptionMessageWith1DBarCode.cs" >}}
