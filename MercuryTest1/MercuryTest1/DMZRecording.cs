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
    ///The DMZRecording recording.
    /// </summary>
    [TestModule("c2f9c57e-22dd-4278-8215-ae9e6a63db6a", ModuleType.Recording, 1)]
    public partial class DMZRecording : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static DMZRecording instance = new DMZRecording();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public DMZRecording()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static DMZRecording Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://192.168.0.1' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("http://192.168.0.1", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Password' at 80;15.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.Password.Click("80;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}V{LShiftKey up}irgin' with focus on 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.Password.PressKeys("{LShiftKey down}V{LShiftKey up}irgin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '123' with focus on 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.Password.PressKeys("123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button' at 61;34.", repo.WebDocument19216801.ButtonInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.Button.Click("61;34");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=116,Height=83}) on item 'WebDocument19216801.LogoContainer'.", repo.WebDocument19216801.LogoContainerInfo, new RecordItemIndex(5));
            Validate.ContainsImage(repo.WebDocument19216801.LogoContainerInfo, LogoContainer_Screenshot1, LogoContainer_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 71;6.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(6));
            repo.WebDocument19216801.AdvancedSettings.Click("71;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security1' at 30;3.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(7));
            repo.WebDocument19216801.Security1.Click("30;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Security') on item 'WebDocument19216801.Security1'.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.Security1Info, "InnerText", "Security");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1354;248.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(9));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1354;248");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1360;358.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(10));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1360;358");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='DMZ') on item 'WebDocument19216801.ATagDMZ'.", repo.WebDocument19216801.ATagDMZInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.WebDocument19216801.ATagDMZInfo, "InnerText", "DMZ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.ATagDMZ' at 26;11.", repo.WebDocument19216801.ATagDMZInfo, new RecordItemIndex(12));
            repo.WebDocument19216801.ATagDMZ.Click("26;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmRbtnDisableDMZ'.", repo.WebDocument19216801.FmRbtnDisableDMZInfo, new RecordItemIndex(13));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnDisableDMZInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-DisableDMZ') on item 'WebDocument19216801.FmRbtnDisableDMZ'.", repo.WebDocument19216801.FmRbtnDisableDMZInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnDisableDMZInfo, "Id", "fmRbtn-DisableDMZ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnEnableDMZ' at 12;14.", repo.WebDocument19216801.FmRbtnEnableDMZInfo, new RecordItemIndex(15));
            repo.WebDocument19216801.FmRbtnEnableDMZ.Click("12;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmRbtnEnableDMZ'.", repo.WebDocument19216801.FmRbtnEnableDMZInfo, new RecordItemIndex(16));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnEnableDMZInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-EnableDMZ') on item 'WebDocument19216801.FmRbtnEnableDMZ'.", repo.WebDocument19216801.FmRbtnEnableDMZInfo, new RecordItemIndex(17));
            Validate.Attribute(repo.WebDocument19216801.FmRbtnEnableDMZInfo, "Id", "fmRbtn-EnableDMZ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.PrivateIP3' at 13;9.", repo.WebDocument19216801.PrivateIP3Info, new RecordItemIndex(18));
            repo.WebDocument19216801.PrivateIP3.MoveTo("13;9");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.PrivateIP3' at 13;9.", repo.WebDocument19216801.PrivateIP3Info, new RecordItemIndex(19));
            repo.WebDocument19216801.PrivateIP3.MoveTo("13;9");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='PrivateIP_3') on item 'WebDocument19216801.PrivateIP3'.", repo.WebDocument19216801.PrivateIP3Info, new RecordItemIndex(20));
            Validate.Attribute(repo.WebDocument19216801.PrivateIP3Info, "Id", "PrivateIP_3");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='0') on item 'WebDocument19216801.PrivateIP3'.", repo.WebDocument19216801.PrivateIP3Info, new RecordItemIndex(21));
            Validate.Attribute(repo.WebDocument19216801.PrivateIP3Info, "Value", "0");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Tools' at 11;5.", repo.WebDocument19216801.ToolsInfo, new RecordItemIndex(22));
            repo.WebDocument19216801.Tools.Click("11;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Ping' at 24;11.", repo.WebDocument19216801.PingInfo, new RecordItemIndex(23));
            repo.WebDocument19216801.Ping.Click("24;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Waiting for input...') on item 'WebDocument19216801.PingResult'.", repo.WebDocument19216801.PingResultInfo, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocument19216801.PingResultInfo, "InnerText", "Waiting for input...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Waiting for input...') on item 'WebDocument19216801.PingResult'.", repo.WebDocument19216801.PingResultInfo, new RecordItemIndex(25));
            Validate.Attribute(repo.WebDocument19216801.PingResultInfo, "TagValue", "Waiting for input...");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Target' at 116;12.", repo.WebDocument19216801.TargetInfo, new RecordItemIndex(26));
            repo.WebDocument19216801.Target.Click("116;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'www.google.com' with focus on 'WebDocument19216801.Target'.", repo.WebDocument19216801.TargetInfo, new RecordItemIndex(27));
            repo.WebDocument19216801.Target.PressKeys("www.google.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Start' at 72;9.", repo.WebDocument19216801.StartInfo, new RecordItemIndex(28));
            repo.WebDocument19216801.Start.Click("72;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(29));
            Delay.Duration(500, false);
            
            Validate_PingResult();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage LogoContainer_Screenshot1
        { get { return repo.WebDocument19216801.LogoContainerInfo.GetScreenshot1(new Rectangle(0, 0, 116, 83)); } }

        Imaging.FindOptions LogoContainer_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
