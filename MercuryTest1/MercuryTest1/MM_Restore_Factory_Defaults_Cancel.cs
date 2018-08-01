﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace ArrisTest
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The MM_Restore_Factory_Defaults_Cancel recording.
    /// </summary>
    [TestModule("91c1c2e9-88d7-4bbf-916b-0e698d4140ee", ModuleType.Recording, 1)]
    public partial class MM_Restore_Factory_Defaults_Cancel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static MM_Restore_Factory_Defaults_Cancel instance = new MM_Restore_Factory_Defaults_Cancel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MM_Restore_Factory_Defaults_Cancel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MM_Restore_Factory_Defaults_Cancel Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "6.1")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Validate.Attribute(repo.WebDocumentIE.AdminInfo, "InnerText", "Admin");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.AdminInfo, Admin_Screenshot1, Admin_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocumentIE.Admin.Click("35;16");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocumentIE.ReloadAndRebootInfo, "InnerText", "Reload and Reboot");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.ReloadAndRebootInfo, "Href", "http://192.168.100.1/?device_reboot&mid=ReloadAndReboot");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.ReloadAndRebootInfo, ReloadAndReboot_Screenshot1, ReloadAndReboot_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocumentIE.ReloadAndReboot.Click("39;6");
            Delay.Milliseconds(200);
            
            //repo.WebDocumentIE.Admin.Click("28;15");
            //Delay.Milliseconds(200);
            
            //repo.WebDocumentIE.ReloadAndReboot.Click("38;7");
            //Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument1921681001.LabelReloadAndRebootInfo, "Id", "label_ReloadAndReboot");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.LabelReloadAndRebootInfo, "InnerText", "Reload and Reboot");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument1921681001.LabelReloadAndRebootInfo, "tabindex", "0");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.LabelReloadAndRebootInfo, LabelReloadAndReboot_Screenshot1, LabelReloadAndReboot_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument1921681001.Self.MoveTo("1905;449");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            repo.WebDocument1921681001.Self.MoveTo("1887;678");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument1921681001.RestoreDefInfo, "Id", "RestoreDef");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.RestoreDefInfo, "TagValue", "Restore default");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.RestoreDefInfo, "Value", "Restore default");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.RestoreDefInfo, RestoreDef_Screenshot1, RestoreDef_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(19));
            
            repo.WebDocument1921681001.RestoreDef.Click("75;27");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocument1921681001.Button2Info, "TagValue", "Cancel process");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument1921681001.Button2Info, "Value", "Cancel process");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.Button2Info, Button2_Screenshot1, Button2_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(24));
            
            repo.WebDocument1921681001.Button2.Click("75;27");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage Admin_Screenshot1
        { get { return repo.WebDocumentIE.AdminInfo.GetScreenshot1(new Rectangle(0, 0, 53, 22)); } }

        Imaging.FindOptions Admin_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ReloadAndReboot_Screenshot1
        { get { return repo.WebDocumentIE.ReloadAndRebootInfo.GetScreenshot1(new Rectangle(0, 0, 137, 20)); } }

        Imaging.FindOptions ReloadAndReboot_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage LabelReloadAndReboot_Screenshot1
        { get { return repo.WebDocument1921681001.LabelReloadAndRebootInfo.GetScreenshot1(new Rectangle(0, 0, 875, 78)); } }

        Imaging.FindOptions LabelReloadAndReboot_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RestoreDef_Screenshot1
        { get { return repo.WebDocument1921681001.RestoreDefInfo.GetScreenshot1(new Rectangle(0, 0, 192, 57)); } }

        Imaging.FindOptions RestoreDef_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button2_Screenshot1
        { get { return repo.WebDocument1921681001.Button2Info.GetScreenshot1(new Rectangle(0, 0, 326, 75)); } }

        Imaging.FindOptions Button2_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
