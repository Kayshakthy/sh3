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
    ///The Choose_A_Port_Fwd_Rule_To_Disable recording.
    /// </summary>
    [TestModule("d58fadbb-0b50-4c64-aeaa-4fbf4110504f", ModuleType.Recording, 1)]
    public partial class Choose_A_Port_Fwd_Rule_To_Disable : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_A_Port_Fwd_Rule_To_Disable instance = new Choose_A_Port_Fwd_Rule_To_Disable();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_A_Port_Fwd_Rule_To_Disable()
        {
            Local_IP = "";
            Local_start_port = "";
            Local_end_port = "";
            External_start_port = "";
            External_end_port = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_A_Port_Fwd_Rule_To_Disable Instance
        {
            get { return instance; }
        }

#region Variables

        string _Local_IP;

        /// <summary>
        /// Gets or sets the value of variable Local_IP.
        /// </summary>
        [TestVariable("41c0182b-930d-40d6-b422-fe425149a43e")]
        public string Local_IP
        {
            get { return _Local_IP; }
            set { _Local_IP = value; }
        }

        string _Local_start_port;

        /// <summary>
        /// Gets or sets the value of variable Local_start_port.
        /// </summary>
        [TestVariable("8f7ae8b3-332c-412a-818d-f2177f4af12e")]
        public string Local_start_port
        {
            get { return _Local_start_port; }
            set { _Local_start_port = value; }
        }

        string _Local_end_port;

        /// <summary>
        /// Gets or sets the value of variable Local_end_port.
        /// </summary>
        [TestVariable("9659f158-d395-4c1d-9328-66e0244bea11")]
        public string Local_end_port
        {
            get { return _Local_end_port; }
            set { _Local_end_port = value; }
        }

        string _External_start_port;

        /// <summary>
        /// Gets or sets the value of variable External_start_port.
        /// </summary>
        [TestVariable("6e596ecc-a2d5-410b-aeb9-43afab7ec743")]
        public string External_start_port
        {
            get { return _External_start_port; }
            set { _External_start_port = value; }
        }

        string _External_end_port;

        /// <summary>
        /// Gets or sets the value of variable External_end_port.
        /// </summary>
        [TestVariable("5c20d4ab-9a0a-49e3-a4f6-82bcc2883cfb")]
        public string External_end_port
        {
            get { return _External_end_port; }
            set { _External_end_port = value; }
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

            //Choose_Port_fwd_rule_to_disable(Local_IP, Local_start_port, Local_end_port, External_start_port, External_end_port);
            //Delay.Milliseconds(0);
            
            Choose_Port_forwarding_rule_to_disable(Local_IP, Local_start_port, Local_end_port, External_start_port, External_end_port);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
