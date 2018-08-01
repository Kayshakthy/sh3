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
    ///The Validate_All_Very_Strong_Password recording.
    /// </summary>
    [TestModule("b0cc3873-5c79-4020-9261-b92bdbbb734d", ModuleType.Recording, 1)]
    public partial class Validate_All_Very_Strong_Password : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Validate_All_Very_Strong_Password instance = new Validate_All_Very_Strong_Password();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_All_Very_Strong_Password()
        {
            VeryStrongPass = "";
            VeryStrongPassword = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_All_Very_Strong_Password Instance
        {
            get { return instance; }
        }

#region Variables

        string _VeryStrongPass;

        /// <summary>
        /// Gets or sets the value of variable VeryStrongPass.
        /// </summary>
        [TestVariable("b4d80793-c15b-40dc-a6d8-803cdb409131")]
        public string VeryStrongPass
        {
            get { return _VeryStrongPass; }
            set { _VeryStrongPass = value; }
        }

        string _VeryStrongPassword;

        /// <summary>
        /// Gets or sets the value of variable VeryStrongPassword.
        /// </summary>
        [TestVariable("43a195f5-7379-4837-9d49-8b15f0f29a40")]
        public string VeryStrongPassword
        {
            get { return _VeryStrongPassword; }
            set { _VeryStrongPassword = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase' at 135;19.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(0));
            //repo.WebDocument19216801.Passphrase.MoveTo("135;19");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase' at 143;11.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(1));
            //repo.WebDocument19216801.Passphrase.MoveTo("143;11");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Passphrase.Click("143;11");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey' at 191;31.", repo.WebDocument19216801.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(5));
            //repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("191;31");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            try {
                //Report.Log(ReportLevel.Info, "Mouse", "(Optional Action)\r\nMouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey' at 242;26.", repo.WebDocument19216801.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(6));
                //repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("242;26");
                //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
                //Delay.Milliseconds(200);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                repo.WebDocument19216801.Passphrase.PressKeys(VeryStrongPassword);
                Delay.Milliseconds(800);
            } catch(Exception) {  }
            
            try {
                Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Very Strong", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception) {  }
            
            try {
                Validate_Passphrase(VeryStrongPassword);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
