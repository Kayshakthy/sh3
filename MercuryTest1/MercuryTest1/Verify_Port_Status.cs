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
    ///The Verify_Port_Status recording.
    /// </summary>
    [TestModule("2f4e0bb7-589c-44c8-a5d7-18d75d428c1e", ModuleType.Recording, 1)]
    public partial class Verify_Port_Status : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Verify_Port_Status instance = new Verify_Port_Status();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Verify_Port_Status()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Verify_Port_Status Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'www.grc.com/shieldsup' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("www.grc.com/shieldsup", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Welcome to ShieldsUP!') on item 'WebDocumentIE.WelcomeToShieldsUP'.", repo.WebDocumentIE.WelcomeToShieldsUPInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocumentIE.WelcomeToShieldsUPInfo, "InnerText", "Welcome to ShieldsUP!");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=348,Height=36}) on item 'WebDocumentIE.WelcomeToShieldsUP'.", repo.WebDocumentIE.WelcomeToShieldsUPInfo, new RecordItemIndex(2));
            //Validate.ContainsImage(repo.WebDocumentIE.WelcomeToShieldsUPInfo, WelcomeToShieldsUP_Screenshot1, WelcomeToShieldsUP_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='    Proceed    ') on item 'WebDocumentIE.InputTag12'.", repo.WebDocumentIE.InputTag12Info, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocumentIE.InputTag12Info, "TagValue", "    Proceed    ");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='    Proceed    ') on item 'WebDocumentIE.InputTag12'.", repo.WebDocumentIE.InputTag12Info, new RecordItemIndex(4));
            Validate.Attribute(repo.WebDocumentIE.InputTag12Info, "Value", "    Proceed    ");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=125,Height=28}) on item 'WebDocumentIE.InputTag12'.", repo.WebDocumentIE.InputTag12Info, new RecordItemIndex(5));
            //Validate.ContainsImage(repo.WebDocumentIE.InputTag12Info, InputTag12_Screenshot1, InputTag12_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.InputTag12' at 60;15.", repo.WebDocumentIE.InputTag12Info, new RecordItemIndex(6));
            repo.WebDocumentIE.InputTag12.Click("60;15");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=360,Height=25}) on item 'WebDocumentIE.SomeTdTag'.", repo.WebDocumentIE.SomeTdTagInfo, new RecordItemIndex(7));
            //Validate.ContainsImage(repo.WebDocumentIE.SomeTdTagInfo, SomeTdTag_Screenshot1, SomeTdTag_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.InputTag7' at 65;8.", repo.WebDocumentIE.InputTag7Info, new RecordItemIndex(8));
            repo.WebDocumentIE.InputTag7.Click("65;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Determine the status of yoursystem's first 1056 ports') on item 'WebDocumentIE.DetermineTheStatusOfYoursystemsFirs'.", repo.WebDocumentIE.DetermineTheStatusOfYoursystemsFirsInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocumentIE.DetermineTheStatusOfYoursystemsFirsInfo, "InnerText", "Determine the status of yoursystem's first 1056 ports");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=306,Height=52}) on item 'WebDocumentIE.DetermineTheStatusOfYoursystemsFirs'.", repo.WebDocumentIE.DetermineTheStatusOfYoursystemsFirsInfo, new RecordItemIndex(10));
            //Validate.ContainsImage(repo.WebDocumentIE.DetermineTheStatusOfYoursystemsFirsInfo, DetermineTheStatusOfYoursystemsFirs_Screenshot1, DetermineTheStatusOfYoursystemsFirs_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.SomeCenterTag' at 1719;463.", repo.WebDocumentIE.SomeCenterTagInfo, new RecordItemIndex(11));
            repo.WebDocumentIE.SomeCenterTag.Click("1719;463");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -820 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(-820);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 2s.", new RecordItemIndex(13));
            Delay.Duration(2000, false);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='1055') on item 'WebDocumentIE.FontTag1055'.", repo.WebDocumentIE.FontTag1055Info, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocumentIE.FontTag1055Info, "InnerText", "1055");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=30,Height=15}) on item 'WebDocumentIE.FontTag1055'.", repo.WebDocumentIE.FontTag1055Info, new RecordItemIndex(15));
            //Validate.ContainsImage(repo.WebDocumentIE.FontTag1055Info, FontTag1055_Screenshot1, FontTag1055_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Solicited TCP Packets: ') on item 'WebDocumentIE.SolicitedTCPPackets'.", repo.WebDocumentIE.SolicitedTCPPacketsInfo, new RecordItemIndex(16));
            //Validate.Attribute(repo.WebDocumentIE.SolicitedTCPPacketsInfo, "InnerText", "Solicited TCP Packets: ");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=212,Height=16}) on item 'WebDocumentIE.SolicitedTCPPackets'.", repo.WebDocumentIE.SolicitedTCPPacketsInfo, new RecordItemIndex(17));
            //Validate.ContainsImage(repo.WebDocumentIE.SolicitedTCPPacketsInfo, SolicitedTCPPackets_Screenshot1, SolicitedTCPPackets_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Unsolicited Packets: ') on item 'WebDocumentIE.UnsolicitedPackets'.", repo.WebDocumentIE.UnsolicitedPacketsInfo, new RecordItemIndex(18));
            //Validate.Attribute(repo.WebDocumentIE.UnsolicitedPacketsInfo, "InnerText", "Unsolicited Packets: ");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=198,Height=15}) on item 'WebDocumentIE.UnsolicitedPackets'.", repo.WebDocumentIE.UnsolicitedPacketsInfo, new RecordItemIndex(19));
            //Validate.ContainsImage(repo.WebDocumentIE.UnsolicitedPacketsInfo, UnsolicitedPackets_Screenshot1, UnsolicitedPackets_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate_UnsolicitedPackets();
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Stealth') on item 'WebDocumentIE.Stealth'.", repo.WebDocumentIE.StealthInfo, new RecordItemIndex(21));
            //Validate.Attribute(repo.WebDocumentIE.StealthInfo, "InnerText", "Stealth");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Stealth') on item 'WebDocumentIE.Stealth1'.", repo.WebDocumentIE.Stealth1Info, new RecordItemIndex(22));
            //Validate.Attribute(repo.WebDocumentIE.Stealth1Info, "InnerText", "Stealth");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'GRCShieldsUPServicePortsProbe.ClientCaption' at 1889;22.", repo.GRCShieldsUPServicePortsProbe.ClientCaptionInfo, new RecordItemIndex(23));
            repo.GRCShieldsUPServicePortsProbe.ClientCaption.Click("1889;22");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage WelcomeToShieldsUP_Screenshot1
        { get { return repo.WebDocumentIE.WelcomeToShieldsUPInfo.GetScreenshot1(new Rectangle(0, 0, 348, 36)); } }

        Imaging.FindOptions WelcomeToShieldsUP_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage InputTag12_Screenshot1
        { get { return repo.WebDocumentIE.InputTag12Info.GetScreenshot1(new Rectangle(0, 0, 125, 28)); } }

        Imaging.FindOptions InputTag12_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SomeTdTag_Screenshot1
        { get { return repo.WebDocumentIE.SomeTdTagInfo.GetScreenshot1(new Rectangle(0, 0, 360, 25)); } }

        Imaging.FindOptions SomeTdTag_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage DetermineTheStatusOfYoursystemsFirs_Screenshot1
        { get { return repo.WebDocumentIE.DetermineTheStatusOfYoursystemsFirsInfo.GetScreenshot1(new Rectangle(0, 0, 306, 52)); } }

        Imaging.FindOptions DetermineTheStatusOfYoursystemsFirs_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage FontTag1055_Screenshot1
        { get { return repo.WebDocumentIE.FontTag1055Info.GetScreenshot1(new Rectangle(0, 0, 30, 15)); } }

        Imaging.FindOptions FontTag1055_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SolicitedTCPPackets_Screenshot1
        { get { return repo.WebDocumentIE.SolicitedTCPPacketsInfo.GetScreenshot1(new Rectangle(0, 0, 212, 16)); } }

        Imaging.FindOptions SolicitedTCPPackets_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage UnsolicitedPackets_Screenshot1
        { get { return repo.WebDocumentIE.UnsolicitedPacketsInfo.GetScreenshot1(new Rectangle(0, 0, 198, 15)); } }

        Imaging.FindOptions UnsolicitedPackets_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage UnsolicitedPackets_Screenshot1_2
        { get { return repo.WebDocumentIE.UnsolicitedPacketsInfo.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions UnsolicitedPackets_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
