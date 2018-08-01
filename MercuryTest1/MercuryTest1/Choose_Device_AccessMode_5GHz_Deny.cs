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
    ///The Choose_Device_AccessMode_5GHz_Deny recording.
    /// </summary>
    [TestModule("d4dd0f29-f70d-45b2-82a9-930ab7beb4bc", ModuleType.Recording, 1)]
    public partial class Choose_Device_AccessMode_5GHz_Deny : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Device_AccessMode_5GHz_Deny instance = new Choose_Device_AccessMode_5GHz_Deny();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Device_AccessMode_5GHz_Deny()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Device_AccessMode_5GHz_Deny Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnDenyAllDevices' at 12;18.", repo.WebDocument19216801.FmRbtnDenyAllDevicesInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.FmRbtnDenyAllDevices.Click("12;18");
            Delay.Milliseconds(200);
            
            Capture_Access_Mode_Deny();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
