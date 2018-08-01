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
    ///The Guest_5GHz_Very_Strong_Password_Validation recording.
    /// </summary>
    [TestModule("f3a07a97-bc0a-46c6-8661-7bce1cb2c711", ModuleType.Recording, 1)]
    public partial class Guest_5GHz_Very_Strong_Password_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Guest_5GHz_Very_Strong_Password_Validation instance = new Guest_5GHz_Very_Strong_Password_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Guest_5GHz_Very_Strong_Password_Validation()
        {
            Very_Strong_Pass_5GHz = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Guest_5GHz_Very_Strong_Password_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _Very_Strong_Pass_5GHz;

        /// <summary>
        /// Gets or sets the value of variable Very_Strong_Pass_5GHz.
        /// </summary>
        [TestVariable("dd814989-5433-4d29-ae02-90a0c1c3737c")]
        public string Very_Strong_Pass_5GHz
        {
            get { return _Very_Strong_Pass_5GHz; }
            set { _Very_Strong_Pass_5GHz = value; }
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

            repo.WebDocument19216801.Passphrase.DoubleClick("49;11");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase' at 99;9.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(1));
            //repo.WebDocument19216801.Passphrase.MoveTo("99;9");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase' at 107;1.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(2));
            //repo.WebDocument19216801.Passphrase.MoveTo("107;1");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WiFiPasswordSecurityKey' at 223;25.", repo.WebDocument19216801.WiFiPasswordSecurityKeyInfo, new RecordItemIndex(3));
            //repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("223;25");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Passphrase.PressKeys(Very_Strong_Pass_5GHz);
            Delay.Milliseconds(100);
            
            try {
                //Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Very Strong", Validate.DefaultMessage, false);
                //Delay.Milliseconds(100);
            } catch(Exception) {  }
            
            try {
                Validate_Very_Strong_Pass_5GHz(Very_Strong_Pass_5GHz);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}