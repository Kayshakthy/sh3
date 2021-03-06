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
    ///The Apply_Guest_Network_SSID_Name_Change recording.
    /// </summary>
    [TestModule("200da280-1369-4cba-ad80-8032323ce074", ModuleType.Recording, 1)]
    public partial class Apply_Guest_Network_SSID_Name_Change : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Apply_Guest_Network_SSID_Name_Change instance = new Apply_Guest_Network_SSID_Name_Change();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Apply_Guest_Network_SSID_Name_Change()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Apply_Guest_Network_SSID_Name_Change Instance
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

            repo.WebDocument19216801.Button7.Click("99;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(1));
            Delay.Duration(1000, false);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='WiFi Network Name (SSID) is over max length 32.') on item 'WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLen'.", repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, "InnerText", "WiFi Network Name (SSID) is over max length 32.");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (spellcheck='True') on item 'WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLen'.", repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, "spellcheck", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=223,Height=43}) on item 'WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLen'.", repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, new RecordItemIndex(4));
            //Validate.ContainsImage(repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo, WiFiNetworkNameSSIDIsOverMaxLen_Screenshot1, WiFiNetworkNameSSIDIsOverMaxLen_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrCloseNetworkSSID'.", repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, "Class", "errTipClose");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-NetworkSSID') on item 'WebDocument19216801.ErrCloseNetworkSSID'.", repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, "Id", "errClose-NetworkSSID");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocument19216801.ErrCloseNetworkSSID'.", repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, new RecordItemIndex(7));
            //Validate.ContainsImage(repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, ErrCloseNetworkSSID_Screenshot1, ErrCloseNetworkSSID_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrCloseNetworkSSID'.", repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, "Class", "errTipClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-NetworkSSID') on item 'WebDocument19216801.ErrCloseNetworkSSID'.", repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, "Id", "errClose-NetworkSSID");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='The network name you typed is not sufficient') on item 'WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic3'.", repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic3Info, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic3Info, "InnerText", "The network name you typed is not sufficient");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=241,Height=47}) on item 'WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic3'.", repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic3Info, new RecordItemIndex(11));
            Validate.ContainsImage(repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic3Info, TheNetworkNameYouTypedIsNotSuffic3_Screenshot1, TheNetworkNameYouTypedIsNotSuffic3_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=33,Height=39}) on item 'WebDocument19216801.ErrCloseNetworkSSID'.", repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, new RecordItemIndex(12));
            //Validate.ContainsImage(repo.WebDocument19216801.ErrCloseNetworkSSIDInfo, ErrCloseNetworkSSID_Screenshot2, ErrCloseNetworkSSID_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            //Capture_Screen_For_Result();
            //Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(14));
            
        }

#region Image Feature Data
        CompressedImage WiFiNetworkNameSSIDIsOverMaxLen_Screenshot1
        { get { return repo.WebDocument19216801.WiFiNetworkNameSSIDIsOverMaxLenInfo.GetScreenshot1(new Rectangle(0, 0, 223, 43)); } }

        Imaging.FindOptions WiFiNetworkNameSSIDIsOverMaxLen_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseNetworkSSID_Screenshot1
        { get { return repo.WebDocument19216801.ErrCloseNetworkSSIDInfo.GetScreenshot1(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrCloseNetworkSSID_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TheNetworkNameYouTypedIsNotSuffic3_Screenshot1
        { get { return repo.WebDocument19216801.TheNetworkNameYouTypedIsNotSuffic3Info.GetScreenshot1(new Rectangle(0, 0, 241, 47)); } }

        Imaging.FindOptions TheNetworkNameYouTypedIsNotSuffic3_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrCloseNetworkSSID_Screenshot2
        { get { return repo.WebDocument19216801.ErrCloseNetworkSSIDInfo.GetScreenshot2(new Rectangle(0, 0, 33, 39)); } }

        Imaging.FindOptions ErrCloseNetworkSSID_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
