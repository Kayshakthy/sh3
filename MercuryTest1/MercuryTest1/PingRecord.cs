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
    ///The PingRecord recording.
    /// </summary>
    [TestModule("dc6121eb-ec7a-4c2f-ba70-35289c411821", ModuleType.Recording, 1)]
    public partial class PingRecord : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static PingRecord instance = new PingRecord();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public PingRecord()
        {
            BoxUrl = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static PingRecord Instance
        {
            get { return instance; }
        }

#region Variables

        string _BoxUrl;

        /// <summary>
        /// Gets or sets the value of variable BoxUrl.
        /// </summary>
        [TestVariable("60fe589c-b885-45db-bc92-b5db3f537bb0")]
        public string BoxUrl
        {
            get { return _BoxUrl; }
            set { _BoxUrl = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Password' at 35;7.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.Password.Click("35;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}V{LShiftKey up}irgin123' with focus on 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.Password.PressKeys("{LShiftKey down}V{LShiftKey up}irgin123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button' at 40;22.", repo.WebDocument19216801.ButtonInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.Button.Click("40;22");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Advanced settings') on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocument19216801.AdvancedSettingsInfo, "InnerText", "Advanced settings");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=125,Height=19}) on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(4));
            Validate.ContainsImage(repo.WebDocument19216801.AdvancedSettingsInfo, AdvancedSettings_Screenshot2, AdvancedSettings_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 69;11.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.AdvancedSettings.Click("69;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Tools' at 17;7.", repo.WebDocument19216801.ToolsInfo, new RecordItemIndex(6));
            repo.WebDocument19216801.Tools.Click("17;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Ping') on item 'WebDocument19216801.Ping'.", repo.WebDocument19216801.PingInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocument19216801.PingInfo, "InnerText", "Ping");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1356;347.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(8));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1356;347");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1352;377.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(9));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1352;377");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Ping' at 18;10.", repo.WebDocument19216801.PingInfo, new RecordItemIndex(10));
            repo.WebDocument19216801.Ping.Click("18;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Target' at 20;10.", repo.WebDocument19216801.TargetInfo, new RecordItemIndex(11));
            repo.WebDocument19216801.Target.Click("20;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'www.google.com' with focus on 'WebDocument19216801.Target'.", repo.WebDocument19216801.TargetInfo, new RecordItemIndex(12));
            repo.WebDocument19216801.Target.PressKeys("www.google.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_Ping') on item 'WebDocument19216801.LabelPing'.", repo.WebDocument19216801.LabelPingInfo, new RecordItemIndex(13));
            Validate.Attribute(repo.WebDocument19216801.LabelPingInfo, "Id", "label_Ping");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Ping') on item 'WebDocument19216801.LabelPing'.", repo.WebDocument19216801.LabelPingInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.WebDocument19216801.LabelPingInfo, "InnerText", "Ping");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Start' at 64;23.", repo.WebDocument19216801.StartInfo, new RecordItemIndex(15));
            repo.WebDocument19216801.Start.Click("64;23");
            Delay.Milliseconds(200);
            
            Validate_PingResult();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1356;388.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(17));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1356;388");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.WebDocument19216801' at 1364;380.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(18));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1364;380");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.Fm0' at 1327;48.", repo.WebDocument19216801.Fm0Info, new RecordItemIndex(19));
            repo.WebDocument19216801.Fm0.MoveTo("1327;48");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.LogOut' at 31;8.", repo.WebDocument19216801.LogOutInfo, new RecordItemIndex(20));
            repo.WebDocument19216801.LogOut.Click("31;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Http19216801ToolPingmidEqPing.ClientCaption' at 1339;12.", repo.Http19216801ToolPingmidEqPing.ClientCaptionInfo, new RecordItemIndex(21));
            repo.Http19216801ToolPingmidEqPing.ClientCaption.Click("1339;12");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage AdvancedSettings_Screenshot2
        { get { return repo.WebDocument19216801.AdvancedSettingsInfo.GetScreenshot2(new Rectangle(0, 0, 125, 19)); } }

        Imaging.FindOptions AdvancedSettings_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
