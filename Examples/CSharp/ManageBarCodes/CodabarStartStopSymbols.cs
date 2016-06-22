using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CodabarStartStopSymbols
    {
        public static void Run()
        {
            //ExStart:CodabarStartStopSymbols
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
 
            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("11112222333344", Symbology.Codabar);

            // Set the codabar start symbol to A
            builder.CodabarStartSymbol = CodabarSymbol.A;

            // Set the codabar stop symbol to D
            builder.CodabarStopSymbol = CodabarSymbol.D;

            // Save the image to disk in PNG format
            builder.Save(dataDir + "Coabar-start-stop-symbols_out.png");
            //ExEnd:CodabarStartStopSymbols
        }
    }
}
