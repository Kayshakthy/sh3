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
    ///The Invalid_Pass_Validation_5GHz_Record recording.
    /// </summary>
    [TestModule("0f520505-06bf-406d-b540-193db1f4657f", ModuleType.Recording, 1)]
    public partial class Invalid_Pass_Validation_5GHz_Record : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Invalid_Pass_Validation_5GHz_Record instance = new Invalid_Pass_Validation_5GHz_Record();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Invalid_Pass_Validation_5GHz_Record()
        {
            Invalid_Pass_5GHz = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Invalid_Pass_Validation_5GHz_Record Instance
        {
            get { return instance; }
        }

#region Variables

        string _Invalid_Pass_5GHz;

        /// <summary>
        /// Gets or sets the value of variable Invalid_Pass_5GHz.
        /// </summary>
        [TestVariable("0729799a-8e23-4d5f-be8d-891feea01ecd")]
        public string Invalid_Pass_5GHz
        {
            get { return _Invalid_Pass_5GHz; }
            set { _Invalid_Pass_5GHz = value; }
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
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Invalid_Pass_5GHz' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(3));
            repo.WebDocument19216801.Passphrase50.PressKeys(Invalid_Pass_5GHz);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Invalid') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Invalid");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase50' at 83;9.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(5));
            repo.WebDocument19216801.Passphrase50.MoveTo("83;9");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase50' at 91;1.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(6));
            repo.WebDocument19216801.Passphrase50.MoveTo("91;1");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocumentIE.FmInpPassphrase50' at 1;22.", repo.WebDocumentIE.FmInpPassphrase50Info, new RecordItemIndex(7));
            repo.WebDocumentIE.FmInpPassphrase50.MoveTo("1;22");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}A{LShiftKey up}m' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(8));
            repo.WebDocument19216801.Passphrase50.PressKeys("{LShiftKey down}A{LShiftKey up}m");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '1' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(9));
            repo.WebDocument19216801.Passphrase50.PressKeys("1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'not' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(10));
            repo.WebDocument19216801.Passphrase50.PressKeys("not");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'est' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(11));
            repo.WebDocument19216801.Passphrase50.PressKeys("est");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}!{LShiftKey up}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(12));
            repo.WebDocument19216801.Passphrase50.PressKeys("{LShiftKey down}!{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ababc{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(13));
            repo.WebDocument19216801.Passphrase50.PressKeys("ababc{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}!{LShiftKey up}{LShiftKey down}{LShiftKey up}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(14));
            repo.WebDocument19216801.Passphrase50.PressKeys("{LShiftKey down}!{LShiftKey up}{LShiftKey down}{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(15));
            repo.WebDocument19216801.Passphrase50.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'bhbscjfdjfdjhjhfhjfdkfd' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(16));
            repo.WebDocument19216801.Passphrase50.PressKeys("bhbscjfdjfdjhjhfhjfdkfd");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back 32}sdggsdh' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(17));
            repo.WebDocument19216801.Passphrase50.PressKeys("{Back 32}sdggsdh");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(18));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Not Sufficient') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Not Sufficient");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot14' with region {X=0,Y=0,Width=70,Height=14}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(20));
            Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot14, PasstextWifi_Screenshot14_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'WebDocument19216801.Passphrase50' at 64;13.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(21));
            repo.WebDocument19216801.Passphrase50.DoubleClick("64;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase50' at 64;13.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(22));
            repo.WebDocument19216801.Passphrase50.MoveTo("64;13");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase50' at 72;5.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(23));
            repo.WebDocument19216801.Passphrase50.MoveTo("72;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocumentIE.WiFiPasswordSecurityKey' at 207;16.", repo.WebDocumentIE.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(24));
            repo.WebDocumentIE.WiFiPasswordSecurityKey.MoveTo("207;16");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'amm' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(25));
            repo.WebDocument19216801.Passphrase50.PressKeys("amm");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}!{LShiftKey up}{LShiftKey down}{LShiftKey up}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(26));
            repo.WebDocument19216801.Passphrase50.PressKeys("{LShiftKey down}!{LShiftKey up}{LShiftKey down}{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(27));
            repo.WebDocument19216801.Passphrase50.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}G{LShiftKey up}jhdjdkd;s{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(28));
            repo.WebDocument19216801.Passphrase50.PressKeys("{LShiftKey down}G{LShiftKey up}jhdjdkd;s{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'd' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(29));
            repo.WebDocument19216801.Passphrase50.PressKeys("d");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Back}' with focus on 'WebDocument19216801.Passphrase50'.", repo.WebDocument19216801.Passphrase50Info, new RecordItemIndex(30));
            repo.WebDocument19216801.Passphrase50.PressKeys("{Back}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(31));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(32));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='pass_text invalid') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(33));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "Class", "pass_text invalid");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='invalid') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(34));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "invalid");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot15' with region {X=0,Y=0,Width=32,Height=14}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(35));
            Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot15, PasstextWifi_Screenshot15_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage PasstextWifi_Screenshot14
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot14(new Rectangle(0, 0, 70, 14)); } }

        Imaging.FindOptions PasstextWifi_Screenshot14_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage PasstextWifi_Screenshot15
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot15(new Rectangle(0, 0, 32, 14)); } }

        Imaging.FindOptions PasstextWifi_Screenshot15_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
