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
    ///The Choose_Connected_Device_To_Add recording.
    /// </summary>
    [TestModule("0a5ff34b-5e94-462a-956f-0b33f58cf7a7", ModuleType.Recording, 1)]
    public partial class Choose_Connected_Device_To_Add : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Connected_Device_To_Add instance = new Choose_Connected_Device_To_Add();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Connected_Device_To_Add()
        {
            Mac0 = "";
            Mac1 = "";
            Mac2 = "";
            Mac3 = "";
            Mac4 = "";
            Mac5 = "";
            Ipv4SourceSingle3 = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Connected_Device_To_Add Instance
        {
            get { return instance; }
        }

#region Variables

        string _Mac0;

        /// <summary>
        /// Gets or sets the value of variable Mac0.
        /// </summary>
        [TestVariable("57c2771e-c1a1-4f25-ace9-2b1e7454bd07")]
        public string Mac0
        {
            get { return _Mac0; }
            set { _Mac0 = value; }
        }

        string _Mac1;

        /// <summary>
        /// Gets or sets the value of variable Mac1.
        /// </summary>
        [TestVariable("96660d2f-1c03-4ad5-a05b-0984ab1e3ca9")]
        public string Mac1
        {
            get { return _Mac1; }
            set { _Mac1 = value; }
        }

        string _Mac2;

        /// <summary>
        /// Gets or sets the value of variable Mac2.
        /// </summary>
        [TestVariable("a50b9949-515e-4678-962f-1eebd5e37b9b")]
        public string Mac2
        {
            get { return _Mac2; }
            set { _Mac2 = value; }
        }

        string _Mac3;

        /// <summary>
        /// Gets or sets the value of variable Mac3.
        /// </summary>
        [TestVariable("f93825ea-4287-4d6f-8891-a730757f8c13")]
        public string Mac3
        {
            get { return _Mac3; }
            set { _Mac3 = value; }
        }

        string _Mac4;

        /// <summary>
        /// Gets or sets the value of variable Mac4.
        /// </summary>
        [TestVariable("6bafbb7d-5b07-48bc-bb7a-bc7a559e53dc")]
        public string Mac4
        {
            get { return _Mac4; }
            set { _Mac4 = value; }
        }

        string _Mac5;

        /// <summary>
        /// Gets or sets the value of variable Mac5.
        /// </summary>
        [TestVariable("a8699e28-eb96-4d03-974e-56d2f8726c40")]
        public string Mac5
        {
            get { return _Mac5; }
            set { _Mac5 = value; }
        }

        string _Ipv4SourceSingle3;

        /// <summary>
        /// Gets or sets the value of variable Ipv4SourceSingle3.
        /// </summary>
        [TestVariable("af837eb2-71e6-42ac-83f9-9dec22430fa9")]
        public string Ipv4SourceSingle3
        {
            get { return _Ipv4SourceSingle3; }
            set { _Ipv4SourceSingle3 = value; }
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

            Choose_Connected_DHCP_Device(Mac0, Mac1, Mac2, Mac3, Mac4, Mac5);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
