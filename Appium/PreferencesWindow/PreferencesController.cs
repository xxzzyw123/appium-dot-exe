﻿using System;
using System.IO;
using System.Windows.Forms;

namespace Appium.PreferencesWindow
{
    public class PreferencesController
    {
        private MainWindow.Model _Model;

        public PreferencesController(MainWindow.Model model)
        {
            this._Model = model;
        }

        public void ExternalNodeJSBinaryBrowseButton_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog chooseNodeJSBinaryDialog = new OpenFileDialog();
            if (File.Exists(this._Model.ExternalNodeJSBinary))
            {
                chooseNodeJSBinaryDialog.InitialDirectory = Path.GetDirectoryName(this._Model.ExternalNodeJSBinary);
            }
            chooseNodeJSBinaryDialog.CheckFileExists = true;
            chooseNodeJSBinaryDialog.Multiselect = false;
            chooseNodeJSBinaryDialog.Filter = "NodeJS Binary (node.exe)|node.exe";
            chooseNodeJSBinaryDialog.Title = "Select Your NodeJS Binary";
            var result = chooseNodeJSBinaryDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this._Model.ExternalNodeJSBinary = chooseNodeJSBinaryDialog.FileName;
            }
        }

        public void ExternalAppiumPackageBrowse_Click(object sender, System.EventArgs e)
        {
            OpenFileDialog chooseAppiumPackageDialog = new OpenFileDialog();
            if (Directory.Exists(this._Model.ExternalAppiumPackage))
            {
                chooseAppiumPackageDialog.InitialDirectory = this._Model.ExternalAppiumPackage;
            }
            chooseAppiumPackageDialog.CheckPathExists = true;
            chooseAppiumPackageDialog.Multiselect = false;
            chooseAppiumPackageDialog.Title = "Select Your Appium Package Folder";
            var result = chooseAppiumPackageDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this._Model.ExternalAppiumPackage = chooseAppiumPackageDialog.FileName;
            }
        }
    }
}
