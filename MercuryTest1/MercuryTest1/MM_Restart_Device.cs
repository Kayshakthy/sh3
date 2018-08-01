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
    ///The MM_Restart_Device recording.
    /// </summary>
    [TestModule("2f285a7e-afd1-434b-ab55-0320d444de9b", ModuleType.Recording, 1)]
    public partial class MM_Restart_Device : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static MM_Restart_Device instance = new MM_Restart_Device();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MM_Restart_Device()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MM_Restart_Device Instance
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
            
            repo.WebDocumentIE.Admin.Click("35;16");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocumentIE.ReloadAndRebootInfo, "InnerText", "Reload and Reboot");
            Delay.Milliseconds(100);
            
            repo.WebDocumentIE.ReloadAndReboot.Click("39;6");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocument1921681001.LabelReloadAndRebootInfo, "InnerText", "Reload and Reboot");
            Delay.Milliseconds(100);
            
            repo.WebDocument1921681001.Self.MoveTo("1905;449");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            repo.WebDocument1921681001.Self.MoveTo("1887;678");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument1921681001.RestoreDefInfo, "Value", "Restore default");
            //Delay.Milliseconds(100);
            
            //repo.WebDocument1921681001.RestoreDef.Click("75;27");
            //Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument1921681001.EnableGuestBtnInfo, "Id", "enableGuestBtn");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument1921681001.EnableGuestBtnInfo, "Value", "Restore defaults");
            //Delay.Milliseconds(100);
            
            //repo.WebDocument1921681001.EnableGuestBtn.Click("219;43");
            //Delay.Milliseconds(200);
            
            //repo.WebDocument1921681001.Overlaycontainer1.Overlaycontainer.MoveTo("1893;129");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument1921681001.Overlaycontainer1.CloseInfo, "InnerText", "Close");
            //Delay.Milliseconds(100);
            
            //repo.WebDocument1921681001.Overlaycontainer1.Close.Click("49;33");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='submitNoBg BtnReboot') on item 'WebDocumentIE.Button2'.", repo.WebDocumentIE.Button2Info, new RecordItemIndex(15));
            Validate.Attribute(repo.WebDocumentIE.Button2Info, "Class", "submitNoBg BtnReboot");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Reboot') on item 'WebDocumentIE.Button2'.", repo.WebDocumentIE.Button2Info, new RecordItemIndex(16));
            Validate.Attribute(repo.WebDocumentIE.Button2Info, "TagValue", "Reboot");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Reboot') on item 'WebDocumentIE.Button2'.", repo.WebDocumentIE.Button2Info, new RecordItemIndex(17));
            Validate.Attribute(repo.WebDocumentIE.Button2Info, "Value", "Reboot");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=94,Height=46}) on item 'WebDocumentIE.Button2'.", repo.WebDocumentIE.Button2Info, new RecordItemIndex(18));
            Validate.ContainsImage(repo.WebDocumentIE.Button2Info, Button2_Screenshot2, Button2_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Clicking on the 'Reboot' button will restart your Hub 3.0 immediately. This can take up to 5 minutes to complete.') on item 'WebDocumentIE.ClickingOnTheRebootButtonWillResta'.", repo.WebDocumentIE.ClickingOnTheRebootButtonWillRestaInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.WebDocumentIE.ClickingOnTheRebootButtonWillRestaInfo, "InnerText", "Clicking on the 'Reboot' button will restart your Hub 3.0 immediately. This can take up to 5 minutes to complete.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=700,Height=16}) on item 'WebDocumentIE.ClickingOnTheRebootButtonWillResta'.", repo.WebDocumentIE.ClickingOnTheRebootButtonWillRestaInfo, new RecordItemIndex(20));
            Validate.ContainsImage(repo.WebDocumentIE.ClickingOnTheRebootButtonWillRestaInfo, ClickingOnTheRebootButtonWillResta_Screenshot1, ClickingOnTheRebootButtonWillResta_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Button2' at 59;25.", repo.WebDocumentIE.Button2Info, new RecordItemIndex(21));
            repo.WebDocumentIE.Button2.Click("59;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by 240 units.", new RecordItemIndex(22));
            Mouse.ScrollWheel(240);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='wizard_button') on item 'WebDocumentIE.Button1'.", repo.WebDocumentIE.Button1Info, new RecordItemIndex(23));
            Validate.Attribute(repo.WebDocumentIE.Button1Info, "Class", "wizard_button");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Cancel process') on item 'WebDocumentIE.Button1'.", repo.WebDocumentIE.Button1Info, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocumentIE.Button1Info, "TagValue", "Cancel process");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Cancel process') on item 'WebDocumentIE.Button1'.", repo.WebDocumentIE.Button1Info, new RecordItemIndex(25));
            Validate.Attribute(repo.WebDocumentIE.Button1Info, "Value", "Cancel process");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=262,Height=60}) on item 'WebDocumentIE.Button1'.", repo.WebDocumentIE.Button1Info, new RecordItemIndex(26));
            Validate.ContainsImage(repo.WebDocumentIE.Button1Info, Button1_Screenshot1, Button1_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='enableRestartBtn') on item 'WebDocumentIE.EnableRestartBtn'.", repo.WebDocumentIE.EnableRestartBtnInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.WebDocumentIE.EnableRestartBtnInfo, "Id", "enableRestartBtn");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Restart') on item 'WebDocumentIE.EnableRestartBtn'.", repo.WebDocumentIE.EnableRestartBtnInfo, new RecordItemIndex(28));
            Validate.Attribute(repo.WebDocumentIE.EnableRestartBtnInfo, "TagValue", "Restart");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Restart') on item 'WebDocumentIE.EnableRestartBtn'.", repo.WebDocumentIE.EnableRestartBtnInfo, new RecordItemIndex(29));
            Validate.Attribute(repo.WebDocumentIE.EnableRestartBtnInfo, "Value", "Restart");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=163,Height=60}) on item 'WebDocumentIE.EnableRestartBtn'.", repo.WebDocumentIE.EnableRestartBtnInfo, new RecordItemIndex(30));
            Validate.ContainsImage(repo.WebDocumentIE.EnableRestartBtnInfo, EnableRestartBtn_Screenshot1, EnableRestartBtn_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Button1' at 210;31.", repo.WebDocumentIE.Button1Info, new RecordItemIndex(31));
            repo.WebDocumentIE.Button1.Click("210;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -1080 units.", new RecordItemIndex(32));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Button2' at 46;26.", repo.WebDocumentIE.Button2Info, new RecordItemIndex(33));
            repo.WebDocumentIE.Button2.Click("46;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by 360 units.", new RecordItemIndex(34));
            Mouse.ScrollWheel(360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.EnableRestartBtn' at 98;27.", repo.WebDocumentIE.EnableRestartBtnInfo, new RecordItemIndex(35));
            repo.WebDocumentIE.EnableRestartBtn.Click("98;27");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage Button2_Screenshot2
        { get { return repo.WebDocumentIE.Button2Info.GetScreenshot2(new Rectangle(0, 0, 94, 46)); } }

        Imaging.FindOptions Button2_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ClickingOnTheRebootButtonWillResta_Screenshot1
        { get { return repo.WebDocumentIE.ClickingOnTheRebootButtonWillRestaInfo.GetScreenshot1(new Rectangle(0, 0, 700, 16)); } }

        Imaging.FindOptions ClickingOnTheRebootButtonWillResta_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button1_Screenshot1
        { get { return repo.WebDocumentIE.Button1Info.GetScreenshot1(new Rectangle(0, 0, 262, 60)); } }

        Imaging.FindOptions Button1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage EnableRestartBtn_Screenshot1
        { get { return repo.WebDocumentIE.EnableRestartBtnInfo.GetScreenshot1(new Rectangle(0, 0, 163, 60)); } }

        Imaging.FindOptions EnableRestartBtn_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}