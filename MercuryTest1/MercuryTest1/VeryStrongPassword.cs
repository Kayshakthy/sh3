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
    ///The VeryStrongPassword recording.
    /// </summary>
    [TestModule("b8346e24-a952-4446-90cd-07f076626fcd", ModuleType.Recording, 1)]
    public partial class VeryStrongPassword : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static VeryStrongPassword instance = new VeryStrongPassword();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public VeryStrongPassword()
        {
            VeryStrongPass = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static VeryStrongPassword Instance
        {
            get { return instance; }
        }

#region Variables

        string _VeryStrongPass;

        /// <summary>
        /// Gets or sets the value of variable VeryStrongPass.
        /// </summary>
        [TestVariable("229f6430-4b87-410f-a086-bd07790868ab")]
        public string VeryStrongPass
        {
            get { return _VeryStrongPass; }
            set { _VeryStrongPass = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase' at 135;19.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.Passphrase.MoveTo("135;19");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase' at 143;11.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.Passphrase.MoveTo("143;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey' at 191;31.", repo.WebDocument19216801.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("191;31");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$VeryStrongPass' with focus on 'WebDocument19216801.Passphrase'.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.Passphrase.PressKeys(VeryStrongPass);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Very Strong') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(4));
            Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Very Strong");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=90,Height=21}) on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo, new RecordItemIndex(5));
            Validate.ContainsImage(repo.WebDocument19216801.PasstextWifiInfo, PasstextWifi_Screenshot1, PasstextWifi_Screenshot1_Options);
            Delay.Milliseconds(100);
            
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
