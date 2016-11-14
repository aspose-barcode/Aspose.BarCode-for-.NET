using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GenerateAustraliaPostBarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Set codetext
            string codeText = "1159628792";

            // Initialize BarCodeBuilder
            BarCodeBuilder builder = new BarCodeBuilder(codeText, EncodeTypes.AustraliaPost);

            // Set format control code to standard
            builder.Save(dataDir + "AustraliaPost-Standard_out.png");            
        }
    }
}
