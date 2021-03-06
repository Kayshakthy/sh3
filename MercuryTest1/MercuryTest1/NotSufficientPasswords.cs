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
    ///The NotSufficientPasswords recording.
    /// </summary>
    [TestModule("6df94b95-b801-4e8b-ae6b-8d579ab4a5b4", ModuleType.Recording, 1)]
    public partial class NotSufficientPasswords : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static NotSufficientPasswords instance = new NotSufficientPasswords();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public NotSufficientPasswords()
        {
            notSufficientPass = "p";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static NotSufficientPasswords Instance
        {
            get { return instance; }
        }

#region Variables

        string _notSufficientPass;

        /// <summary>
        /// Gets or sets the value of variable notSufficientPass.
        /// </summary>
        [TestVariable("ebc1370c-557a-4cf3-861c-285c77527a2f")]
        public string notSufficientPass
        {
            get { return _notSufficientPass; }
            set { _notSufficientPass = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Passphrase' at 152;18.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.Passphrase.Click("152;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase' at 152;18.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.Passphrase.MoveTo("152;18");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase' at 160;10.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.Passphrase.MoveTo("160;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey' at 376;13.", repo.WebDocument19216801.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("376;13");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$notSufficientPass' with focus on 'WebDocument19216801.Passphrase'.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.Passphrase.PressKeys(notSufficientPass);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Passphrase' at 61;19.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(5));
            repo.WebDocument19216801.Passphrase.Click("61;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Not Sufficient') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Not Sufficient");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
