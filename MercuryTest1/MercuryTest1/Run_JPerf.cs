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
    ///The Run_JPerf recording.
    /// </summary>
    [TestModule("f7ee72b3-0ea6-44a6-9f31-f51c9ecd9d93", ModuleType.Recording, 1)]
    public partial class Run_JPerf : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Run_JPerf instance = new Run_JPerf();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Run_JPerf()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Run_JPerf Instance
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

            repo.JPerf202NetworkPerformanceMeasur.Toolbar.RunIPerf.Click("99;24");
            Delay.Milliseconds(200);
            
            Validate_Output();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage Output_Screenshot1
        { get { return repo.JPerf202NetworkPerformanceMeasur.OutputInfo.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions Output_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}