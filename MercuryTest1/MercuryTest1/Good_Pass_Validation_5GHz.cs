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
    ///The Good_Pass_Validation_5GHz recording.
    /// </summary>
    [TestModule("b2456d2d-3526-46c5-b7b6-a8644de4b564", ModuleType.Recording, 1)]
    public partial class Good_Pass_Validation_5GHz : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Good_Pass_Validation_5GHz instance = new Good_Pass_Validation_5GHz();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Good_Pass_Validation_5GHz()
        {
            VeryStrongPassword = "";
            Good_Pass = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Good_Pass_Validation_5GHz Instance
        {
            get { return instance; }
        }

#region Variables

        string _VeryStrongPassword;

        /// <summary>
        /// Gets or sets the value of variable VeryStrongPassword.
        /// </summary>
        [TestVariable("d529ae8c-5ab9-4fa4-b7af-38d5df5568fc")]
        public string VeryStrongPassword
        {
            get { return _VeryStrongPassword; }
            set { _VeryStrongPassword = value; }
        }

        string _Good_Pass;

        /// <summary>
        /// Gets or sets the value of variable Good_Pass.
        /// </summary>
        [TestVariable("6b0b781e-f6b5-4061-8bbf-6319a85f3891")]
        public string Good_Pass
        {
            get { return _Good_Pass; }
            set { _Good_Pass = value; }
        }

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

            repo.WebDocument19216801.Passphrase50.Click("70;11");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1354;146.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(1));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1354;146");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1355;269.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(2));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1355;269");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase50' at 113;15.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(3));
            //repo.WebDocument19216801.Passphrase50.MoveTo("113;15");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase50' at 121;7.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(4));
            //repo.WebDocument19216801.Passphrase50.MoveTo("121;7");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey1' at 272;20.", repo.WebDocument19216801.WiFiPasswordSecurityKey1Info, new RecordItemIndex(5));
            //repo.WebDocument19216801.WiFiPasswordSecurityKey1.MoveTo("272;20");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'amm1notesT' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(8));
            //repo.WebDocument19216801.Passphrase50.PressKeys("amm1notesT");
            //Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Passphrase50.PressKeys(Good_Pass);
            Delay.Milliseconds(400);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(10));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            try {
                //Validate_PasstextWifi1();
                //Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='pass_text medium') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Class", "pass_text medium");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='passtext_wifi') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Id", "passtext_wifi");
            //Delay.Milliseconds(100);
            
            try {
                Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Good", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception) {  }
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot7' with region {X=0,Y=0,Width=29,Height=13}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(15));
            //Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot7_2, PasstextWifi_Screenshot7_2_Options);
            //Delay.Milliseconds(100);
            
            try {
                Validate_PasstextWifi(Good_Pass);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.ContentContainer' at 366;732.", repo.WebDocument19216801.ContentContainerInfo, new RecordItemIndex(17));
            //repo.WebDocument19216801.ContentContainer.DoubleClick("366;732");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(18));
            //repo.WebDocument19216801.Passphrase50.PressKeys("{LControlKey up}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.Passphrase50' at 55;11.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(19));
            //repo.WebDocument19216801.Passphrase50.DoubleClick("55;11");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Amm1notested' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(20));
            //repo.WebDocument19216801.Passphrase50.PressKeys("Amm1notested");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.Passphrase50' at 73;8.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(21));
            //repo.WebDocument19216801.Passphrase50.DoubleClick("73;8");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Amm1notest' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(22));
            //repo.WebDocument19216801.Passphrase50.PressKeys("Amm1notest");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.Passphrase50' at 39;9.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(23));
            //repo.WebDocument19216801.Passphrase50.DoubleClick("39;9");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(24));
            //repo.WebDocument19216801.Passphrase50.PressKeys("{LControlKey up}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.Passphrase50' at 39;9.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(25));
            //repo.WebDocument19216801.Passphrase50.DoubleClick("39;9");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.Passphrase50' at 39;9.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(26));
            //repo.WebDocument19216801.Passphrase50.DoubleClick("39;9");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Amm1notested' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(27));
            //repo.WebDocument19216801.Passphrase50.PressKeys("Amm1notested");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(28));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='pass_text strong') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(29));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Class", "pass_text strong");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='passtext_wifi') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(30));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Id", "passtext_wifi");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Strong') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(31));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Strong");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot8' with region {X=0,Y=0,Width=36,Height=13}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(32));
            //Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot8, PasstextWifi_Screenshot8_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(33));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            try {
                //Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Good') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(34));
                //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Good", Validate.DefaultMessage, false);
                //Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(34)); }
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='pass_text good') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(35));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Class", "pass_text good");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='passtext_wifi') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(36));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Id", "passtext_wifi");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Good') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(37));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Good");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot5' with region {X=0,Y=0,Width=33,Height=13}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(38));
            //Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot5, PasstextWifi_Screenshot5_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImagesInfo, new RecordItemIndex(39));
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImagesInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='skipSVG check-icon') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImagesInfo, new RecordItemIndex(40));
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImagesInfo, "Class", "skipSVG check-icon");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://192.168.0.1/skins/lgi/css/images/icon-check.svg') on item 'WebDocument19216801.Http19216801SkinsLgiCssImages'.", repo.WebDocument19216801.Http19216801SkinsLgiCssImagesInfo, new RecordItemIndex(41));
            //Validate.Attribute(repo.WebDocument19216801.Http19216801SkinsLgiCssImagesInfo, "Src", "http://192.168.0.1/skins/lgi/css/images/icon-check.svg");
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage PasstextWifi_Screenshot7
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot7(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions PasstextWifi_Screenshot7_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage PasstextWifi_Screenshot7_2
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot7(new Rectangle(0, 0, 29, 13)); } }

        Imaging.FindOptions PasstextWifi_Screenshot7_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage PasstextWifi_Screenshot8
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot8(new Rectangle(0, 0, 36, 13)); } }

        Imaging.FindOptions PasstextWifi_Screenshot8_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage PasstextWifi_Screenshot5
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot5(new Rectangle(0, 0, 33, 13)); } }

        Imaging.FindOptions PasstextWifi_Screenshot5_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}