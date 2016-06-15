using System.IO;
using Aspose.BarCode;
using System;

namespace Aspose.BarCode.Examples.CSharp.Programming.BarCode
{
    class SetQRErrorCorrection
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ProgrammingBarCode();
            string dst = dataDir + "QR-error-correction.jpg";

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            Aspose.BarCode.BarCodeBuilder builder;
            builder = new Aspose.BarCode.BarCodeBuilder();
            builder.SymbologyType = Aspose.BarCode.Symbology.QR;
            builder.QRErrorLevel = QRErrorLevel.LevelH;
            builder.CodeText = "1234567890";
            builder.Save(dst, BarCodeImageFormat.Jpeg);

            Console.WriteLine(Environment.NewLine + "Barcode saved at " + dst);
        }
    }
}
