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
    ///The Choose_A_Port_Forward_Rule recording.
    /// </summary>
    [TestModule("7ad5746a-337b-4348-bf01-73cd426bfe92", ModuleType.Recording, 1)]
    public partial class Choose_A_Port_Forward_Rule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_A_Port_Forward_Rule instance = new Choose_A_Port_Forward_Rule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_A_Port_Forward_Rule()
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
        public static Choose_A_Port_Forward_Rule Instance
        {
            get { return instance; }
        }

#region Variables

        string _Local_IP;

        /// <summary>
        /// Gets or sets the value of variable Local_IP.
        /// </summary>
        [TestVariable("638670ec-04a7-4068-82f5-0cdafcf1d3d8")]
        public string Local_IP
        {
            get { return _Local_IP; }
            set { _Local_IP = value; }
        }

        string _Local_start_port;

        /// <summary>
        /// Gets or sets the value of variable Local_start_port.
        /// </summary>
        [TestVariable("f07abff7-a5e3-4f1a-8ced-f2e78798182e")]
        public string Local_start_port
        {
            get { return _Local_start_port; }
            set { _Local_start_port = value; }
        }

        string _Local_end_port;

        /// <summary>
        /// Gets or sets the value of variable Local_end_port.
        /// </summary>
        [TestVariable("6f193ecc-8119-4521-b050-4721039684c3")]
        public string Local_end_port
        {
            get { return _Local_end_port; }
            set { _Local_end_port = value; }
        }

        string _External_start_port;

        /// <summary>
        /// Gets or sets the value of variable External_start_port.
        /// </summary>
        [TestVariable("3382f7a7-4c8c-4f62-88e2-5517993584b5")]
        public string External_start_port
        {
            get { return _External_start_port; }
            set { _External_start_port = value; }
        }

        string _External_end_port;

        /// <summary>
        /// Gets or sets the value of variable External_end_port.
        /// </summary>
        [TestVariable("3f2eb4a5-07ff-40b1-95a2-4dcd596e432c")]
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

            //Delete_A_Port_Fwd_Rule(Local_IP, Local_start_port, Local_end_port, External_start_port, External_end_port);
            //Delay.Milliseconds(0);
            
            // Implemented based on R3.5(9.1.116J)
            Delete_Any_Port_Forward_Rule(Local_IP, Local_start_port, Local_end_port, External_start_port, External_end_port);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
