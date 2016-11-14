using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CodabarStartStopSymbols
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("11112222333344", EncodeTypes.Codabar)
            {
                // Set the codabar start symbol to A and stop symbol to D
                CodabarStartSymbol = CodabarSymbol.A,
                CodabarStopSymbol = CodabarSymbol.D
            };           
            builder.Save(dataDir + "Coabar-start-stop-symbols_out.png");
        }
    }
}