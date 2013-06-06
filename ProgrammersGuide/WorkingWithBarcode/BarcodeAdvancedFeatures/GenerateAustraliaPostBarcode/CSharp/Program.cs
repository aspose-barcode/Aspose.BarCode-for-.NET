//////////////////////////////////////////////////////////////////////////
// Copyright 2001-2013 Aspose Pty Ltd. All Rights Reserved.
//
// This file is part of Aspose.BarCode. The source code in this file
// is only intended as a supplement to the documentation, and is provided
// "as is", without warranty of any kind, either expressed or implied.
//////////////////////////////////////////////////////////////////////////
using System.IO;

using Aspose.BarCode;

namespace GenerateAustraliaPostBarcode
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // The path to the documents directory.
            string dataDir = Path.GetFullPath("../../../Data/");

            // Create instance of BarCodeBuilder, specify codetext and symbology in the constructor
            BarCodeBuilder builder = new BarCodeBuilder("12345678", Symbology.AustraliaPost);

            // Set format control code to standard
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Standard;

            // Save the image to disk in PNG format
            builder.Save(dataDir + "Standard.png");

            // Set format control code to ReplyPaid
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.ReplyPaid;

            // Save the image to disk in PNG format
            builder.Save(dataDir + "ReplyPaid.png");

            // Set format control code to Customer2
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer2;

            // Save the image to disk in PNG format
            builder.Save(dataDir + "Customer2.png");

            // Set format control code to Customer3
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Customer3;

            // Save the image to disk in PNG format
            builder.Save(dataDir + "Customer3.png");

            // Set format control code to Routing
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Routing;

            // Save the image to disk in PNG format
            builder.Save(dataDir + "Routing.png");

            // Set format control code to Redirection
            builder.AustraliaPostFormatControlCode = AustraliaPostFormatControlCode.Redirection;

            // Save the image to disk in PNG format
            builder.Save(dataDir + "Redirection.png");

        }
    }
}