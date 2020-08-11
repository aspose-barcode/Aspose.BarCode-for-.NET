---
title: Public API Changes in Aspose.BarCode 6.6.0
type: docs
weight: 20
url: /net/public-api-changes-in-aspose-barcode-6-6-0/
---

{{% alert color="primary" %}} 

This document describes changes to the Aspose.BarCode API from version 6.1.0 to 6.6.0, that may be of interest to module/application developers. It includes not only new and updated public methods, but also a description of any changes in the behavior behind the scenes in Aspose.BarCode. 

{{% /alert %}} 
### **Property Aspose.BarCode.BarCodeBuilder.Rows is updated**
Updated property Aspose.BarCode.BarCodeBuilder.Rows. Now this property allows to specify number of rows for new symbology DatabarExpandedStacked. If setting is illegal then rows will be calculated automatically.

{{< highlight java >}}

 BarCodeBuilder builder = new BarCodeBuilder(

    "(01)90012345678908(3932)04066USD778899",

    Symbology.DatabarExpandedStacked);

builder.Rows = 1;

builder.Save("stacked1Rows.png");

{{< /highlight >}}
### **Property Aspose.BarCode.Symbology.DatabarExpandedStacked is added**
It specifies that the data should be encoded with Databar expanded stacked barcode specification.

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder("(01)90012345678908(3932)04055GBP", Symbology.DatabarExpandedStacked))

{

    builder.Save("databarexpandedstacked.png");

}

{{< /highlight >}}
### **Property Aspose.BarCode.Symbology.DatabarStacked is added**
It specifies that the data should be encoded with Databar stacked barcode specification.

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder("(01)00012345678905", Symbology.DatabarStacked))

{

    builder.Save("databarstacked.png");

}

{{< /highlight >}}
### **Property Aspose.BarCode.Symbology.DatabarStackedOmniDirectional is added**
It specifies that the data should be encoded with Databar stacked omni-directional barcode specification.

{{< highlight java >}}

 using (BarCodeBuilder builder = new BarCodeBuilder("(01)00034567890125", Symbology.DatabarStackedOmniDirectional))

{

    builder.Save("databarstackedomnidirectional.png");

}

{{< /highlight >}}
### **Property Aspose.BarCodeRecognition.BarCodeReadType.DatabarExpandedStacked is added**
Added support for Databar expanded stacked recognition.

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("databarexpandedstacked.png", BarCodeReadType.DatabarExpandedStacked))

{

    if (reader.Read())

    {

        Console.WriteLine(reader.GetCodeText());

    }

}

{{< /highlight >}}
### **Property Aspose.BarCodeRecognition.BarCodeReadType.DatabarStacked is added**
Added support for Databar stacked recognition.

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("databarstacked.png", BarCodeReadType.DatabarStacked))

{

    if (reader.Read())

    {

        Console.WriteLine(reader.GetCodeText());

    }

}

{{< /highlight >}}
### **Property Aspose.BarCodeRecognition.BarCodeReadType.DatabarStackedOmniDirectional is added**
Added support for Databar stacked omni-directional recognition.

{{< highlight java >}}

 using (BarCodeReader reader = new BarCodeReader("databarstackedomnidirectional.png", BarCodeReadType.DatabarStackedOmniDirectional))

{

    if (reader.Read())

    {

        Console.WriteLine(reader.GetCodeText());

    }

}

{{< /highlight >}}
