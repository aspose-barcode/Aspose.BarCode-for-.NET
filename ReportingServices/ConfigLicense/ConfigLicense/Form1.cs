// Copyright (c) 2001-2021 Aspose Pty Ltd. All Rights Reserved.
using System;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ConfigLicense
{
    public partial class Form1 : Form
    {
        private const int MaximumLicenseSize = 4096;

        public Form1()
        {
            InitializeComponent();
        }

        private RegistryKey GetActualRootRegistry()
        {
            return GetActualRootRegistry(currentUserRadioButton.Checked);
        }

        private static RegistryKey GetActualRootRegistry(bool currentUser)
        {
            if (currentUser) return Registry.CurrentUser;
            return Registry.LocalMachine;
        }

        private void LoadNewLicensesList()
        {
            List<string> values = LicenseHelper.GetLicensesList(GetActualRootRegistry());
            LicenseBox.Items.Clear();
            foreach (string val in values)
                LicenseBox.Items.Add(val);
            if (0 < LicenseBox.Items.Count)
            {
                LicenseBox.SelectedIndex = 0;
                RemoveLicenseBtn.Enabled = true;
                RemoveAllLicensesBtn.Enabled = true;
            }
            else
            {
                RemoveLicenseBtn.Enabled = false;
                RemoveAllLicensesBtn.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNewLicensesList();
        }

        private void allUsersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadNewLicensesList();
        }

        private void currentUserRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadNewLicensesList();
        }

        private void AddNewLicenseBtn_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filename = openFileDialog1.FileName;
                if (!File.Exists(filename)) return;
                string licenseName = Path.GetFileName(filename);

                if (!LicenseHelper.CheckAccessAllowed(GetActualRootRegistry(), true)) return;

                bool isLicenseExists = LicenseHelper.IsLicenseExists(GetActualRootRegistry(), licenseName);
                if (isLicenseExists)
                    if (MessageBox.Show(string.Format("The license <{0}> already exists. Do you want to overwrite?", licenseName),
                    "The license already exists", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                        return;

                byte[] data = LicenseHelper.LoadFile(filename, MaximumLicenseSize);
                LicenseHelper.AddLicense(GetActualRootRegistry(), licenseName, data);
                LoadNewLicensesList();
            }

        }

        private void RemoveLicenseBtn_Click(object sender, EventArgs e)
        {
            if (LicenseBox.Items.Count <= 0) return;
            string licenseName = (string)LicenseBox.SelectedItem;

            if (MessageBox.Show(string.Format("Do you really want to delete license:<{0}>?", licenseName),
            "Delete license", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (!LicenseHelper.CheckAccessAllowed(GetActualRootRegistry(), true)) return;
            LicenseHelper.DeleteLicense(GetActualRootRegistry(), licenseName);
            LoadNewLicensesList();
        }

        private void RemoveAllLicensesBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you really want to delete ALL licenses?", "Delete ALL licenses", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (!LicenseHelper.CheckAccessAllowed(GetActualRootRegistry(), true)) return;
            LicenseHelper.DeleteAllLicenses(GetActualRootRegistry());
            LoadNewLicensesList();
        }
    }
}
