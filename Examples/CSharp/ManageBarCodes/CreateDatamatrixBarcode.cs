using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CreateDatamatrixBarcode
    {
        public static void Run()
        {
            //ExStart:CreateDatamatrixBarcode
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();

            // Instantiate BarCodeBuilder object
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder();

            // Set the SymbologyType for the barcode
            barCodeBuilder.SymbologyType =  Symbology.DataMatrix;

            // Set the CodeText for the barcode
            barCodeBuilder.CodeText = "1234567890";

            // Save file to disk
            barCodeBuilder.Save(dataDir + "datamatrix-barcode_out.jpg", BarCodeImageFormat.Jpeg);
            //ExEnd:CreateDatamatrixBarcode

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dataDir + "datamatrix-barcode_out.jpg");
        }
    }
}
