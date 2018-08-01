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
    ///The MM_Restore_Factory_Defaults recording.
    /// </summary>
    [TestModule("0f439e09-07ec-4122-8f47-25e6ce5fbbe0", ModuleType.Recording, 1)]
    public partial class MM_Restore_Factory_Defaults : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static MM_Restore_Factory_Defaults instance = new MM_Restore_Factory_Defaults();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MM_Restore_Factory_Defaults()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MM_Restore_Factory_Defaults Instance
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
            
            //Validate.Attribute(repo.WebDocument1921681001.RestoreDefInfo, "TagValue", "Restore default");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.RestoreDefInfo, "Value", "Restore default");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.RestoreDefInfo, RestoreDef_Screenshot1, RestoreDef_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument1921681001.RestoreDef.Click("75;27");
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument1921681001.Button2Info, "TagValue", "Cancel process");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument1921681001.Button2Info, "Value", "Cancel process");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.Button2Info, Button2_Screenshot1, Button2_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(23));
            
            Validate.Attribute(repo.WebDocument1921681001.EnableGuestBtnInfo, "Id", "enableGuestBtn");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument1921681001.EnableGuestBtnInfo, "TagValue", "Restore defaults");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.EnableGuestBtnInfo, "Value", "Restore defaults");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.EnableGuestBtnInfo, EnableGuestBtn_Screenshot1, EnableGuestBtn_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument1921681001.EnableGuestBtn.Click("219;43");
            Delay.Milliseconds(200);
            
            //repo.WebDocument1921681001.Self.MoveTo("1906;408");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //repo.WebDocument1921681001.Self.MoveTo("1914;400");
            //Delay.Milliseconds(200);
            
            repo.WebDocument1921681001.Overlaycontainer1.Overlaycontainer.MoveTo("1893;129");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument1921681001.Overlaycontainer1.Http1921681001SkinsLgiCssImageInfo, "TagName", "img");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument1921681001.Overlaycontainer1.Http1921681001SkinsLgiCssImageInfo, "Src", "http://192.168.100.1/skins/lgi/css/images/close.png");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.Overlaycontainer1.Http1921681001SkinsLgiCssImageInfo, Http1921681001SkinsLgiCssImage_Screenshot1, Http1921681001SkinsLgiCssImage_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.Overlaycontainer1.CloseInfo, "InnerText", "Close");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.Overlaycontainer1.CloseInfo, Close_Screenshot1, Close_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(37));
            
            repo.WebDocument1921681001.Overlaycontainer1.Close.Click("49;33");
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

        CompressedImage EnableGuestBtn_Screenshot1
        { get { return repo.WebDocument1921681001.EnableGuestBtnInfo.GetScreenshot1(new Rectangle(0, 0, 345, 75)); } }

        Imaging.FindOptions EnableGuestBtn_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Http1921681001SkinsLgiCssImage_Screenshot1
        { get { return repo.WebDocument1921681001.Overlaycontainer1.Http1921681001SkinsLgiCssImageInfo.GetScreenshot1(new Rectangle(0, 0, 56, 56)); } }

        Imaging.FindOptions Http1921681001SkinsLgiCssImage_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Close_Screenshot1
        { get { return repo.WebDocument1921681001.Overlaycontainer1.CloseInfo.GetScreenshot1(new Rectangle(0, 0, 108, 56)); } }

        Imaging.FindOptions Close_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}