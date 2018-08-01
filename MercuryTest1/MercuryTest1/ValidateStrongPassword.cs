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
    ///The ValidateStrongPassword recording.
    /// </summary>
    [TestModule("c8310bd9-fca4-4247-bb6e-24e76b4dea03", ModuleType.Recording, 1)]
    public partial class ValidateStrongPassword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static ValidateStrongPassword instance = new ValidateStrongPassword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ValidateStrongPassword()
        {
            StrongPassword = "amm1no+estaaa";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ValidateStrongPassword Instance
        {
            get { return instance; }
        }

#region Variables

        string _StrongPassword;

        /// <summary>
        /// Gets or sets the value of variable StrongPassword.
        /// </summary>
        [TestVariable("7c506eb2-8fb5-481c-abcd-d33737c30bcf")]
        public string StrongPassword
        {
            get { return _StrongPassword; }
            set { _StrongPassword = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase' at 141;18.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.Passphrase.MoveTo("141;18");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase' at 149;10.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.Passphrase.MoveTo("149;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey' at 242;26.", repo.WebDocument19216801.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("242;26");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$StrongPassword' with focus on 'WebDocument19216801.Passphrase'.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.Passphrase.PressKeys(StrongPassword);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Strong') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Strong");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot3' with region {X=0,Y=0,Width=52,Height=21}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(5));
            Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot3, PasstextWifi_Screenshot3_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage PasstextWifi_Screenshot3
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot3(new Rectangle(0, 0, 52, 21)); } }

        Imaging.FindOptions PasstextWifi_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}