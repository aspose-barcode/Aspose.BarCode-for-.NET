//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System.IO;
using Aspose.BarCode.Generation;

namespace Aspose.BarCode.Examples.CSharp.Serialization
{
    internal class BarcodeGeneratorStreamSerialization : SerializationBase
    {
		public static void Run()
        {
            string path = GetFolder();
            System.Console.WriteLine("BarcodeGeneratorStreamSerialization:");

            BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.QR, "Åspóse.Barcóde©");
            gen.Parameters.Barcode.XDimension.Pixels = 4;

            //store to Stream
            MemoryStream ms = new MemoryStream();
            gen.ExportToXml(ms);
            ms.Position = 0;

            //load from stream
            gen = BarcodeGenerator.ImportFromXml(ms);
            //generate loaded
            gen.Save($"{path}BarcodeGeneratorFromStream.png", BarCodeImageFormat.Png);
        }
	}
}