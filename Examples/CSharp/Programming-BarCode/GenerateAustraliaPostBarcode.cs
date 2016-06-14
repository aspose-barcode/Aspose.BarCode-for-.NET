using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.Programming.BarCode
{
    class GenerateAustraliaPostBarcode
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();

            // Set codetext
            string codeText = "12345678";

            // Initialize BarCodeBuilder
            BarCodeBuilder builder = new BarCodeBuilder(codeText, Symbology.AustraliaPost);

            // Set format control code to standard
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Standard;
            // Save the image to disk in PNG format
            builder.Save(dataDir + "AustraliaPost-Standard.png");

            // Set format control code to ReplyPaid
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.ReplyPaid;
            // Save the image to disk in PNG format
            builder.Save(dataDir + "AustraliaPost-ReplyPaid.png");

            // Set format control code to Customer2
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer2;
            // Save the image to disk in PNG format
            builder.Save(dataDir + "AustraliaPost-Customer2.png");

            // Set format control code to Customer3
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer3;
            // Save the image to disk in PNG format
            builder.Save(dataDir + "AustraliaPost-Customer3.png");

            // Set format control code to Routing
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Routing;
            // Save the image to disk in PNG format
            builder.Save(dataDir + "AustraliaPost-Routing.png");

            // Set format control code to Redirection
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Redirection;
            // Save the image to disk in PNG format
            builder.Save(dataDir + "AustraliaPost-Redirection.png");

            Console.WriteLine(Environment.NewLine + "AustraliaPost Barcodes saved at " + dataDir);
        }
    }
}
