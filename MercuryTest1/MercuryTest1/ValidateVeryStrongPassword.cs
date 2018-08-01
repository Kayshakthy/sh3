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
    ///The ValidateVeryStrongPassword recording.
    /// </summary>
    [TestModule("43d72b63-60d5-43c6-80cc-2210b7ff30a8", ModuleType.Recording, 1)]
    public partial class ValidateVeryStrongPassword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static ValidateVeryStrongPassword instance = new ValidateVeryStrongPassword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateVeryStrongPassword()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateVeryStrongPassword Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Password' at 40;16.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.Password.Click("40;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}V{LShiftKey up}irgin' with focus on 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.Password.PressKeys("{LShiftKey down}V{LShiftKey up}irgin");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '123' with focus on 'WebDocument19216801.Password'.", repo.WebDocument19216801.PasswordInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.Password.PressKeys("123");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button' at 96;17.", repo.WebDocument19216801.ButtonInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.Button.Click("96;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 60;10.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.AdvancedSettings.Click("60;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security1' at 20;7.", repo.WebDocument19216801.Security1Info, new RecordItemIndex(6));
            repo.WebDocument19216801.Security1.Click("20;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Wireless' at 34;11.", repo.WebDocument19216801.WirelessInfo, new RecordItemIndex(7));
            repo.WebDocument19216801.Wireless.Click("34;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security' at 48;6.", repo.WebDocument19216801.SecurityInfo, new RecordItemIndex(8));
            repo.WebDocument19216801.Security.Click("48;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Passphrase' at 137;15.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(9));
            repo.WebDocument19216801.Passphrase.Click("137;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+V' Press with focus on 'WebDocument19216801.Passphrase'.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.WebDocument19216801.Passphrase);
            Keyboard.Press(System.Windows.Forms.Keys.V | System.Windows.Forms.Keys.Control, 47, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '2345' with focus on 'WebDocument19216801.Passphrase'.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(11));
            repo.WebDocument19216801.Passphrase.PressKeys("2345");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Very Strong') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Very Strong");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
