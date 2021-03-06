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
    ///The Validate_Admin_Current_Password_Change_Recording1 recording.
    /// </summary>
    [TestModule("e85d2059-ac46-470a-a575-6d4cf3201d28", ModuleType.Recording, 1)]
    public partial class Validate_Admin_Current_Password_Change_Recording1 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Validate_Admin_Current_Password_Change_Recording1 instance = new Validate_Admin_Current_Password_Change_Recording1();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Admin_Current_Password_Change_Recording1()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Admin_Current_Password_Change_Recording1 Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.LabelLabelChangePassword'.", repo.WebDocumentIE.LabelLabelChangePasswordInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocumentIE.LabelLabelChangePasswordInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_labelChangePassword') on item 'WebDocumentIE.LabelLabelChangePassword'.", repo.WebDocumentIE.LabelLabelChangePasswordInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocumentIE.LabelLabelChangePasswordInfo, "Id", "label_labelChangePassword");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Change your password') on item 'WebDocumentIE.LabelLabelChangePassword'.", repo.WebDocumentIE.LabelLabelChangePasswordInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocumentIE.LabelLabelChangePasswordInfo, "InnerText", "Change your password");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=875,Height=78}) on item 'WebDocumentIE.LabelLabelChangePassword'.", repo.WebDocumentIE.LabelLabelChangePasswordInfo, new RecordItemIndex(3));
            Validate.ContainsImage(repo.WebDocumentIE.LabelLabelChangePasswordInfo, LabelLabelChangePassword_Screenshot1, LabelLabelChangePassword_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.CurrentPassword'.", repo.WebDocumentIE.CurrentPasswordInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.WebDocumentIE.CurrentPasswordInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Current password') on item 'WebDocumentIE.CurrentPassword'.", repo.WebDocumentIE.CurrentPasswordInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocumentIE.CurrentPasswordInfo, "InnerText", "Current password");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='CurrentPassword') on item 'WebDocument19216801.CurrentPassword'.", repo.WebDocument19216801.CurrentPasswordInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocument19216801.CurrentPasswordInfo, "Id", "CurrentPassword");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocument19216801.CurrentPassword'.", repo.WebDocument19216801.CurrentPasswordInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocument19216801.CurrentPasswordInfo, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.CurrentPassword' at 93;5.", repo.WebDocument19216801.CurrentPasswordInfo, new RecordItemIndex(8));
            repo.WebDocument19216801.CurrentPassword.Click("93;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}C{LShiftKey up}Hnageme1' with focus on 'WebDocument19216801.CurrentPassword'.", repo.WebDocument19216801.CurrentPasswordInfo, new RecordItemIndex(9));
            repo.WebDocument19216801.CurrentPassword.PressKeys("{LShiftKey down}C{LShiftKey up}Hnageme1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.CurrentPassword' at 39;13.", repo.WebDocument19216801.CurrentPasswordInfo, new RecordItemIndex(10));
            repo.WebDocument19216801.CurrentPassword.DoubleClick("39;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}{LShiftKey down}C{LShiftKey up}hangeme1' with focus on 'WebDocument19216801.CurrentPassword'.", repo.WebDocument19216801.CurrentPasswordInfo, new RecordItemIndex(11));
            repo.WebDocument19216801.CurrentPassword.PressKeys("{Delete}{LShiftKey down}C{LShiftKey up}hangeme1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.NewPassword13' at 36;10.", repo.WebDocumentIE.NewPassword13Info, new RecordItemIndex(12));
            repo.WebDocumentIE.NewPassword13.Click("36;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}C{LShiftKey up}hangeme0' with focus on 'WebDocumentIE.NewPassword13'.", repo.WebDocumentIE.NewPassword13Info, new RecordItemIndex(13));
            repo.WebDocumentIE.NewPassword13.PressKeys("{LShiftKey down}C{LShiftKey up}hangeme0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.ReenterPassword' at 54;9.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(14));
            repo.WebDocumentIE.ReenterPassword.Click("54;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}C{LShiftKey up}hnageme' with focus on 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(15));
            repo.WebDocumentIE.ReenterPassword.PressKeys("{LShiftKey down}C{LShiftKey up}hnageme");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(16));
            Keyboard.PrepareFocus(repo.WebDocumentIE.ReenterPassword);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}{LShiftKey down}C{LShiftKey up}hange' with focus on 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(17));
            repo.WebDocumentIE.ReenterPassword.PressKeys("{Delete}{LShiftKey down}C{LShiftKey up}hange");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'me' with focus on 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(18));
            repo.WebDocumentIE.ReenterPassword.PressKeys("me");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0' with focus on 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(19));
            repo.WebDocumentIE.ReenterPassword.PressKeys("0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button7' at 75;31.", repo.WebDocument19216801.Button7Info, new RecordItemIndex(20));
            repo.WebDocument19216801.Button7.Click("75;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='confirm-wizard') on item 'WebDocumentIE.ConfirmWizard1.ConfirmWizard'.", repo.WebDocumentIE.ConfirmWizard1.ConfirmWizardInfo, new RecordItemIndex(21));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.ConfirmWizardInfo, "Id", "confirm-wizard");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=875,Height=61}) on item 'WebDocumentIE.ConfirmWizard1.ConfirmWizard'.", repo.WebDocumentIE.ConfirmWizard1.ConfirmWizardInfo, new RecordItemIndex(22));
            Validate.ContainsImage(repo.WebDocumentIE.ConfirmWizard1.ConfirmWizardInfo, ConfirmWizard_Screenshot1, ConfirmWizard_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvg'.", repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='img') on item 'WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvg'.", repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, "TagName", "img");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://192.168.0.1/i/allgood-icon.svg') on item 'WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvg'.", repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, new RecordItemIndex(25));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, "Src", "http://192.168.0.1/i/allgood-icon.svg");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=37,Height=37}) on item 'WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvg'.", repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, new RecordItemIndex(26));
            Validate.ContainsImage(repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, Http19216801IAllgoodIconSvg_Screenshot1, Http19216801IAllgoodIconSvg_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdated'.", repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='confirm-wizard-text') on item 'WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdated'.", repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, new RecordItemIndex(28));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, "Class", "confirm-wizard-text");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your settings have been updated.') on item 'WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdated'.", repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, new RecordItemIndex(29));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, "InnerText", "Your settings have been updated.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=297,Height=60}) on item 'WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdated'.", repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, new RecordItemIndex(30));
            Validate.ContainsImage(repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, YourSettingsHaveBeenUpdated_Screenshot1, YourSettingsHaveBeenUpdated_Screenshot1_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage LabelLabelChangePassword_Screenshot1
        { get { return repo.WebDocumentIE.LabelLabelChangePasswordInfo.GetScreenshot1(new Rectangle(0, 0, 875, 78)); } }

        Imaging.FindOptions LabelLabelChangePassword_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ConfirmWizard_Screenshot1
        { get { return repo.WebDocumentIE.ConfirmWizard1.ConfirmWizardInfo.GetScreenshot1(new Rectangle(0, 0, 875, 61)); } }

        Imaging.FindOptions ConfirmWizard_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Http19216801IAllgoodIconSvg_Screenshot1
        { get { return repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo.GetScreenshot1(new Rectangle(0, 0, 37, 37)); } }

        Imaging.FindOptions Http19216801IAllgoodIconSvg_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage YourSettingsHaveBeenUpdated_Screenshot1
        { get { return repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo.GetScreenshot1(new Rectangle(0, 0, 297, 60)); } }

        Imaging.FindOptions YourSettingsHaveBeenUpdated_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
