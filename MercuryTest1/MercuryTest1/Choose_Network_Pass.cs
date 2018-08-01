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
    ///The Choose_Network_Pass recording.
    /// </summary>
    [TestModule("01ffb338-8499-4c94-9474-04ea86604e7a", ModuleType.Recording, 1)]
    public partial class Choose_Network_Pass : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Network_Pass instance = new Choose_Network_Pass();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Network_Pass()
        {
            Guest_Pass = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Network_Pass Instance
        {
            get { return instance; }
        }

#region Variables

        string _Guest_Pass;

        /// <summary>
        /// Gets or sets the value of variable Guest_Pass.
        /// </summary>
        [TestVariable("7168f42e-b7ad-47c2-b5a9-2711f2baff27")]
        public string Guest_Pass
        {
            get { return _Guest_Pass; }
            set { _Guest_Pass = value; }
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1359;269.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(0));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1359;269");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Passphrase.Click();
            Delay.Milliseconds(200);
            
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Passphrase.PressKeys(Guest_Pass);
            Delay.Milliseconds(0);
            
            Validate_PasstextWifi();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LControlKey up}'.", new RecordItemIndex(6));
            //Keyboard.Press("{LControlKey up}");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}