using System;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://Docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class SetWideNarrowRatio
    {
        public static void Run()
        {
            // ExStart:SetWideNarrowRatio
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Set the symbology and code text.
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("blackReduction", EncodeTypes.Code128)
            {
                // Set X dimension reduction property of barcode and save barcode Image
                xDimension = 1.2f,
                BarWidthReduction = 0.2f
            };           
            barCodeBuilder.Save(dataDir + "SetWideNarrowRatio_out.png");
            // ExEnd:SetWideNarrowRatio
        }
    }
}