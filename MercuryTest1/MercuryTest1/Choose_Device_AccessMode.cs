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
    ///The Choose_Device_AccessMode recording.
    /// </summary>
    [TestModule("b521cd0e-4dc9-4374-a9cc-307e37a62e02", ModuleType.Recording, 1)]
    public partial class Choose_Device_AccessMode : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Device_AccessMode instance = new Choose_Device_AccessMode();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Device_AccessMode()
        {
            Device_Access_Mode = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Device_AccessMode Instance
        {
            get { return instance; }
        }

#region Variables

        string _Device_Access_Mode;

        /// <summary>
        /// Gets or sets the value of variable Device_Access_Mode.
        /// </summary>
        [TestVariable("fbc40214-d151-44a2-9900-6867f8d75e98")]
        public string Device_Access_Mode
        {
            get { return _Device_Access_Mode; }
            set { _Device_Access_Mode = value; }
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

            Choose_Devices_AccessMode(Device_Access_Mode);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
