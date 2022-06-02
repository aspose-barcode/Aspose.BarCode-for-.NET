//Copyright(c) 2001-2022 Aspose Pty Ltd.All rights reserved.
//https://github.com/aspose-barcode/Aspose.BarCode-for-.NET
using System;
using System.Text;
using Aspose.BarCode.Generation;
using Aspose.BarCode.BarCodeRecognition;

namespace Aspose.BarCode.Examples.CSharp.BarcodeRecognition
{
    internal class ReadAustraliaPostCustomerInformationDecoder : ReadDecodingBase
    {
        protected class NTableDecoder : AustraliaPostCustomerInformationDecoder
        {
            string[] N_Table = { "00", "01", "02", "10", "11", "12", "20", "21", "22", "30" };
            public string Decode(string customerInformationField)
            {
                StringBuilder bd = new StringBuilder();
                for (int i = 0; i < customerInformationField.Length; i += 2)
                {
                    if (i + 2 <= customerInformationField.Length)
                    {
                        string tmp = customerInformationField.Substring(i, 2);
                        for (int j = 0; j < N_Table.Length; j++)
                        {
                            if (N_Table[j].Equals(tmp))
                            {
                                bd.Append(j);
                                break;
                            }
                        }
                    }
                }
                return bd.ToString();
            }
        }

        public static void Run()
        {
            string path = GetFolder();

            //create barcode
            using (BarcodeGenerator gen = new BarcodeGenerator(EncodeTypes.AustraliaPost, "620123456701234"))
            {
                gen.Parameters.Barcode.XDimension.Pixels = 4;
                gen.Parameters.Barcode.BarHeight.Pixels = 50;
                gen.Parameters.Barcode.AustralianPost.AustralianPostEncodingTable = CustomerInformationInterpretingType.NTable;
                gen.Save($"{path}AustraliaPostCustomerInformationDecoder.png", BarCodeImageFormat.Png);
            }

            //recognize image
            Console.WriteLine("ReadAustraliaPostCustomerInformationDecoder:");
            using (BarCodeReader read = new BarCodeReader($"{path}AustraliaPostCustomerInformationDecoder.png", DecodeType.AustraliaPost))
            {
                read.BarcodeSettings.AustraliaPost.CustomerInformationDecoder = new NTableDecoder();
                foreach (BarCodeResult result in read.ReadBarCodes())
                {
                    Console.WriteLine($"CodeType:{result.CodeTypeName}");
                    Console.WriteLine($"CodeText:{result.CodeText}");
                }
            }
        }
	}
}