using System.IO;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Text;
using Aspose.BarCode.BarCodeRecognition;
using Aspose.BarCode;

/*
This project uses Automatic Package Restore feature of NuGet to resolve Aspose.BarCode for .NET API reference 
when the project is build. Please check https:// ocs.nuget.org/consume/nuget-faq for more information. 
If you do not wish to use NuGet, you can manually download Aspose.BarCode for .NET API from http:// ww.aspose.com/downloads, 
install it and then add its reference to this project. For any issues, questions or suggestions 
please feel free to contact us using http:// ww.aspose.com/community/forums/default.aspx
*/

namespace Aspose.BarCode.Examples.CSharp.CreateAndManageTwoDBarcodes
{
    class CreateMultipleMacroPdf417
    {
        public static void Run()
        {
            // The path to the documents directory.
            string dataDir = RunExamples.GetDataDir_CreateAndManage2DBarCodes();

            //ExStart:CreateMultipleMacroPdf417
            // create array for storing multiple barcodes
            const int nSize = 4;
            string[] lstCodeText = new[] { "code-1", "code-2", "code-3", "code-4" };
            const int strFileId = 1;

            // create instance of BarCodeBuilder class and set symbology
            using (BarCodeBuilder builder = new BarCodeBuilder())
            {
                for (int nCount = 1; nCount <= nSize; nCount++)
                {
                    builder.SymbologyType = Symbology.MacroPdf417;
                    builder.CodeText = lstCodeText[nCount - 1];

                    // fileID should be same for all the generated bar codes
                    builder.MacroPdf417FileID = strFileId;
                    // assign segmentID in increasing order (1,2,3,....)
                    builder.MacroPdf417SegmentID = nCount;
                    // set the segments count
                    builder.MacroPdf417SegmentsCount = nSize;

                    // save the barcode (fileid_segmentid.png)
                    builder.Save(dataDir + strFileId + "_" + nCount + "_out.png", ImageFormat.Png);
                    Process.Start(dataDir + strFileId + "_" + nCount + "_out.png");
                }
            }
            //ExEnd:CreateMultipleMacroPdf417 

        }
    }
}
