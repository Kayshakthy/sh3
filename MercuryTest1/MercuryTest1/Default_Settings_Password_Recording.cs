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
    ///The Default_Settings_Password_Recording recording.
    /// </summary>
    [TestModule("d1a28b1a-d601-4bdc-afdb-a331b29dd455", ModuleType.Recording, 1)]
    public partial class Default_Settings_Password_Recording : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Default_Settings_Password_Recording instance = new Default_Settings_Password_Recording();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Default_Settings_Password_Recording()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Default_Settings_Password_Recording Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=862,Height=106}) on item 'WebDocumentIE.Hello'.", repo.WebDocumentIE.HelloInfo, new RecordItemIndex(0));
            Validate.ContainsImage(repo.WebDocumentIE.HelloInfo, Hello_Screenshot1, Hello_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocument19216801.Button20'.", repo.WebDocument19216801.Button20Info, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.Button20Info, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Next') on item 'WebDocument19216801.Button20'.", repo.WebDocument19216801.Button20Info, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocument19216801.Button20Info, "TagValue", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Next') on item 'WebDocument19216801.Button20'.", repo.WebDocument19216801.Button20Info, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocument19216801.Button20Info, "Value", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=162,Height=75}) on item 'WebDocument19216801.Button20'.", repo.WebDocument19216801.Button20Info, new RecordItemIndex(4));
            Validate.ContainsImage(repo.WebDocument19216801.Button20Info, Button20_Screenshot2, Button20_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocumentIE.FmRbtnRomanian' at 16;20.", repo.WebDocumentIE.FmRbtnRomanianInfo, new RecordItemIndex(5));
            repo.WebDocumentIE.FmRbtnRomanian.MoveTo("16;20");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocumentIE.FmRbtnRomanian' at 16;20.", repo.WebDocumentIE.FmRbtnRomanianInfo, new RecordItemIndex(6));
            repo.WebDocumentIE.FmRbtnRomanian.MoveTo("16;20");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='tr_English') on item 'WebDocument19216801.TrEnglish'.", repo.WebDocument19216801.TrEnglishInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocument19216801.TrEnglishInfo, "Id", "tr_English");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='') on item 'WebDocument19216801.TrEnglish'.", repo.WebDocument19216801.TrEnglishInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.TrEnglishInfo, "TagValue", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=275,Height=31}) on item 'WebDocument19216801.TrEnglish'.", repo.WebDocument19216801.TrEnglishInfo, new RecordItemIndex(9));
            Validate.ContainsImage(repo.WebDocument19216801.TrEnglishInfo, TrEnglish_Screenshot2, TrEnglish_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnEnglish' at 21;19.", repo.WebDocument19216801.FmRbtnEnglishInfo, new RecordItemIndex(10));
            repo.WebDocument19216801.FmRbtnEnglish.Click("21;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='tr_English') on item 'WebDocument19216801.TrEnglish'.", repo.WebDocument19216801.TrEnglishInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.WebDocument19216801.TrEnglishInfo, "Id", "tr_English");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='') on item 'WebDocument19216801.TrEnglish'.", repo.WebDocument19216801.TrEnglishInfo, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocument19216801.TrEnglishInfo, "TagValue", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=275,Height=31}) on item 'WebDocument19216801.TrEnglish'.", repo.WebDocument19216801.TrEnglishInfo, new RecordItemIndex(13));
            Validate.ContainsImage(repo.WebDocument19216801.TrEnglishInfo, TrEnglish_Screenshot3, TrEnglish_Screenshot3_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Hello!') on item 'WebDocumentIE.Hello'.", repo.WebDocumentIE.HelloInfo, new RecordItemIndex(14));
            Validate.Attribute(repo.WebDocumentIE.HelloInfo, "InnerText", "Hello!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button20' at 91;25.", repo.WebDocument19216801.Button20Info, new RecordItemIndex(15));
            repo.WebDocument19216801.Button20.Click("91;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='LoginPassword') on item 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(16));
            Validate.Attribute(repo.WebDocument19216801.LoginPasswordInfo, "Id", "LoginPassword");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='') on item 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(17));
            Validate.Attribute(repo.WebDocument19216801.LoginPasswordInfo, "TagValue", "");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=360,Height=25}) on item 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(18));
            Validate.ContainsImage(repo.WebDocument19216801.LoginPasswordInfo, LoginPassword_Screenshot2, LoginPassword_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.LoginPassword' at 57;11.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(19));
            repo.WebDocument19216801.LoginPassword.Click("57;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '5643421' with focus on 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(20));
            repo.WebDocument19216801.LoginPassword.PressKeys("5643421");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(21));
            Keyboard.PrepareFocus(repo.WebDocument19216801.LoginPassword);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(22));
            repo.WebDocument19216801.LoginPassword.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '52609343' with focus on 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(23));
            repo.WebDocument19216801.LoginPassword.PressKeys("52609343");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='LoginPassword') on item 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocument19216801.LoginPasswordInfo, "Id", "LoginPassword");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='52609343') on item 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(25));
            Validate.Attribute(repo.WebDocument19216801.LoginPasswordInfo, "TagValue", "52609343");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='52609343') on item 'WebDocument19216801.LoginPassword'.", repo.WebDocument19216801.LoginPasswordInfo, new RecordItemIndex(26));
            Validate.Attribute(repo.WebDocument19216801.LoginPasswordInfo, "Value", "52609343");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button22' at 63;38.", repo.WebDocument19216801.Button22Info, new RecordItemIndex(27));
            repo.WebDocument19216801.Button22.Click("63;38");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.NewPassword13' at 103;8.", repo.WebDocumentIE.NewPassword13Info, new RecordItemIndex(28));
            repo.WebDocumentIE.NewPassword13.Click("103;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}C{LShiftKey up}hangeme0' with focus on 'WebDocumentIE.NewPassword13'.", repo.WebDocumentIE.NewPassword13Info, new RecordItemIndex(29));
            repo.WebDocumentIE.NewPassword13.PressKeys("{LShiftKey down}C{LShiftKey up}hangeme0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.ReenterPassword' at 85;6.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(30));
            repo.WebDocumentIE.ReenterPassword.Click("85;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}C{LShiftKey up}hangeme0' with focus on 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(31));
            repo.WebDocumentIE.ReenterPassword.PressKeys("{LShiftKey down}C{LShiftKey up}hangeme0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='NewPassword13') on item 'WebDocumentIE.NewPassword13'.", repo.WebDocumentIE.NewPassword13Info, new RecordItemIndex(32));
            Validate.Attribute(repo.WebDocumentIE.NewPassword13Info, "Id", "NewPassword13");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Changeme0') on item 'WebDocumentIE.NewPassword13'.", repo.WebDocumentIE.NewPassword13Info, new RecordItemIndex(33));
            Validate.Attribute(repo.WebDocumentIE.NewPassword13Info, "TagValue", "Changeme0");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Changeme0') on item 'WebDocumentIE.NewPassword13'.", repo.WebDocumentIE.NewPassword13Info, new RecordItemIndex(34));
            Validate.Attribute(repo.WebDocumentIE.NewPassword13Info, "Value", "Changeme0");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='ReenterPassword') on item 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(35));
            Validate.Attribute(repo.WebDocumentIE.ReenterPasswordInfo, "Id", "ReenterPassword");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Changeme0') on item 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(36));
            Validate.Attribute(repo.WebDocumentIE.ReenterPasswordInfo, "TagValue", "Changeme0");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Changeme0') on item 'WebDocumentIE.ReenterPassword'.", repo.WebDocumentIE.ReenterPasswordInfo, new RecordItemIndex(37));
            Validate.Attribute(repo.WebDocumentIE.ReenterPasswordInfo, "Value", "Changeme0");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='firstInstall_next') on item 'WebDocumentIE.Button3'.", repo.WebDocumentIE.Button3Info, new RecordItemIndex(38));
            Validate.Attribute(repo.WebDocumentIE.Button3Info, "Class", "firstInstall_next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocumentIE.Button3'.", repo.WebDocumentIE.Button3Info, new RecordItemIndex(39));
            Validate.Attribute(repo.WebDocumentIE.Button3Info, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Next') on item 'WebDocumentIE.Button3'.", repo.WebDocumentIE.Button3Info, new RecordItemIndex(40));
            Validate.Attribute(repo.WebDocumentIE.Button3Info, "TagValue", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Next') on item 'WebDocumentIE.Button3'.", repo.WebDocumentIE.Button3Info, new RecordItemIndex(41));
            Validate.Attribute(repo.WebDocumentIE.Button3Info, "Value", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Button3' at 74;33.", repo.WebDocumentIE.Button3Info, new RecordItemIndex(42));
            repo.WebDocumentIE.Button3.Click("74;33");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='overlaycontent-title') on item 'WebDocumentIE.SeeYouSoon'.", repo.WebDocumentIE.SeeYouSoonInfo, new RecordItemIndex(43));
            Validate.Attribute(repo.WebDocumentIE.SeeYouSoonInfo, "Class", "overlaycontent-title");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='See you soon!') on item 'WebDocumentIE.SeeYouSoon'.", repo.WebDocumentIE.SeeYouSoonInfo, new RecordItemIndex(44));
            Validate.Attribute(repo.WebDocumentIE.SeeYouSoonInfo, "InnerText", "See you soon!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=862,Height=106}) on item 'WebDocumentIE.SeeYouSoon'.", repo.WebDocumentIE.SeeYouSoonInfo, new RecordItemIndex(45));
            Validate.ContainsImage(repo.WebDocumentIE.SeeYouSoonInfo, SeeYouSoon_Screenshot1, SeeYouSoon_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocumentIE.Button4'.", repo.WebDocumentIE.Button4Info, new RecordItemIndex(46));
            Validate.Attribute(repo.WebDocumentIE.Button4Info, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Finish') on item 'WebDocumentIE.Button4'.", repo.WebDocumentIE.Button4Info, new RecordItemIndex(47));
            Validate.Attribute(repo.WebDocumentIE.Button4Info, "TagValue", "Finish");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Finish') on item 'WebDocumentIE.Button4'.", repo.WebDocumentIE.Button4Info, new RecordItemIndex(48));
            Validate.Attribute(repo.WebDocumentIE.Button4Info, "Value", "Finish");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=178,Height=75}) on item 'WebDocumentIE.Button4'.", repo.WebDocumentIE.Button4Info, new RecordItemIndex(49));
            Validate.ContainsImage(repo.WebDocumentIE.Button4Info, Button4_Screenshot1, Button4_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Button4' at 100;31.", repo.WebDocumentIE.Button4Info, new RecordItemIndex(50));
            repo.WebDocumentIE.Button4.Click("100;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='overlaycontent-title') on item 'WebDocumentIE.YourHub30IsReadyToGo'.", repo.WebDocumentIE.YourHub30IsReadyToGoInfo, new RecordItemIndex(51));
            Validate.Attribute(repo.WebDocumentIE.YourHub30IsReadyToGoInfo, "Class", "overlaycontent-title");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your Hub 3.0 is ready to go!') on item 'WebDocumentIE.YourHub30IsReadyToGo'.", repo.WebDocumentIE.YourHub30IsReadyToGoInfo, new RecordItemIndex(52));
            Validate.Attribute(repo.WebDocumentIE.YourHub30IsReadyToGoInfo, "InnerText", "Your Hub 3.0 is ready to go!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=862,Height=106}) on item 'WebDocumentIE.YourHub30IsReadyToGo'.", repo.WebDocumentIE.YourHub30IsReadyToGoInfo, new RecordItemIndex(53));
            Validate.ContainsImage(repo.WebDocumentIE.YourHub30IsReadyToGoInfo, YourHub30IsReadyToGo_Screenshot1, YourHub30IsReadyToGo_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='LoginPassword12') on item 'WebDocumentIE.LoginPassword12'.", repo.WebDocumentIE.LoginPassword12Info, new RecordItemIndex(54));
            Validate.Attribute(repo.WebDocumentIE.LoginPassword12Info, "Id", "LoginPassword12");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.LoginPassword12' at 154;12.", repo.WebDocumentIE.LoginPassword12Info, new RecordItemIndex(55));
            repo.WebDocumentIE.LoginPassword12.Click("154;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}C{LShiftKey up}hangeme0' with focus on 'WebDocumentIE.LoginPassword12'.", repo.WebDocumentIE.LoginPassword12Info, new RecordItemIndex(56));
            repo.WebDocumentIE.LoginPassword12.PressKeys("{LShiftKey down}C{LShiftKey up}hangeme0");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocumentIE.Button5'.", repo.WebDocumentIE.Button5Info, new RecordItemIndex(57));
            Validate.Attribute(repo.WebDocumentIE.Button5Info, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Continue') on item 'WebDocumentIE.Button5'.", repo.WebDocumentIE.Button5Info, new RecordItemIndex(58));
            Validate.Attribute(repo.WebDocumentIE.Button5Info, "TagValue", "Continue");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Type='button') on item 'WebDocumentIE.Button5'.", repo.WebDocumentIE.Button5Info, new RecordItemIndex(59));
            Validate.Attribute(repo.WebDocumentIE.Button5Info, "Type", "button");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Continue') on item 'WebDocumentIE.Button5'.", repo.WebDocumentIE.Button5Info, new RecordItemIndex(60));
            Validate.Attribute(repo.WebDocumentIE.Button5Info, "Value", "Continue");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=231,Height=75}) on item 'WebDocumentIE.Button5'.", repo.WebDocumentIE.Button5Info, new RecordItemIndex(61));
            Validate.ContainsImage(repo.WebDocumentIE.Button5Info, Button5_Screenshot1, Button5_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Button5' at 85;40.", repo.WebDocumentIE.Button5Info, new RecordItemIndex(62));
            repo.WebDocumentIE.Button5.Click("85;40");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage Hello_Screenshot1
        { get { return repo.WebDocumentIE.HelloInfo.GetScreenshot1(new Rectangle(0, 0, 862, 106)); } }

        Imaging.FindOptions Hello_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button20_Screenshot2
        { get { return repo.WebDocument19216801.Button20Info.GetScreenshot2(new Rectangle(0, 0, 162, 75)); } }

        Imaging.FindOptions Button20_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TrEnglish_Screenshot2
        { get { return repo.WebDocument19216801.TrEnglishInfo.GetScreenshot2(new Rectangle(0, 0, 275, 31)); } }

        Imaging.FindOptions TrEnglish_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TrEnglish_Screenshot3
        { get { return repo.WebDocument19216801.TrEnglishInfo.GetScreenshot3(new Rectangle(0, 0, 275, 31)); } }

        Imaging.FindOptions TrEnglish_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage LoginPassword_Screenshot2
        { get { return repo.WebDocument19216801.LoginPasswordInfo.GetScreenshot2(new Rectangle(0, 0, 360, 25)); } }

        Imaging.FindOptions LoginPassword_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SeeYouSoon_Screenshot1
        { get { return repo.WebDocumentIE.SeeYouSoonInfo.GetScreenshot1(new Rectangle(0, 0, 862, 106)); } }

        Imaging.FindOptions SeeYouSoon_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button4_Screenshot1
        { get { return repo.WebDocumentIE.Button4Info.GetScreenshot1(new Rectangle(0, 0, 178, 75)); } }

        Imaging.FindOptions Button4_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage YourHub30IsReadyToGo_Screenshot1
        { get { return repo.WebDocumentIE.YourHub30IsReadyToGoInfo.GetScreenshot1(new Rectangle(0, 0, 862, 106)); } }

        Imaging.FindOptions YourHub30IsReadyToGo_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button5_Screenshot1
        { get { return repo.WebDocumentIE.Button5Info.GetScreenshot1(new Rectangle(0, 0, 231, 75)); } }

        Imaging.FindOptions Button5_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}