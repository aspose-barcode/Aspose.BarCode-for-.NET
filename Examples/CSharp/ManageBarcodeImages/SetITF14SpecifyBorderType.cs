using System;
using System.Drawing;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SetITF14SpecifyBorderType
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("00850006000227");
            barCodeBuilder.AutoSize = true;

            // Set Barcode Symbology
            barCodeBuilder.SymbologyType = Symbology.ITF14;

            // Set ITF14 Barcode Border Type
            barCodeBuilder.ITF14BorderType = ITF14BorderType.BarOut;

            // Set Font
            barCodeBuilder.CodeTextFont = new Font("OCR B Std", 8.0f);

            // Set Measuring Units
            barCodeBuilder.GraphicsUnit = GraphicsUnit.Millimeter;

            // Set xDimension
            barCodeBuilder.xDimension = 0.495f;

            // Set Bars Height
            barCodeBuilder.BarHeight = 12.7f;

            // specify space between characters
            barCodeBuilder.CodeTextSpace = 0.5f;

            // Define resolution and its mode
            barCodeBuilder.Resolution = new Resolution(1200.0f, 1200.0f, ResolutionMode.Customized);

            // Save the Barcode image
            barCodeBuilder.Save(dataDir + "ITF14_Border_Type_BarOut.png", BarCodeImageFormat.Png);
        }
    }
}

