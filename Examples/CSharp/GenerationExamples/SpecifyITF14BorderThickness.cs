using System.Drawing;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.GenerationExamples
{
    class SpecifyITF14BorderThickness
    {
        public static void Run()
        {
            // ExStart:SpecifyITF14BorderThickness                       
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_Generation();

            // Instantiate barcode object
            BarcodeGenerator  generator = new BarcodeGenerator(EncodeTypes.ITF14, "00850006000227");

            // Set ITF Barcode Border Type
            generator.Parameters.Barcode.ITF.ItfBorderType = ITF14BorderType.FrameOut;

            // Set ITF Barcode Border Thickness
            generator.Parameters.Barcode.ITF.ItfBorderThickness.Point = 1;

            // Set Font
            generator.Parameters.Barcode.CodeTextParameters.Font.FamilyName = "OCR B Std";
            generator.Parameters.Barcode.CodeTextParameters.Font.Size.Point = 8;

            // Set xDimension
            generator.Parameters.Barcode.XDimension.Millimeters = 0.495f;

            // Set Bars Height
            generator.Parameters.Barcode.BarHeight.Millimeters = 12.7f;

            // Specify space between characters
            generator.Parameters.Barcode.CodeTextParameters.Space.Millimeters = 0.5f;

            // Define resolution
            generator.Parameters.Resolution = 1200.0f;

            generator.Save(dataDir + "ITF14_Border_Thickness_Out.png", BarCodeImageFormat.Png);
            // ExEnd:SpecifyITF14BorderThickness                       
        }
    }
}