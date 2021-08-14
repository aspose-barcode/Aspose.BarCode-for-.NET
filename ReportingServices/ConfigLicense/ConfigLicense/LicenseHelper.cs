// Copyright (c) 2001-2021 Aspose Pty Ltd. All Rights Reserved.
using System;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Security.Principal;
using System.Collections.Generic;
using System.Security.AccessControl;

namespace ConfigLicense
{
    class LicenseHelper
    {
        protected static string MainNode = @"Software";
        protected static string WOW6432Node = @"Software\WOW6432Node";
        protected static string registryAsposeNode = @"Aspose\SSRS\License";

        internal static bool CheckAccessAllowed(RegistryKey root, bool showMessage)
        {
            List<Exception> exceptions = new List<Exception>();
            bool unauthorizedAccess = false;

            try
            {
                GetLicenseKey(root, false);
            }
            catch(UnauthorizedAccessException e)
            {
                unauthorizedAccess = true;
            }
            catch (Exception e)
            {
                exceptions.Add(e);
            }

            try
            {
                GetLicenseKey(root, true);
            }
            catch (UnauthorizedAccessException e)
            {
                unauthorizedAccess = true;
            }
            catch (Exception e)
            {
                exceptions.Add(e);
            }

            if (showMessage)
            {
                if (unauthorizedAccess)
                    MessageBox.Show("Can't access to registry. Try use other settings.", "Access Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (0 < exceptions.Count)
                    {
                        string msg = "";
                        foreach (Exception e in exceptions)
                            msg += e.Message;
                        MessageBox.Show(msg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            return !unauthorizedAccess && (exceptions.Count <= 0);
        }

        internal static List<string> GetLicensesList(RegistryKey root)
        {
            List<string> res = GetLicensesList(root, false);
            List<string> Wow64List = GetLicensesList(root, true);

            for (int i = 0; i < Wow64List.Count; ++i)
                if (!IsLicenseInList(res, Wow64List[i]))
                    res.Add(Wow64List[i]);

            res.Sort();
            return res;
        }

        internal static bool IsLicenseExists(RegistryKey root, string licenseName)
        {
            List<string> licenses = GetLicensesList(root);
            return IsLicenseInList(licenses, licenseName);
        }

        internal static void AddLicense(RegistryKey root, string licenseName, byte[] data)
        {
            AddLicense(root, licenseName, data, false);
            AddLicense(root, licenseName, data, true);
        }

        internal static void DeleteLicense(RegistryKey root, string licenseName)
        {
            DeleteLicense(root, licenseName, false);
            DeleteLicense(root, licenseName, true);
        }

        internal static void DeleteAllLicenses(RegistryKey root)
        {
            DeleteAllLicenses(root, false);
            DeleteAllLicenses(root, true);
        }

        internal static byte[] LoadFile(string FileName, int MaxSize)
        {
            byte[] res;

            using (Stream stream = new FileStream(FileName, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(stream))
                res = reader.ReadBytes(MaxSize);

            return res;
        }

        private static void DeleteAllLicenses(RegistryKey root, bool wow6432Node)
        {
            try
            {
                RegistryKey key = GetLicenseKey(root, wow6432Node);
                if (null == key) return;
                string[] values = key.GetValueNames();
                foreach (string val in values)
                    key.DeleteValue(val, false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void DeleteLicense(RegistryKey root, string licenseName, bool wow6432Node)
        {
            try
            {
                RegistryKey key = GetLicenseKey(root, wow6432Node);
                if (null == key) return;
                key.DeleteValue(licenseName, false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddLicense(RegistryKey root, string licenseName, byte[] data, bool wow6432Node)
        {
            try
            {
                RegistryKey key = GetLicenseKey(root, wow6432Node);
                if (null == key) return;
                key.SetValue(licenseName, data, RegistryValueKind.Binary);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static List<string> GetLicensesList(RegistryKey root, bool wow6432Node)
        {
            List<string> res = new List<string>();
            try
            {
                RegistryKey key = GetLicenseKey(root, wow6432Node);
                if (null != key)
                    res.AddRange(key.GetValueNames());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return res;
        }


        private static bool IsLicenseInList(List<string> list, string value)
        {
            for (int i = 0; i < list.Count; ++i)
                if (list[i].ToLower() == value.ToLower())
                    return true;

            return false;
        }

        private static RegistryKey GetLicenseKey(RegistryKey root, bool wow6432Node)
        {
            RegistryKey softkey;
            if (wow6432Node)
                softkey = root.OpenSubKey(WOW6432Node, true);
            else
                softkey = root.OpenSubKey(MainNode, true);
            if (null == softkey)
                return null;

            //security
            RegistrySecurity rs = new RegistrySecurity();
            try
            {
                rs.AddAccessRule(new RegistryAccessRule("Users", RegistryRights.FullControl, AccessControlType.Allow));
            }
            catch
            { }
            try
            {
                String sddlUsers = "S-1-1-0";  //Sid of Users group
                IdentityReference UsersSid = new SecurityIdentifier(sddlUsers);
                NTAccount account = (NTAccount)UsersSid.Translate(typeof(NTAccount));
                rs.AddAccessRule(new RegistryAccessRule(account, RegistryRights.FullControl, AccessControlType.Allow));
            }
            catch
            { }

            //result
            RegistryKey res = softkey.CreateSubKey(registryAsposeNode, RegistryKeyPermissionCheck.ReadWriteSubTree);
            res.SetAccessControl(rs);
            return res;
        }
    }
}
