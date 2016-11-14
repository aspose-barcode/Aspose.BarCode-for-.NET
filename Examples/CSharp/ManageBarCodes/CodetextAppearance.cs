using System.IO;
using Aspose.BarCode;
using System;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.ManageBarCodes
{
    class CodetextAppearance
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_ManageBarCodes();
            string dst = dataDir + "codetext-appearence_out.jpg";

            // Set the symbology type to Code128
            BarCodeBuilder barCodeBuilder = new BarCodeBuilder("1234567", EncodeTypes.Code128)
            {
                // set differnt barcode properties
                CodeTextAlignment = System.Drawing.StringAlignment.Center,
                CodeLocation = CodeLocation.Above,
                CodeTextColor = System.Drawing.Color.Red,
                CodeTextSpace = 1.0f
            };          
            barCodeBuilder.Save(dst, System.Drawing.Imaging.ImageFormat.Jpeg);
        }
    }
}