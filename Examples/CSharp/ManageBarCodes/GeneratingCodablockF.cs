using System.IO;
using Aspose.BarCode;
using Aspose.BarCode.Generation;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GeneratingCodablockF
    {
        public static void Run()
        {
            // ExStart:GeneratingCodablockF
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder class.
            BarCodeBuilder b = new BarCodeBuilder();

            // Specify code text and set encode type.
            b.CodeText = "CODABLOCKF 01234567890123456789012digits";           
            b.EncodeType = EncodeTypes.CodablockF;

            // Save the image to disk in PNG format
            b.BarCodeImage.Save("CodablockF_out.png");
            // ExEnd:GeneratingCodablockF
        }
    }
}
