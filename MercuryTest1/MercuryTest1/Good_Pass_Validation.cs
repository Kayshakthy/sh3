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
    ///The Good_Pass_Validation recording.
    /// </summary>
    [TestModule("f517ceda-5c54-4158-8520-3f59cc1d55b5", ModuleType.Recording, 1)]
    public partial class Good_Pass_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Good_Pass_Validation instance = new Good_Pass_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Good_Pass_Validation()
        {
            pass1 = "passWord!2";
            Good_Password = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Good_Pass_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _pass1;

        /// <summary>
        /// Gets or sets the value of variable pass1.
        /// </summary>
        [TestVariable("842ca6e1-876e-4f7d-8210-0b94ca6650b3")]
        public string pass1
        {
            get { return _pass1; }
            set { _pass1 = value; }
        }

        string _Good_Password;

        /// <summary>
        /// Gets or sets the value of variable Good_Password.
        /// </summary>
        [TestVariable("63209c02-27f3-4541-a324-b02f80f30730")]
        public string Good_Password
        {
            get { return _Good_Password; }
            set { _Good_Password = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.Passphrase' at 141;18.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(0));
            //repo.WebDocument19216801.Passphrase.MoveTo("141;18");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.Passphrase' at 149;10.", repo.WebDocument19216801.PassphraseInfo, new RecordItemIndex(1));
            //repo.WebDocument19216801.Passphrase.MoveTo("149;10");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Passphrase.Click("141;18");
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            try {
                //repo.WebDocument19216801.WiFiPasswordSecurityKey.MoveTo("242;26");
                //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
                //Delay.Milliseconds(200);
            } catch(Exception) {  }
            
            try {
                repo.WebDocument19216801.Passphrase.PressKeys(Good_Password);
                Delay.Milliseconds(400);
            } catch(Exception) {  }
            
            try {
                Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Good", Validate.DefaultMessage, false);
                Delay.Milliseconds(100);
            } catch(Exception) {  }
            
            try {
                Validate_Passphrase(Good_Password);
                Delay.Milliseconds(0);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}