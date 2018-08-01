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
    ///The Invalid_Ping_Target_Field_Validation recording.
    /// </summary>
    [TestModule("7d6b4358-3797-4b9e-a69f-fc994bb325e4", ModuleType.Recording, 1)]
    public partial class Invalid_Ping_Target_Field_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Invalid_Ping_Target_Field_Validation instance = new Invalid_Ping_Target_Field_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Invalid_Ping_Target_Field_Validation()
        {
            PingURL = "";
            PingSize = "64";
            No_of_Pings = "3";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Invalid_Ping_Target_Field_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _PingURL;

        /// <summary>
        /// Gets or sets the value of variable PingURL.
        /// </summary>
        [TestVariable("9b8446ce-d321-4654-888e-69ea6a4a27b6")]
        public string PingURL
        {
            get { return _PingURL; }
            set { _PingURL = value; }
        }

        string _PingSize;

        /// <summary>
        /// Gets or sets the value of variable PingSize.
        /// </summary>
        [TestVariable("5ec0f42a-363e-4ff4-9abe-54b613597178")]
        public string PingSize
        {
            get { return _PingSize; }
            set { _PingSize = value; }
        }

        string _No_of_Pings;

        /// <summary>
        /// Gets or sets the value of variable No_of_Pings.
        /// </summary>
        [TestVariable("0d989446-e8ca-463a-8368-bfd8f55d0693")]
        public string No_of_Pings
        {
            get { return _No_of_Pings; }
            set { _No_of_Pings = value; }
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

            repo.WebDocument19216801.AdvancedSettings.Click("69;11");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Tools.Click("17;7");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Ping.Click("18;10");
            Delay.Milliseconds(0);
            
            //Validate.Attribute(repo.WebDocument19216801.Button25Info, "TagValue", "Clear results");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.Button25Info, "Value", "Clear results");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.Button25Info, Button25_Screenshot2, Button25_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument19216801.Button25.Click("85;29");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Target.Click("20;10");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Target);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Target);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Target.PressKeys(PingURL);
            Delay.Milliseconds(200);
            
            repo.WebDocumentIE.Pingsize.Click("36;19");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocumentIE.Pingsize);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.Pingsize.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.Pingsize.PressKeys(PingSize);
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.NoofPings.Click("31;9");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocumentIE.NoofPings);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.NoofPings.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.NoofPings.PressKeys(No_of_Pings);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Start.Click("64;23");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Start' at 89;26.", repo.WebDocument19216801.StartInfo, new RecordItemIndex(20));
            //repo.WebDocument19216801.Start.Click("89;26");
            //Delay.Milliseconds(200);
            
            try {
                //Validate_InvalidInputEnterIPAddressOrName(PingURL, PingSize, No_of_Pings);
                //Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocumentIE.ErrCloseTarget'.", repo.WebDocumentIE.ErrCloseTargetInfo, new RecordItemIndex(22));
            Validate.Attribute(repo.WebDocumentIE.ErrCloseTargetInfo, "Class", "errTipClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-Target') on item 'WebDocumentIE.ErrCloseTarget'.", repo.WebDocumentIE.ErrCloseTargetInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.WebDocumentIE.ErrCloseTargetInfo, "Id", "errClose-Target");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeRegEx (InnerText~'invalid.') on item 'WebDocument19216801.SpanTag1IsInvalid'.", repo.WebDocument19216801.SpanTag1IsInvalidInfo, new RecordItemIndex(24));
            //Validate.Attribute(repo.WebDocument19216801.SpanTag1IsInvalidInfo, "InnerText", new Regex("invalid."));
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.InvalidInputEnterIPAddressOrNameInfo, "InnerText", "Invalid input, enter IP address or name");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errorTip') on item 'WebDocumentIE.ErrTipTarget'.", repo.WebDocumentIE.ErrTipTargetInfo, new RecordItemIndex(26));
            //Validate.Attribute(repo.WebDocumentIE.ErrTipTargetInfo, "Class", "errorTip");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.ErrTipTargetInfo, "Id", "errTip_Target");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocumentIE.ErrCloseTarget'.", repo.WebDocumentIE.ErrCloseTargetInfo, new RecordItemIndex(28));
            //Validate.Attribute(repo.WebDocumentIE.ErrCloseTargetInfo, "Class", "errTipClose");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-Target') on item 'WebDocumentIE.ErrCloseTarget'.", repo.WebDocumentIE.ErrCloseTargetInfo, new RecordItemIndex(29));
            //Validate.Attribute(repo.WebDocumentIE.ErrCloseTargetInfo, "Id", "errClose-Target");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocumentIE.ErrCloseTarget'.", repo.WebDocumentIE.ErrCloseTargetInfo, new RecordItemIndex(30));
            //Validate.ContainsImage(repo.WebDocumentIE.ErrCloseTargetInfo, ErrCloseTarget_Screenshot1, ErrCloseTarget_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(31));
            
        }

#region Image Feature Data
        CompressedImage Button25_Screenshot2
        { get { return repo.WebDocument19216801.Button25Info.GetScreenshot2(new Rectangle(0, 0, 167, 57)); } }

        Imaging.FindOptions Button25_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseTarget_Screenshot1
        { get { return repo.WebDocumentIE.ErrCloseTargetInfo.GetScreenshot1(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseTarget_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
