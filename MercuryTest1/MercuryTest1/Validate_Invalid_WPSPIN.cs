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
    ///The Validate_Invalid_WPSPIN recording.
    /// </summary>
    [TestModule("54a16560-4e97-44f6-bfb8-5a4551eff246", ModuleType.Recording, 1)]
    public partial class Validate_Invalid_WPSPIN : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Validate_Invalid_WPSPIN instance = new Validate_Invalid_WPSPIN();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Invalid_WPSPIN()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Validate_Invalid_WPSPIN Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.ErrClosePIN'.", repo.WebDocument19216801.ErrClosePINInfo, new RecordItemIndex(0));
            Validate.Exists(repo.WebDocument19216801.ErrClosePINInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
