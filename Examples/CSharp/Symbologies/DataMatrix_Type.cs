//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.Symbologies
{
    internal class DataMatrix_Type : SymbologyBase
    {
		public static void Run()
        {
            string path = GetFolder();
            Console.OutputEncoding = Encoding.Unicode;
            //generate DataMatrix Barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.DataMatrix, "Åspóse.Barcóde©"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                //set DataMatrix Ecc to 200
                gen.Parameters.Barcode.DataMatrix.DataMatrixEcc = DataMatrixEccType.Ecc200;
                //set rows 22 columns 22
                gen.Parameters.Barcode.DataMatrix.Columns = 22;
                gen.Parameters.Barcode.DataMatrix.Rows = 22;
                gen.Save($"{path}DataMatrix.png", BarCodeImageFormat.Png);
            }

            Console.WriteLine("DataMatrix_Type:");
            //recognize DataMatrix Barcode
            using (BarCodeReader read = new BarCodeReader($"{path}DataMatrix.png", DecodeType.DataMatrix))
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
        }
	}
}