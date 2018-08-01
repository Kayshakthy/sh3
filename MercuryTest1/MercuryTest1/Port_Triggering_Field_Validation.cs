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
    ///The Port_Triggering_Field_Validation recording.
    /// </summary>
    [TestModule("c92b01e6-8f27-42b5-aec4-b69f6f2aceaa", ModuleType.Recording, 1)]
    public partial class Port_Triggering_Field_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Port_Triggering_Field_Validation instance = new Port_Triggering_Field_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Port_Triggering_Field_Validation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Port_Triggering_Field_Validation Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.TriggerStartPort' at 31;11.", repo.WebDocument19216801.TriggerStartPortInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.TriggerStartPort.Click("31;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.TriggerStartPort'.", repo.WebDocument19216801.TriggerStartPortInfo, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.WebDocument19216801.TriggerStartPort);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete down}{Back down}{Delete up}{Back up}' with focus on 'WebDocument19216801.TriggerStartPort'.", repo.WebDocument19216801.TriggerStartPortInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.TriggerStartPort.PressKeys("{Delete down}{Back down}{Delete up}{Back up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-1' with focus on 'WebDocument19216801.TriggerStartPort'.", repo.WebDocument19216801.TriggerStartPortInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.TriggerStartPort.PressKeys("-1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.TriggerEndPort' at 23;7.", repo.WebDocument19216801.TriggerEndPortInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.TriggerEndPort.Click("23;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.TriggerEndPort'.", repo.WebDocument19216801.TriggerEndPortInfo, new RecordItemIndex(5));
            Keyboard.PrepareFocus(repo.WebDocument19216801.TriggerEndPort);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.TriggerEndPort'.", repo.WebDocument19216801.TriggerEndPortInfo, new RecordItemIndex(6));
            repo.WebDocument19216801.TriggerEndPort.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-1' with focus on 'WebDocument19216801.TriggerEndPort'.", repo.WebDocument19216801.TriggerEndPortInfo, new RecordItemIndex(7));
            repo.WebDocument19216801.TriggerEndPort.PressKeys("-1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.TargetStartPort' at 30;3.", repo.WebDocument19216801.TargetStartPortInfo, new RecordItemIndex(8));
            repo.WebDocument19216801.TargetStartPort.Click("30;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.TargetStartPort'.", repo.WebDocument19216801.TargetStartPortInfo, new RecordItemIndex(9));
            Keyboard.PrepareFocus(repo.WebDocument19216801.TargetStartPort);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-1' with focus on 'WebDocument19216801.TargetStartPort'.", repo.WebDocument19216801.TargetStartPortInfo, new RecordItemIndex(10));
            repo.WebDocument19216801.TargetStartPort.PressKeys("-1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Tab}' with focus on 'WebDocument19216801.TargetStartPort'.", repo.WebDocument19216801.TargetStartPortInfo, new RecordItemIndex(11));
            repo.WebDocument19216801.TargetStartPort.PressKeys("{Tab}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey down}'.", new RecordItemIndex(12));
            //Keyboard.Press("{LControlKey down}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}'.", new RecordItemIndex(13));
            //Keyboard.Press("{LControlKey up}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}'.", new RecordItemIndex(14));
            //Keyboard.Press("{Delete}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '0' with focus on 'WebDocument19216801.TargetEndPort'.", repo.WebDocument19216801.TargetEndPortInfo, new RecordItemIndex(15));
            repo.WebDocument19216801.TargetEndPort.PressKeys("0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.TargetEndPort'.", repo.WebDocument19216801.TargetEndPortInfo, new RecordItemIndex(16));
            Keyboard.PrepareFocus(repo.WebDocument19216801.TargetEndPort);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.TargetEndPort'.", repo.WebDocument19216801.TargetEndPortInfo, new RecordItemIndex(17));
            repo.WebDocument19216801.TargetEndPort.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '-1' with focus on 'WebDocument19216801.TargetEndPort'.", repo.WebDocument19216801.TargetEndPortInfo, new RecordItemIndex(18));
            repo.WebDocument19216801.TargetEndPort.PressKeys("-1");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.PleaseChoose' at 194;22.", repo.WebDocument19216801.FmSelProtocol.PleaseChooseInfo, new RecordItemIndex(19));
            repo.WebDocument19216801.FmSelProtocol.PleaseChoose.Click("194;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}' with focus on 'WebDocument19216801.FmSelProtocol.SomeSpanTag8'.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(20));
            repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.PressKeys("{Down}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.PleaseChoose' at 194;16.", repo.WebDocument19216801.FmSelEnabled.PleaseChooseInfo, new RecordItemIndex(21));
            repo.WebDocument19216801.FmSelEnabled.PleaseChoose.Click("194;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.LiTagOn' at 38;13.", repo.WebDocument19216801.FmSelEnabled.LiTagOnInfo, new RecordItemIndex(22));
            repo.WebDocument19216801.FmSelEnabled.LiTagOn.Click("38;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.ApplyAddRule' at 76;25.", repo.WebDocument19216801.ApplyAddRuleInfo, new RecordItemIndex(23));
            repo.WebDocument19216801.ApplyAddRule.Click("76;25");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='-1 is invalid. Port number must be between 1 and 65535.') on item 'WebDocument19216801.SpanTag1IsInvalidPortNumberMustB'.", repo.WebDocument19216801.SpanTag1IsInvalidPortNumberMustBInfo, new RecordItemIndex(24));
            //Validate.Attribute(repo.WebDocument19216801.SpanTag1IsInvalidPortNumberMustBInfo, "InnerText", "-1 is invalid. Port number must be between 1 and 65535.");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-TargetStartPort') on item 'WebDocumentIE.ErrCloseTargetStartPort'.", repo.WebDocumentIE.ErrCloseTargetStartPortInfo, new RecordItemIndex(25));
            Validate.Attribute(repo.WebDocumentIE.ErrCloseTargetStartPortInfo, "Id", "errClose-TargetStartPort");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocumentIE.ErrCloseTargetStartPort'.", repo.WebDocumentIE.ErrCloseTargetStartPortInfo, new RecordItemIndex(26));
            //Validate.ContainsImage(repo.WebDocumentIE.ErrCloseTargetStartPortInfo, ErrCloseTargetStartPort_Screenshot2, ErrCloseTargetStartPort_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-TriggerStartPort') on item 'WebDocumentIE.ErrCloseTriggerStartPort'.", repo.WebDocumentIE.ErrCloseTriggerStartPortInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.WebDocumentIE.ErrCloseTriggerStartPortInfo, "Id", "errClose-TriggerStartPort");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocumentIE.ErrCloseTriggerStartPort'.", repo.WebDocumentIE.ErrCloseTriggerStartPortInfo, new RecordItemIndex(28));
            //Validate.ContainsImage(repo.WebDocumentIE.ErrCloseTriggerStartPortInfo, ErrCloseTriggerStartPort_Screenshot2, ErrCloseTriggerStartPort_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-TriggerEndPort') on item 'WebDocumentIE.ErrCloseTriggerEndPort'.", repo.WebDocumentIE.ErrCloseTriggerEndPortInfo, new RecordItemIndex(29));
            Validate.Attribute(repo.WebDocumentIE.ErrCloseTriggerEndPortInfo, "Id", "errClose-TriggerEndPort");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocumentIE.ErrCloseTriggerEndPort'.", repo.WebDocumentIE.ErrCloseTriggerEndPortInfo, new RecordItemIndex(30));
            //Validate.ContainsImage(repo.WebDocumentIE.ErrCloseTriggerEndPortInfo, ErrCloseTriggerEndPort_Screenshot3, ErrCloseTriggerEndPort_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-TargetEndPort') on item 'WebDocumentIE.ErrCloseTargetEndPort'.", repo.WebDocumentIE.ErrCloseTargetEndPortInfo, new RecordItemIndex(31));
            Validate.Attribute(repo.WebDocumentIE.ErrCloseTargetEndPortInfo, "Id", "errClose-TargetEndPort");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocumentIE.ErrCloseTargetEndPort'.", repo.WebDocumentIE.ErrCloseTargetEndPortInfo, new RecordItemIndex(32));
            //Validate.ContainsImage(repo.WebDocumentIE.ErrCloseTargetEndPortInfo, ErrCloseTargetEndPort_Screenshot2, ErrCloseTargetEndPort_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(33));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.BtnCancel' at 55;29.", repo.WebDocument19216801.BtnCancelInfo, new RecordItemIndex(34));
            repo.WebDocument19216801.BtnCancel.Click("55;29");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage ErrCloseTargetStartPort_Screenshot2
        { get { return repo.WebDocumentIE.ErrCloseTargetStartPortInfo.GetScreenshot2(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseTargetStartPort_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseTriggerStartPort_Screenshot2
        { get { return repo.WebDocumentIE.ErrCloseTriggerStartPortInfo.GetScreenshot2(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseTriggerStartPort_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseTriggerEndPort_Screenshot3
        { get { return repo.WebDocumentIE.ErrCloseTriggerEndPortInfo.GetScreenshot3(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseTriggerEndPort_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseTargetEndPort_Screenshot2
        { get { return repo.WebDocumentIE.ErrCloseTargetEndPortInfo.GetScreenshot2(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseTargetEndPort_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
