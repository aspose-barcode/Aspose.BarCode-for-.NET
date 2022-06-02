//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.KnowledgeBase
{
    internal class ReadBarcodesFromMultiPageTIFFWithAsposeImaging: ReadBarcodesFromMultiPageTIFFBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            Console.WriteLine("ReadBarcodesFromMultiPageTIFFWithAsposeImaging:");

            //open required image
            using (Aspose.Imaging.Image openImage = Aspose.Imaging.Image.Load($"{path}MultiPageTiffWithBarcodes.tiff"))
            {
                //cast it as multipage tiff
                Aspose.Imaging.FileFormats.Tiff.TiffImage tiffImage = openImage as Aspose.Imaging.FileFormats.Tiff.TiffImage;
                if (null == tiffImage) return;

                //proceed each tiff frame
                foreach(Aspose.Imaging.FileFormats.Tiff.TiffFrame tiffFrame in tiffImage.Frames)
                {
                    //save tiff frame to the stream as png
                    MemoryStream ms = new MemoryStream();
                    tiffFrame.Save(ms, new Aspose.Imaging.ImageOptions.PngOptions());
                    ms.Position = 0;

                    //recognize Pdf417, QR, DataMatrix and Aztec barcode types from rendered image of the page
                    BarCodeReader reader = new BarCodeReader(ms, DecodeType.Pdf417, DecodeType.QR, DecodeType.DataMatrix, DecodeType.Aztec);
                    foreach (BarCodeResult result in reader.ReadBarCodes())
                        Console.WriteLine($"Barcode type:{result.CodeTypeName}, Barcode Data:{result.CodeText}");
                }
            }
        }
	}
}