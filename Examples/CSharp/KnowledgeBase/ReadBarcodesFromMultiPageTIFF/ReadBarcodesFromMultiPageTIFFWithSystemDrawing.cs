//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.IO;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.KnowledgeBase
{
    internal class ReadBarcodesFromMultiPageTIFFWithSystemDrawing: ReadBarcodesFromMultiPageTIFFBase
    {
		public static void Run()
        {
            string path = GetReadFolder();
            Console.WriteLine("ReadBarcodesFromMultiPageTIFFWithSystemDrawing:");

            //open required image
            using (System.Drawing.Image tiffImage = System.Drawing.Image.FromFile($"{path}MultiPageTiffWithBarcodes.tiff"))
            {
                //get frame count
                int tiffFrameCount = tiffImage.GetFrameCount(System.Drawing.Imaging.FrameDimension.Page);
                
                //proceed each tiff frame
                for (int i = 0; i < tiffFrameCount; i++)
                {
                    //select active frame
                    tiffImage.SelectActiveFrame(System.Drawing.Imaging.FrameDimension.Page, i);
                    
                    //save tiff frame to the stream as png
                    MemoryStream ms = new MemoryStream();
                    tiffImage.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
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