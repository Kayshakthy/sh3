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
    ///The DisableModemMode recording.
    /// </summary>
    [TestModule("a3b9cb2b-1f61-41e3-a103-a166b61d13dc", ModuleType.Recording, 1)]
    public partial class DisableModemMode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static DisableModemMode instance = new DisableModemMode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DisableModemMode()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DisableModemMode Instance
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

            repo.WebDocument1921681001.FmRbtnRouterMode.Click("11;17");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument1921681001.FmRbtnRouterMode'.", repo.WebDocument1921681001.FmRbtnRouterModeInfo, new RecordItemIndex(1));
            //Validate.Attribute(repo.WebDocument1921681001.FmRbtnRouterModeInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument1921681001.FmRbtnRouterMode'.", repo.WebDocument1921681001.FmRbtnRouterModeInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument1921681001.FmRbtnRouterModeInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmRadio checked') on item 'WebDocument1921681001.FmRbtnRouterMode'.", repo.WebDocument1921681001.FmRbtnRouterModeInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument1921681001.FmRbtnRouterModeInfo, "Class", "fmRadio checked");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-RouterMode') on item 'WebDocument1921681001.FmRbtnRouterMode'.", repo.WebDocument1921681001.FmRbtnRouterModeInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument1921681001.FmRbtnRouterModeInfo, "Id", "fmRbtn-RouterMode");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument1921681001.FmRbtnRouterMode'.", repo.WebDocument1921681001.FmRbtnRouterModeInfo, new RecordItemIndex(5));
            //Validate.Exists(repo.WebDocument1921681001.FmRbtnRouterModeInfo);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument1921681001.EnabledRouterMode'.", repo.WebDocument1921681001.EnabledRouterModeInfo, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument1921681001.EnabledRouterModeInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            repo.WebDocument1921681001.FmRbtnRouterMode.Click("13;22");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=261,Height=33}) on item 'WebDocumentIE.TrRouterMode'.", repo.WebDocumentIE.TrRouterModeInfo, new RecordItemIndex(8));
            //Validate.ContainsImage(repo.WebDocumentIE.TrRouterModeInfo, TrRouterMode_Screenshot1, TrRouterMode_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument1921681001.EnabledRouterModeInfo, "InnerText", "Enabled Router Mode");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=176,Height=21}) on item 'WebDocument1921681001.EnabledRouterMode'.", repo.WebDocument1921681001.EnabledRouterModeInfo, new RecordItemIndex(10));
            //Validate.ContainsImage(repo.WebDocument1921681001.EnabledRouterModeInfo, EnabledRouterMode_Screenshot2, EnabledRouterMode_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.ApplyButton' at 96;12.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(11));
            //repo.WebDocument1921681001.ApplyButton.Click("96;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.Button1' at 284;25.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(12));
            //repo.WebDocument1921681001.Button1.Click("284;25");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument1921681001.EnabledRouterMode'.", repo.WebDocument1921681001.EnabledRouterModeInfo, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument1921681001.EnabledRouterModeInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=137,Height=16}) on item 'WebDocument1921681001.EnabledRouterMode'.", repo.WebDocument1921681001.EnabledRouterModeInfo, new RecordItemIndex(14));
            //Validate.ContainsImage(repo.WebDocument1921681001.EnabledRouterModeInfo, EnabledRouterMode_Screenshot1, EnabledRouterMode_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.LabelModemModeInfo, "InnerText", "Modem mode");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.LabelModemModeInfo, LabelModemMode_Screenshot3, LabelModemMode_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.ModemModeDisablesTheWiFiFeatureOfInfo, "InnerText", "Modem mode disables the WiFi feature of the Hub 3.0, so you can connect your own wireless router.");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.EnableModemModeInfo, "InnerText", "Enable Modem Mode");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument1921681001.EnableRouterModeInfo, "InnerText", "Enable Router Mode");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument1921681001.EnableRouterModeInfo, EnableRouterMode_Screenshot1, EnableRouterMode_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(21));
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument1921681001.ApplyButton'.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(22));
            //Validate.Attribute(repo.WebDocument1921681001.ApplyButtonInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument1921681001.ApplyButton'.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(23));
            //Validate.Attribute(repo.WebDocument1921681001.ApplyButtonInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='submitBtn') on item 'WebDocument1921681001.ApplyButton'.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(24));
            //Validate.Attribute(repo.WebDocument1921681001.ApplyButtonInfo, "Class", "submitBtn");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='ApplyButton') on item 'WebDocument1921681001.ApplyButton'.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(25));
            //Validate.Attribute(repo.WebDocument1921681001.ApplyButtonInfo, "Id", "ApplyButton");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Apply changes') on item 'WebDocument1921681001.ApplyButton'.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(26));
            //Validate.Attribute(repo.WebDocument1921681001.ApplyButtonInfo, "TagValue", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Apply changes') on item 'WebDocument1921681001.ApplyButton'.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(27));
            //Validate.Attribute(repo.WebDocument1921681001.ApplyButtonInfo, "Value", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=164,Height=42}) on item 'WebDocument1921681001.ApplyButton'.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(28));
            //Validate.ContainsImage(repo.WebDocument1921681001.ApplyButtonInfo, ApplyButton_Screenshot1, ApplyButton_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument1921681001.ApplyButton.Click("67;26");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument1921681001.JustToConfirm'.", repo.WebDocument1921681001.JustToConfirmInfo, new RecordItemIndex(30));
            //Validate.Attribute(repo.WebDocument1921681001.JustToConfirmInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument1921681001.JustToConfirm'.", repo.WebDocument1921681001.JustToConfirmInfo, new RecordItemIndex(31));
            //Validate.Attribute(repo.WebDocument1921681001.JustToConfirmInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Just to confirm') on item 'WebDocument1921681001.JustToConfirm'.", repo.WebDocument1921681001.JustToConfirmInfo, new RecordItemIndex(32));
            //Validate.Attribute(repo.WebDocument1921681001.JustToConfirmInfo, "InnerText", "Just to confirm");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=716,Height=88}) on item 'WebDocument1921681001.JustToConfirm'.", repo.WebDocument1921681001.JustToConfirmInfo, new RecordItemIndex(33));
            //Validate.ContainsImage(repo.WebDocument1921681001.JustToConfirmInfo, JustToConfirm_Screenshot1, JustToConfirm_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument1921681001.Button1'.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(34));
            //Validate.Attribute(repo.WebDocument1921681001.Button1Info, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument1921681001.Button1'.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(35));
            //Validate.Attribute(repo.WebDocument1921681001.Button1Info, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='wizard_button') on item 'WebDocument1921681001.Button1'.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(36));
            //Validate.Attribute(repo.WebDocument1921681001.Button1Info, "Class", "wizard_button");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Apply changes') on item 'WebDocument1921681001.Button1'.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(37));
            //Validate.Attribute(repo.WebDocument1921681001.Button1Info, "TagValue", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Apply changes') on item 'WebDocument1921681001.Button1'.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(38));
            //Validate.Attribute(repo.WebDocument1921681001.Button1Info, "Value", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=263,Height=62}) on item 'WebDocument1921681001.Button1'.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(39));
            //Validate.ContainsImage(repo.WebDocument1921681001.Button1Info, Button1_Screenshot1, Button1_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument1921681001.Button1.Click("111;21");
            //Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage TrRouterMode_Screenshot1
        { get { return repo.WebDocumentIE.TrRouterModeInfo.GetScreenshot1(new Rectangle(0, 0, 261, 33)); } }

        Imaging.FindOptions TrRouterMode_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage EnabledRouterMode_Screenshot2
        { get { return repo.WebDocument1921681001.EnabledRouterModeInfo.GetScreenshot2(new Rectangle(0, 0, 176, 21)); } }

        Imaging.FindOptions EnabledRouterMode_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage EnabledRouterMode_Screenshot1
        { get { return repo.WebDocument1921681001.EnabledRouterModeInfo.GetScreenshot1(new Rectangle(0, 0, 137, 16)); } }

        Imaging.FindOptions EnabledRouterMode_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage LabelModemMode_Screenshot3
        { get { return repo.WebDocument1921681001.LabelModemModeInfo.GetScreenshot3(new Rectangle(0, 0, 875, 78)); } }

        Imaging.FindOptions LabelModemMode_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage EnableRouterMode_Screenshot1
        { get { return repo.WebDocument1921681001.EnableRouterModeInfo.GetScreenshot1(new Rectangle(0, 0, 155, 20)); } }

        Imaging.FindOptions EnableRouterMode_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ApplyButton_Screenshot1
        { get { return repo.WebDocument1921681001.ApplyButtonInfo.GetScreenshot1(new Rectangle(0, 0, 164, 42)); } }

        Imaging.FindOptions ApplyButton_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage JustToConfirm_Screenshot1
        { get { return repo.WebDocument1921681001.JustToConfirmInfo.GetScreenshot1(new Rectangle(0, 0, 716, 88)); } }

        Imaging.FindOptions JustToConfirm_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button1_Screenshot1
        { get { return repo.WebDocument1921681001.Button1Info.GetScreenshot1(new Rectangle(0, 0, 263, 62)); } }

        Imaging.FindOptions Button1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
