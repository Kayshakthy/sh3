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
    ///The Delete_Port_Filtering_Rule recording.
    /// </summary>
    [TestModule("9397e75e-af12-4648-a5a7-b3a01b5cc0d7", ModuleType.Recording, 1)]
    public partial class Delete_Port_Filtering_Rule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Delete_Port_Filtering_Rule instance = new Delete_Port_Filtering_Rule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Delete_Port_Filtering_Rule()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Delete_Port_Filtering_Rule Instance
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

            repo.WebDocument19216801.FmChbxIpv4FilterTableDelete0.Click("17;17");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocument19216801.FmChbxIpv4FilterTableDelete0Info, "Class", "fmCheckbox checked");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.FmChbxIpv4FilterTableDelete0Info, "Id", "fmChbx-ipv4FilterTable-Delete-0");
            Delay.Milliseconds(100);
            
            Report_Screenshot_FmChbxIpv4FilterTableDelete0();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
