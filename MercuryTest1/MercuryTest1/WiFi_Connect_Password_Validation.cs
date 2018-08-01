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
    ///The WiFi_Connect_Password_Validation recording.
    /// </summary>
    [TestModule("a30f2f50-ded5-41db-8393-3b4fda078c7a", ModuleType.Recording, 1)]
    public partial class WiFi_Connect_Password_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static WiFi_Connect_Password_Validation instance = new WiFi_Connect_Password_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WiFi_Connect_Password_Validation()
        {
            PasswordConfig = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WiFi_Connect_Password_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _PasswordConfig;

        /// <summary>
        /// Gets or sets the value of variable PasswordConfig.
        /// </summary>
        [TestVariable("e011ee7c-e601-451f-8fe9-019721736df4")]
        public string PasswordConfig
        {
            get { return _PasswordConfig; }
            set { _PasswordConfig = value; }
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

            repo.WebDocument19216801.NewWiFiPassword.Click("21;10");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.NewWiFiPassword);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.NewWiFiPassword);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.NewWiFiPassword.PressKeys(PasswordConfig);
            Delay.Milliseconds(0);
            
            Validate_PasstextWifi(PasswordConfig);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage PasstextWifi_Screenshot5
        { get { return repo.WebDocument19216801.PasstextWifiInfo.GetScreenshot5(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions PasstextWifi_Screenshot5_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
