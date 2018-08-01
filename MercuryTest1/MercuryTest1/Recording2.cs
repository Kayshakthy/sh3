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
    ///The Recording2 recording.
    /// </summary>
    [TestModule("012084dd-3559-4d6f-ab02-be05cc6648ed", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://192.168.0.1/' with browser 'IE' in normal mode.", new RecordItemIndex(0));
            Host.Local.OpenBrowser("http://192.168.0.1/", "IE", "", false, false, false, false, false);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Password' at 264;7.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.Password.Click("264;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}V{LShiftKey up}' with focus on 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.Password.PressKeys("{LShiftKey down}V{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'irgin123' with focus on 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.Password.PressKeys("irgin123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button' at 115;29.", repo.WebDocument19216801.ButtonInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.Button.Click("115;29");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 115;23.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.AdvancedSettings.Click("115;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Wireless' at 51;18.", repo.WebDocument19216801.WirelessInfo, new RecordItemIndex(6));
            repo.WebDocument19216801.Wireless.Click("51;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security' at 53;4.", repo.WebDocument19216801.SecurityInfo, new RecordItemIndex(7));
            repo.WebDocument19216801.Security.Click("53;4");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase' at 135;19.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(8));
            repo.WebDocument19216801.Passphrase.MoveTo("135;19");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase' at 143;11.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(9));
            repo.WebDocument19216801.Passphrase.MoveTo("143;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey' at 191;31.", repo.WebDocument19216801.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(10));
            repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("191;31");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'AmM1n0t3stPest' with focus on 'WebDocument19216801.Passphrase'.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(11));
            repo.WebDocument19216801.Passphrase.PressKeys("AmM1n0t3stPest");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Very Strong') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Very Strong");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=90,Height=21}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(13));
            Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot1, PasstextWifi_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.LogOut' at 10;14.", repo.WebDocument19216801.LogOutInfo, new RecordItemIndex(14));
            repo.WebDocument19216801.LogOut.Click("10;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Http19216801WifiSettingsmidEqWir.ClientCaption' at 3164;33.", repo.Http19216801WifiSettingsmidEqWir.ClientCaptionInfo, new RecordItemIndex(15));
            repo.Http19216801WifiSettingsmidEqWir.ClientCaption.Click("3164;33");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage PasstextWifi_Screenshot1
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot1(new Rectangle(0, 0, 90, 21)); } }

        Imaging.FindOptions PasstextWifi_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
