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
    ///The Form_Last_Octate_Mac_Addresses recording.
    /// </summary>
    [TestModule("65cb4dcb-78f3-4d53-a697-bcca95541305", ModuleType.Recording, 1)]
    public partial class Form_Last_Octate_Mac_Addresses : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Form_Last_Octate_Mac_Addresses instance = new Form_Last_Octate_Mac_Addresses();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Form_Last_Octate_Mac_Addresses()
        {
            MacAdd51 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Form_Last_Octate_Mac_Addresses Instance
        {
            get { return instance; }
        }

#region Variables

        string _MacAdd51;

        /// <summary>
        /// Gets or sets the value of variable MacAdd51.
        /// </summary>
        [TestVariable("38c45280-1986-419a-bc49-aee0f804ab03")]
        public string MacAdd51
        {
            get { return _MacAdd51; }
            set { _MacAdd51 = value; }
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

            repo.WebDocument19216801.MacAddress51.Click();
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MacAddress51);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.MacAddress51);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.MacAddress51.PressKeys(MacAdd51);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
