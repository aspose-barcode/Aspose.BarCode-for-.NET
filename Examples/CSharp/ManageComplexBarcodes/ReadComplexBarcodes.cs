using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode.ComplexBarcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aspose.BarCode.Examples.CSharp.ManageComplexBarcodes
{
    class ReadComplexBarcodes
    {
        public static void Run()
        {
            try
            {
                // ExStart:ReadComplexBarcodes
                // The path to the documents directory.
                string dataDir = RunExamples.GetDataDir_ManageComplexBarcodes();

                using (var reader = new BarCodeReader(dataDir + "swissQRCodetext_out.png", DecodeType.QR))
                {
                    foreach (BarCodeResult barcodeResult in reader.ReadBarCodes())
                    {
                        SwissQRCodetext result = ComplexCodetextReader.TryDecodeSwissQR(barcodeResult.CodeText);
                        Console.WriteLine("Account :" + result.Bill.Account);
                        Console.WriteLine("BillInformation = " + result.Bill.BillInformation);
                        Console.WriteLine("Currency :" + result.Bill.Currency);
                    }
                }
                // ExEnd:ReadComplexBarcodes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "\nThis example will only work if you apply a valid Aspose BarCode License. You can purchase full license or get 30 day temporary license from http://wwww.aspose.com/purchase/default.aspx.");
            }
        }
    }
}
