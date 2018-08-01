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
    ///The EnableGuessNetwork recording.
    /// </summary>
    [TestModule("e3fde964-dbfc-43b7-96f5-b8c76d97df56", ModuleType.Recording, 1)]
    public partial class EnableGuessNetwork : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static EnableGuessNetwork instance = new EnableGuessNetwork();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public EnableGuessNetwork()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static EnableGuessNetwork Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1358;243.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(0));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1358;243");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1355;300.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(1));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1355;300");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Modify Your Guest Network') on item 'WebDocument19216801.ModifyYourGuestNetwork1'.", repo.WebDocument19216801.ModifyYourGuestNetwork1Info, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.ModifyYourGuestNetwork1Info, "InnerText", "Modify Your Guest Network");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=225,Height=57}) on item 'WebDocument19216801.ModifyYourGuestNetwork1'.", repo.WebDocument19216801.ModifyYourGuestNetwork1Info, new RecordItemIndex(3));
            //Validate.ContainsImage(repo.WebDocument19216801.ModifyYourGuestNetwork1Info, ModifyYourGuestNetwork1_Screenshot1, ModifyYourGuestNetwork1_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Modify your Guest network') on item 'WebDocument19216801.ModifyYourGuestNetwork'.", repo.WebDocument19216801.ModifyYourGuestNetworkInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocument19216801.ModifyYourGuestNetworkInfo, "InnerText", "Modify your Guest network");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=310,Height=296}) on item 'WebDocument19216801.ButtonContainers'.", repo.WebDocument19216801.ButtonContainersInfo, new RecordItemIndex(6));
            //Validate.ContainsImage(repo.WebDocument19216801.ButtonContainersInfo, ButtonContainers_Screenshot1, ButtonContainers_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.ModifyYourGuestNetwork1' at 114;23.", repo.WebDocument19216801.ModifyYourGuestNetwork1Info, new RecordItemIndex(7));
            //repo.WebDocument19216801.ModifyYourGuestNetwork1.Click("114;23");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.ModifyYourGuestNetwork' at 102;23.", repo.WebDocument19216801.ModifyYourGuestNetworkInfo, new RecordItemIndex(8));
            repo.WebDocument19216801.ModifyYourGuestNetwork.Click("102;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Guest network') on item 'WebDocument19216801.GuestNetwork'.", repo.WebDocument19216801.GuestNetworkInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument19216801.GuestNetworkInfo, "InnerText", "Guest network");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='This is a secure and separate network which provides  wireless internet access for your guests.  All devices connected to this network will not be able to access your own WiFi network.') on item 'WebDocument19216801.ThisIsASecureAndSeparateNetworkWh'.", repo.WebDocument19216801.ThisIsASecureAndSeparateNetworkWhInfo, new RecordItemIndex(10));
            //Validate.Attribute(repo.WebDocument19216801.ThisIsASecureAndSeparateNetworkWhInfo, "InnerText", "This is a secure and separate network which provides  wireless internet access for your guests.  All devices connected to this network will not be able to access your own WiFi network.");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='This is a secure and separate network which provides wireless internet access for your guests. All devices connected to this network will notbe able to access your own WiFi network.') on item 'WebDocument19216801.ThisIsASecureAndSeparateNetworkWh'.", repo.WebDocument19216801.ThisIsASecureAndSeparateNetworkWhInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.WebDocument19216801.ThisIsASecureAndSeparateNetworkWhInfo, "InnerText", "This is a secure and separate network which provides wireless internet access for your guests. All devices connected to this network will notbe able to access your own WiFi network.");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmCheckbox') on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.FmChbxEnableGuestInfo, "Class", "fmCheckbox");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmChbx-EnableGuest') on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument19216801.FmChbxEnableGuestInfo, "Id", "fmChbx-EnableGuest");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.TrEnableGuest'.", repo.WebDocument19216801.TrEnableGuestInfo, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocument19216801.TrEnableGuestInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.TrEnableGuest'.", repo.WebDocument19216801.TrEnableGuestInfo, new RecordItemIndex(15));
            Validate.Attribute(repo.WebDocument19216801.TrEnableGuestInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxEnableGuest' at 10;18.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(16));
            repo.WebDocument19216801.FmChbxEnableGuest.Click("10;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(17));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnableGuestInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmChbx-EnableGuest') on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(18));
            //Validate.Attribute(repo.WebDocument19216801.FmChbxEnableGuestInfo, "Id", "fmChbx-EnableGuest");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(19));
            //Validate.Exists(repo.WebDocument19216801.FmChbxEnableGuestInfo);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(20));
            Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='enableGuestBtn') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(21));
            Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "Id", "enableGuestBtn");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Enable Guest Network", null, false, new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Next') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "TagValue", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Next') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "Value", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.EnableGuestBtn' at 82;30.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(25));
            repo.WebDocument19216801.EnableGuestBtn.Click("82;30");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxEnableGuest' at 15;13.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(26));
            repo.WebDocument19216801.FmChbxEnableGuest.Click("15;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Enable guest network') on item 'WebDocument19216801.EnableGuestNetwork'.", repo.WebDocument19216801.EnableGuestNetworkInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.WebDocument19216801.EnableGuestNetworkInfo, "InnerText", "Enable guest network");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(28));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnableGuestInfo, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmChbx-EnableGuest') on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(29));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnableGuestInfo, "Id", "fmChbx-EnableGuest");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.FmChbxEnableGuest'.", repo.WebDocument19216801.FmChbxEnableGuestInfo, new RecordItemIndex(30));
            Validate.Exists(repo.WebDocument19216801.FmChbxEnableGuestInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.EnableGuestBtn' at 60;36.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(31));
            repo.WebDocument19216801.EnableGuestBtn.Click("60;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Next') on item 'WebDocument19216801.Button2'.", repo.WebDocument19216801.Button2Info, new RecordItemIndex(32));
            Validate.Attribute(repo.WebDocument19216801.Button2Info, "TagValue", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Next') on item 'WebDocument19216801.Button2'.", repo.WebDocument19216801.Button2Info, new RecordItemIndex(33));
            Validate.Attribute(repo.WebDocument19216801.Button2Info, "Value", "Next");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button2' at 70;37.", repo.WebDocument19216801.Button2Info, new RecordItemIndex(34));
            repo.WebDocument19216801.Button2.Click("70;37");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button3' at 80;31.", repo.WebDocument19216801.Button3Info, new RecordItemIndex(35));
            //repo.WebDocument19216801.Button3.Click("80;31");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxGuestSendEmail' at 14;16.", repo.WebDocument19216801.FmChbxGuestSendEmailInfo, new RecordItemIndex(36));
            //repo.WebDocument19216801.FmChbxGuestSendEmail.Click("14;16");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmChbxGuestSendEmail'.", repo.WebDocument19216801.FmChbxGuestSendEmailInfo, new RecordItemIndex(37));
            //Validate.Attribute(repo.WebDocument19216801.FmChbxGuestSendEmailInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmChbx-GuestSendEmail') on item 'WebDocument19216801.FmChbxGuestSendEmail'.", repo.WebDocument19216801.FmChbxGuestSendEmailInfo, new RecordItemIndex(38));
            //Validate.Attribute(repo.WebDocument19216801.FmChbxGuestSendEmailInfo, "Id", "fmChbx-GuestSendEmail");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.GuestEmail' at 96;9.", repo.WebDocument19216801.GuestEmailInfo, new RecordItemIndex(39));
            //repo.WebDocument19216801.GuestEmail.Click("96;9");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'Karuppannan.Sakthivel@virginmedia.co.uk' with focus on 'WebDocument19216801.GuestEmail'.", repo.WebDocument19216801.GuestEmailInfo, new RecordItemIndex(40));
            //repo.WebDocument19216801.GuestEmail.PressKeys("Karuppannan.Sakthivel@virginmedia.co.uk");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Finish') on item 'WebDocument19216801.Button4'.", repo.WebDocument19216801.Button4Info, new RecordItemIndex(41));
            //Validate.Attribute(repo.WebDocument19216801.Button4Info, "TagValue", "Finish");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Finish') on item 'WebDocument19216801.Button4'.", repo.WebDocument19216801.Button4Info, new RecordItemIndex(42));
            //Validate.Attribute(repo.WebDocument19216801.Button4Info, "Value", "Finish");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button4' at 94;33.", repo.WebDocument19216801.Button4Info, new RecordItemIndex(43));
            //repo.WebDocument19216801.Button4.Click("94;33");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='wizard_button') on item 'WebDocument19216801.GuestNetworkFrame3.Button'.", repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, new RecordItemIndex(44));
            Validate.Attribute(repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, "Class", "wizard_button");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Apply changes') on item 'WebDocument19216801.GuestNetworkFrame3.Button'.", repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, new RecordItemIndex(45));
            //Validate.Attribute(repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, "TagValue", "Apply changes");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Apply changes') on item 'WebDocument19216801.GuestNetworkFrame3.Button'.", repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, new RecordItemIndex(46));
            Validate.Attribute(repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, "Value", "Apply changes");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=315,Height=75}) on item 'WebDocument19216801.GuestNetworkFrame3.Button'.", repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, new RecordItemIndex(47));
            //Validate.ContainsImage(repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, Button_Screenshot1, Button_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.GuestNetworkFrame3.Button' at 156;40.", repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, new RecordItemIndex(48));
            //repo.WebDocument19216801.GuestNetworkFrame3.Button.Click("156;40");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.GuestNetworkFrame3.Button' at 120;24.", repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, new RecordItemIndex(49));
            repo.WebDocument19216801.GuestNetworkFrame3.Button.Click("120;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your guest network settings have been updated.') on item 'WebDocument19216801.YourGuestNetworkSettingsHaveBeenUp'.", repo.WebDocument19216801.YourGuestNetworkSettingsHaveBeenUpInfo, new RecordItemIndex(50));
            Validate.Attribute(repo.WebDocument19216801.YourGuestNetworkSettingsHaveBeenUpInfo, "InnerText", "Your guest network settings have been updated.");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=862,Height=25}) on item 'WebDocument19216801.YourGuestNetworkSettingsHaveBeenUp'.", repo.WebDocument19216801.YourGuestNetworkSettingsHaveBeenUpInfo, new RecordItemIndex(51));
            //Validate.ContainsImage(repo.WebDocument19216801.YourGuestNetworkSettingsHaveBeenUpInfo, YourGuestNetworkSettingsHaveBeenUp_Screenshot1, YourGuestNetworkSettingsHaveBeenUp_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='circle') on item 'WebDocument19216801.Circle'.", repo.WebDocument19216801.CircleInfo, new RecordItemIndex(52));
            Validate.Attribute(repo.WebDocument19216801.CircleInfo, "TagName", "circle");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=58,Height=57}) on item 'WebDocument19216801.Circle'.", repo.WebDocument19216801.CircleInfo, new RecordItemIndex(53));
            //Validate.ContainsImage(repo.WebDocument19216801.CircleInfo, Circle_Screenshot1, Circle_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(54));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Close') on item 'WebDocument19216801.Button26'.", repo.WebDocument19216801.Button26Info, new RecordItemIndex(55));
            Validate.Attribute(repo.WebDocument19216801.Button26Info, "TagValue", "Close");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Close') on item 'WebDocument19216801.Button26'.", repo.WebDocument19216801.Button26Info, new RecordItemIndex(56));
            Validate.Attribute(repo.WebDocument19216801.Button26Info, "Value", "Close");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Enable Guest Network", null, false, new RecordItemIndex(57));
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=176,Height=75}) on item 'WebDocument19216801.Button26'.", repo.WebDocument19216801.Button26Info, new RecordItemIndex(58));
            //Validate.ContainsImage(repo.WebDocument19216801.Button26Info, Button26_Screenshot1, Button26_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button26' at 83;44.", repo.WebDocument19216801.Button26Info, new RecordItemIndex(59));
            repo.WebDocument19216801.Button26.Click("83;44");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1356;267.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(60));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1356;267");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1353;124.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(61));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1353;124");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage ModifyYourGuestNetwork1_Screenshot1
        { get { return repo.WebDocument19216801.ModifyYourGuestNetwork1Info.GetScreenshot1(new Rectangle(0, 0, 225, 57)); } }

        Imaging.FindOptions ModifyYourGuestNetwork1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ButtonContainers_Screenshot1
        { get { return repo.WebDocument19216801.ButtonContainersInfo.GetScreenshot1(new Rectangle(0, 0, 310, 296)); } }

        Imaging.FindOptions ButtonContainers_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button_Screenshot1
        { get { return repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo.GetScreenshot1(new Rectangle(0, 0, 315, 75)); } }

        Imaging.FindOptions Button_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage YourGuestNetworkSettingsHaveBeenUp_Screenshot1
        { get { return repo.WebDocument19216801.YourGuestNetworkSettingsHaveBeenUpInfo.GetScreenshot1(new Rectangle(0, 0, 862, 25)); } }

        Imaging.FindOptions YourGuestNetworkSettingsHaveBeenUp_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Circle_Screenshot1
        { get { return repo.WebDocument19216801.CircleInfo.GetScreenshot1(new Rectangle(0, 0, 58, 57)); } }

        Imaging.FindOptions Circle_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button26_Screenshot1
        { get { return repo.WebDocument19216801.Button26Info.GetScreenshot1(new Rectangle(0, 0, 176, 75)); } }

        Imaging.FindOptions Button26_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}