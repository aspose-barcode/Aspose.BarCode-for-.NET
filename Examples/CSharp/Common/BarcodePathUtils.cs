//Copyright(c) 2001-2021 Aspose Pty Ltd.All rights reserved.
using System;
using System.IO;

namespace Aspose.BarCode.Examples.CSharp
{
    internal class BarcodePathUtils
    {
        public static string GetDataDir_Data_Output(params string[] folders)
        {
            string res = Path.GetFullPath(GetDataDir_Data_Output());
            for (int i = 0; i < folders.Length; ++i)
            {
                res = Path.GetFullPath(res + $"{folders[i]}/");
                if (!Directory.Exists(res))
                    Directory.CreateDirectory(res);
            }
            return res;
        }

        public static string GetDataDir_Data_Output()
        {
            string res = Path.GetFullPath(GetDataDir_Data() + "output/");
            if (!Directory.Exists(res))
                Directory.CreateDirectory(res);
            return res;
        }
        
        public static string GetDataDir_Folders(params string[] folders)
        {
            string res = Path.GetFullPath(GetDataDir_Data());
            for (int i = 0; i < folders.Length; ++i)
            {
                res = Path.GetFullPath(res + $"{folders[i]}/");
                if (!Directory.Exists(res))
                    Directory.CreateDirectory(res);
            }
            return res;
        }

        protected static string GetDataDir_Data()
        {
            string exePath = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //depends from exe path, currently in "build\$(Configuration)"
            string dataPath = Path.GetFullPath(Path.Combine(exePath, "../../Data/"));
            if (!Directory.Exists(dataPath))
                throw new SystemException($"{dataPath} is not exists.");
            return dataPath;
        }
    }
}