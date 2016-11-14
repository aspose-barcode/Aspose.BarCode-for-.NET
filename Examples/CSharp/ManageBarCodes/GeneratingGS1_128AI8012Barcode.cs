using System.IO;
using Aspose.BarCode;
using Aspose.BarCode.Generation;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GeneratingGS1_128AI8012Barcode
    {
        public static void Run()
        {
            // ExStart:GeneratingGS1_128AI8012Barcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder class.
            BarCodeBuilder b = new BarCodeBuilder();

            // Specify code text and set encode type.
            b.CodeText = "(8012)ABC123";            
            b.EncodeType = EncodeTypes.GS1Code128;

            // Save the image to disk in PNG format
            b.BarCodeImage.Save("AI8012_out.png");
            // ExEnd:GeneratingGS1_128AI8012Barcode
        }
    }
}
