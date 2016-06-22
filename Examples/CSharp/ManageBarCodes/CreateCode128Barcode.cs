
using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateCode128Barcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Set codetext
            string codeText = "1234";

            // Initialize BarCodeBuilder
            BarCodeBuilder builder = new BarCodeBuilder(codeText, Symbology.Code128);

            // Code128 type handles Code A, B and C character sets automatically
            
            // Save the image to disk in PNG format
            builder.Save(dataDir + "Code128-customized_out.png");

        }
    }
}
