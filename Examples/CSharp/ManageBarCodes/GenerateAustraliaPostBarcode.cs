using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class GenerateAustraliaPostBarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Set codetext
            string codeText = "12345678";

            // Initialize BarCodeBuilder
            BarCodeBuilder builder = new BarCodeBuilder(codeText, Symbology.AustraliaPost);

            // Set format control code to standard
            builder.CodeText = "1111111111";
            builder.Save(dataDir + "AustraliaPost-Standard_out.png");

            // Set format control code to ReplyPaid
            builder.CodeText = "4545454545";
            builder.Save(dataDir + "AustraliaPost-ReplyPaid_out.png");

            // Set format control code to Customer2
            builder.CodeText = "5959595959";
            builder.Save(dataDir + "AustraliaPost-Customer2_out.png");

            // Set format control code to Customer3
            builder.CodeText = "6262626262";
            builder.Save(dataDir + "AustraliaPost-Customer3_out.png");

            // Set format control code to Routing
            builder.CodeText = "8787878787";
            builder.Save(dataDir + "AustraliaPost-Routing_out.png");

            // Set format control code to Redirection
            builder.CodeText = "9292929292";
            // Save the image to disk in PNG format
            builder.Save(dataDir + "AustraliaPost-Redirection_out.png");
        }
    }
}
