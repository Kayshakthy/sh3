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
    ///The WiFi_Network_Name_Validation recording.
    /// </summary>
    [TestModule("28aa5f84-6ca8-4463-8881-ea4a242be4e6", ModuleType.Recording, 1)]
    public partial class WiFi_Network_Name_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static WiFi_Network_Name_Validation instance = new WiFi_Network_Name_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WiFi_Network_Name_Validation()
        {
            Network_Name = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WiFi_Network_Name_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _Network_Name;

        /// <summary>
        /// Gets or sets the value of variable Network_Name.
        /// </summary>
        [TestVariable("63c93b3e-e29a-4eed-9992-cc59faaac4ff")]
        public string Network_Name
        {
            get { return _Network_Name; }
            set { _Network_Name = value; }
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

            //repo.WebDocument19216801.ConfigureYourWiFiConnection.Click("68;23");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Http19216801InternetExplorer.ClientCaption' at 1666;16.", repo.Http19216801InternetExplorer.ClientCaptionInfo, new RecordItemIndex(1));
            //repo.Http19216801InternetExplorer.ClientCaption.Click("1666;16");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Configure your WiFi network') on item 'WebDocument19216801.ConfigureYourWiFiNetwork'.", repo.WebDocument19216801.ConfigureYourWiFiNetworkInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocument19216801.ConfigureYourWiFiNetworkInfo, "InnerText", "Configure your WiFi network");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=225,Height=57}) on item 'WebDocument19216801.ConfigureYourWiFiNetwork'.", repo.WebDocument19216801.ConfigureYourWiFiNetworkInfo, new RecordItemIndex(3));
            //Validate.ContainsImage(repo.WebDocument19216801.ConfigureYourWiFiNetworkInfo, ConfigureYourWiFiNetwork_Screenshot1, ConfigureYourWiFiNetwork_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.ConfigureYourWiFiNetwork.Click("118;17");
            Delay.Milliseconds(0);
            
            //Validate.Attribute(repo.WebDocument19216801.ConfigureYourWiFiConnectionInfo, "InnerText", "Configure your WiFi connection");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=225,Height=57}) on item 'WebDocument19216801.ConfigureYourWiFiConnection'.", repo.WebDocument19216801.ConfigureYourWiFiConnectionInfo, new RecordItemIndex(6));
            //Validate.ContainsImage(repo.WebDocument19216801.ConfigureYourWiFiConnectionInfo, ConfigureYourWiFiConnection_Screenshot1, ConfigureYourWiFiConnection_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument19216801.ConfigureYourWiFiConnection.Click("108;22");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Change') on item 'WebDocument19216801.WiFiNetworkFrame01.Change2'.", repo.WebDocument19216801.WiFiNetworkFrame01.Change2Info, new RecordItemIndex(8));
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkFrame01.Change2Info, "InnerText", "Change");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=56,Height=25}) on item 'WebDocument19216801.WiFiNetworkFrame01.Change2'.", repo.WebDocument19216801.WiFiNetworkFrame01.Change2Info, new RecordItemIndex(9));
            //Validate.ContainsImage(repo.WebDocument19216801.WiFiNetworkFrame01.Change2Info, Change2_Screenshot1, Change2_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.WiFiNetworkFrame01.Change2.Click("19;14");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='WiFiNetworkName') on item 'WebDocument19216801.WiFiNetworkName'.", repo.WebDocument19216801.WiFiNetworkNameInfo, new RecordItemIndex(11));
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkNameInfo, "Id", "WiFiNetworkName");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='_VM0365087_2G') on item 'WebDocument19216801.WiFiNetworkName'.", repo.WebDocument19216801.WiFiNetworkNameInfo, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkNameInfo, "TagValue", "_VM0365087_2G");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='_VM0365087_2G') on item 'WebDocument19216801.WiFiNetworkName'.", repo.WebDocument19216801.WiFiNetworkNameInfo, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkNameInfo, "Value", "_VM0365087_2G");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.NewWiFiNetworkNameInfo, "Id", "NewWiFiNetworkName");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Type='text') on item 'WebDocument19216801.NewWiFiNetworkName'.", repo.WebDocument19216801.NewWiFiNetworkNameInfo, new RecordItemIndex(15));
            //Validate.Attribute(repo.WebDocument19216801.NewWiFiNetworkNameInfo, "Type", "text");
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.NewWiFiNetworkName.Click("108;17");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}T{LShiftKey up}elenet{Tab}{Tab}{Tab}{Tab}' with focus on 'WebDocument19216801.NewWiFiNetworkName'.", repo.WebDocument19216801.NewWiFiNetworkNameInfo, new RecordItemIndex(17));
            //repo.WebDocument19216801.NewWiFiNetworkName.PressKeys("{LShiftKey down}T{LShiftKey up}elenet{Tab}{Tab}{Tab}{Tab}");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.NewWiFiNetworkName'.", repo.WebDocument19216801.NewWiFiNetworkNameInfo, new RecordItemIndex(18));
            Keyboard.PrepareFocus(repo.WebDocument19216801.NewWiFiNetworkName);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.NewWiFiNetworkName'.", repo.WebDocument19216801.NewWiFiNetworkNameInfo, new RecordItemIndex(19));
            repo.WebDocument19216801.NewWiFiNetworkName.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.NewWiFiNetworkName.PressKeys(Network_Name);
            Delay.Milliseconds(0);
            
            Print_SSID_Name(Network_Name);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Apply') on item 'WebDocument19216801.WiFiNetworkFrame01.Button6'.", repo.WebDocument19216801.WiFiNetworkFrame01.Button6Info, new RecordItemIndex(22));
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkFrame01.Button6Info, "TagValue", "Apply");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkFrame01.Button6Info, "Value", "Apply");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=177,Height=75}) on item 'WebDocument19216801.WiFiNetworkFrame01.Button6'.", repo.WebDocument19216801.WiFiNetworkFrame01.Button6Info, new RecordItemIndex(24));
            //Validate.ContainsImage(repo.WebDocument19216801.WiFiNetworkFrame01.Button6Info, Button6_Screenshot2, Button6_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.WiFiNetworkFrame01.Button6.Click("93;25");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='The Network Name you typed is not sufficient') on item 'WebDocumentIE.TheNetworkNameYouTypedIsNotSuffic'.", repo.WebDocumentIE.TheNetworkNameYouTypedIsNotSufficInfo, new RecordItemIndex(26));
            //Validate.Attribute(repo.WebDocumentIE.TheNetworkNameYouTypedIsNotSufficInfo, "InnerText", "The Network Name you typed is not sufficient");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='span') on item 'WebDocumentIE.TheNetworkNameYouTypedIsNotSuffic'.", repo.WebDocumentIE.TheNetworkNameYouTypedIsNotSufficInfo, new RecordItemIndex(27));
            //Validate.Attribute(repo.WebDocumentIE.TheNetworkNameYouTypedIsNotSufficInfo, "TagName", "span");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=211,Height=43}) on item 'WebDocumentIE.TheNetworkNameYouTypedIsNotSuffic'.", repo.WebDocumentIE.TheNetworkNameYouTypedIsNotSufficInfo, new RecordItemIndex(28));
            //Validate.ContainsImage(repo.WebDocumentIE.TheNetworkNameYouTypedIsNotSufficInfo, TheNetworkNameYouTypedIsNotSuffic_Screenshot1, TheNetworkNameYouTypedIsNotSuffic_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='The Network Name you typed is not sufficient.') on item 'WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic4'.", repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic4Info, new RecordItemIndex(29));
            //Validate.Attribute(repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic4Info, "InnerText", "The Network Name you typed is not sufficient.");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-NewWiFiNetworkName') on item 'WebDocument19216801.ErrCloseNewWiFiNetworkName'.", repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, new RecordItemIndex(30));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, "Id", "errClose-NewWiFiNetworkName");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=211,Height=43}) on item 'WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic4'.", repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic4Info, new RecordItemIndex(31));
            //Validate.ContainsImage(repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic4Info, TheNetworkNameYouTypedIsNotSuffic4_Screenshot1, TheNetworkNameYouTypedIsNotSuffic4_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrCloseNewWiFiNetworkName'.", repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, new RecordItemIndex(32));
            //Validate.Attribute(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, "Class", "errTipClose");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='This Network Name cannot be chosen. Please choose another.') on item 'WebDocument19216801.ThisNetworkNameCannotBeChosenPlea'.", repo.WebDocument19216801.ThisNetworkNameCannotBeChosenPleaInfo, new RecordItemIndex(33));
            Validate.Attribute(repo.WebDocument19216801.ThisNetworkNameCannotBeChosenPleaInfo, "InnerText", "This Network Name cannot be chosen. Please choose another.");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=169,Height=35}) on item 'WebDocument19216801.ThisNetworkNameCannotBeChosenPlea'.", repo.WebDocument19216801.ThisNetworkNameCannotBeChosenPleaInfo, new RecordItemIndex(34));
            //Validate.ContainsImage(repo.WebDocument19216801.ThisNetworkNameCannotBeChosenPleaInfo, ThisNetworkNameCannotBeChosenPlea_Screenshot1, ThisNetworkNameCannotBeChosenPlea_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrCloseNewWiFiNetworkName'.", repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, new RecordItemIndex(35));
            //Validate.Attribute(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, "Class", "errTipClose");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-NewWiFiNetworkName') on item 'WebDocument19216801.ErrCloseNewWiFiNetworkName'.", repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, new RecordItemIndex(36));
            //Validate.Attribute(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, "Id", "errClose-NewWiFiNetworkName");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocument19216801.ErrCloseNewWiFiNetworkName'.", repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, new RecordItemIndex(37));
            //Validate.ContainsImage(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, ErrCloseNewWiFiNetworkName_Screenshot1, ErrCloseNewWiFiNetworkName_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='1.  The network name cannot be null. 2.The first and last character of     network name cannot be SPACE. 3.The network name cannot be     reserved SSID.') on item 'WebDocument19216801.SpanTag1TheNetworkNameCannotBeNu'.", repo.WebDocument19216801.SpanTag1TheNetworkNameCannotBeNuInfo, new RecordItemIndex(38));
            //Validate.Attribute(repo.WebDocument19216801.SpanTag1TheNetworkNameCannotBeNuInfo, "InnerText", "1.  The network name cannot be null. 2.The first and last character of     network name cannot be SPACE. 3.The network name cannot be     reserved SSID.");
            //Delay.Milliseconds(100);
            
            //Validate_SpanTag1TheNetworkNameCannotBeNu(Network_Name);
            //Delay.Milliseconds(0);
            
            //Validate.Attribute(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, "Id", "errClose-NewWiFiNetworkName");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, "TagValue", "");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocument19216801.ErrCloseNewWiFiNetworkName'.", repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, new RecordItemIndex(42));
            //Validate.ContainsImage(repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo, ErrCloseNewWiFiNetworkName_Screenshot1_2, ErrCloseNewWiFiNetworkName_Screenshot1_2_Options);
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkFrame01.CancelInfo, "InnerText", "Cancel");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=50,Height=25}) on item 'WebDocument19216801.WiFiNetworkFrame01.Cancel'.", repo.WebDocument19216801.WiFiNetworkFrame01.CancelInfo, new RecordItemIndex(44));
            //Validate.ContainsImage(repo.WebDocument19216801.WiFiNetworkFrame01.CancelInfo, Cancel_Screenshot1, Cancel_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "Network Name", null, false, new RecordItemIndex(45));
            
            repo.WebDocument19216801.WiFiNetworkFrame01.Cancel.MoveTo("36;9");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Close') on item 'WebDocumentIE.Close'.", repo.WebDocumentIE.CloseInfo, new RecordItemIndex(47));
            //Validate.Attribute(repo.WebDocumentIE.CloseInfo, "InnerText", "Close");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=108,Height=56}) on item 'WebDocumentIE.Close'.", repo.WebDocumentIE.CloseInfo, new RecordItemIndex(48));
            //Validate.ContainsImage(repo.WebDocumentIE.CloseInfo, Close_Screenshot1, Close_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Close' at 44;38.", repo.WebDocumentIE.CloseInfo, new RecordItemIndex(49));
            //repo.WebDocumentIE.Close.Click("44;38");
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.WiFiNetworkFrame01.Change2.Click("28;8");
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.NewWiFiNetworkName.Click("60;13");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Network_Name' with focus on 'WebDocument19216801.NewWiFiNetworkName'.", repo.WebDocument19216801.NewWiFiNetworkNameInfo, new RecordItemIndex(52));
            //repo.WebDocument19216801.NewWiFiNetworkName.PressKeys(Network_Name);
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage ConfigureYourWiFiNetwork_Screenshot1
        { get { return repo.WebDocument19216801.ConfigureYourWiFiNetworkInfo.GetScreenshot1(new Rectangle(0, 0, 225, 57)); } }

        Imaging.FindOptions ConfigureYourWiFiNetwork_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ConfigureYourWiFiConnection_Screenshot1
        { get { return repo.WebDocument19216801.ConfigureYourWiFiConnectionInfo.GetScreenshot1(new Rectangle(0, 0, 225, 57)); } }

        Imaging.FindOptions ConfigureYourWiFiConnection_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Change2_Screenshot1
        { get { return repo.WebDocument19216801.WiFiNetworkFrame01.Change2Info.GetScreenshot1(new Rectangle(0, 0, 56, 25)); } }

        Imaging.FindOptions Change2_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button6_Screenshot2
        { get { return repo.WebDocument19216801.WiFiNetworkFrame01.Button6Info.GetScreenshot2(new Rectangle(0, 0, 177, 75)); } }

        Imaging.FindOptions Button6_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TheNetworkNameYouTypedIsNotSuffic_Screenshot1
        { get { return repo.WebDocumentIE.TheNetworkNameYouTypedIsNotSufficInfo.GetScreenshot1(new Rectangle(0, 0, 211, 43)); } }

        Imaging.FindOptions TheNetworkNameYouTypedIsNotSuffic_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TheNetworkNameYouTypedIsNotSuffic4_Screenshot1
        { get { return repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic4Info.GetScreenshot1(new Rectangle(0, 0, 211, 43)); } }

        Imaging.FindOptions TheNetworkNameYouTypedIsNotSuffic4_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ThisNetworkNameCannotBeChosenPlea_Screenshot1
        { get { return repo.WebDocument19216801.ThisNetworkNameCannotBeChosenPleaInfo.GetScreenshot1(new Rectangle(0, 0, 169, 35)); } }

        Imaging.FindOptions ThisNetworkNameCannotBeChosenPlea_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseNewWiFiNetworkName_Screenshot1
        { get { return repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo.GetScreenshot1(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseNewWiFiNetworkName_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseNewWiFiNetworkName_Screenshot1_2
        { get { return repo.WebDocument19216801.ErrCloseNewWiFiNetworkNameInfo.GetScreenshot1(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseNewWiFiNetworkName_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Cancel_Screenshot1
        { get { return repo.WebDocument19216801.WiFiNetworkFrame01.CancelInfo.GetScreenshot1(new Rectangle(0, 0, 50, 25)); } }

        Imaging.FindOptions Cancel_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Close_Screenshot1
        { get { return repo.WebDocumentIE.CloseInfo.GetScreenshot1(new Rectangle(0, 0, 108, 56)); } }

        Imaging.FindOptions Close_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
