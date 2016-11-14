using System;
using System.Drawing.Imaging;
using Aspose.BarCode;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class UseEncodeModeDatamatrixbarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            string gtin = "898978777776665655";
            string uid = "121212121212121212";
            string batch = "GH768";
            string expDate = "150923";

            string textToEncode = gtin + uid + batch + expDate; // or  "(01)"+ gtin + "(..)"+ uid + ...
            string textToDisplay = "GTIN:" + gtin + "\nUID:" + uid + "\nBatch:" + batch + "\nExp.Date:" + expDate;

            // Instantiate barcode object            
            BarCodeBuilder builder = new BarCodeBuilder("textToEncode", EncodeTypes.DataMatrix);

            // n order to avoid including all the names into the codetext, the property called "Display2DText" should be used.
            builder.Display2DText = textToDisplay;
            builder.CodeLocation = CodeLocation.Right;
            builder.Margins = new MarginsF(0, 0, 0, 0);
          
            // builder.CodeTextSpace = 0; // not recommended small space

            // Save the Barcode image
            builder.Save(dataDir + "codetextRightDisplay_out.png" , BarCodeImageFormat.Png);
        }
    }
}

