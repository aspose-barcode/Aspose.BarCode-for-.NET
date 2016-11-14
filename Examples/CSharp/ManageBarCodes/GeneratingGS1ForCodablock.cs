using System.IO;
using Aspose.BarCode;
using Aspose.BarCode.Generation;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GeneratingGS1ForCodablock
    {
        public static void Run()
        {
            // ExStart:GeneratingGS1ForCodablock
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder class.
            BarCodeBuilder b = new BarCodeBuilder();

            // Specify code text and set encode type.
            b.CodeText = "(01)03412345678900(17)010200";
            b.EncodeType = EncodeTypes.GS1CodablockF;

            // Save the image to disk in PNG format
            b.BarCodeImage.Save("GS1CodablockF_out.png");
            // ExEnd:GeneratingGS1ForCodablock
        }
    }
}
