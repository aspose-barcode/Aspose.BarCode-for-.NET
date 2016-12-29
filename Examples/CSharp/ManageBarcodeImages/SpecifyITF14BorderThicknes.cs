using System.Drawing;
using Aspose.BarCode.Generation;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https://docs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http://www.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http://www.aspose.com/community/forums/default.aspx
*/
namespace Aspose.BarCode.Examples.CSharp.ManageBarCodeImages
{
    class SpecifyITF14BorderThicknes
    {
        public static void Run()
        {
            // ExEnd:SpecifyITF14BorderThicknes                       
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodesImages();

            // Instantiate barcode object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("00850006000227", EncodeTypes.ITF14)
            {
                // Set Different Properties
                AutoSize = true,
                ITF14BorderType = ITF14BorderType.BarOut,
                CodeTextFont = new Font("OCR B Std", 8.0f),
                GraphicsUnit = GraphicsUnit.Millimeter,
                xDimension = 0.495f,
                BarHeight = 12.7f,
                CodeTextSpace = 0.5f,
                Resolution = new Resolution(1200.0f, 1200.0f, ResolutionMode.Customized)
            };
            barCodeBuilder.Save(dataDir + "ITF14_Border_TypeBar_Out.png", BarCodeImageFormat.Png);
            // ExEnd:SpecifyITF14BorderThicknes                       
        }
    }
}