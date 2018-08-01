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
    ///The Choose_Any_DHCP_Reserv_Rule recording.
    /// </summary>
    [TestModule("5f622e02-e7e2-408f-9b02-a7a5c53f079c", ModuleType.Recording, 1)]
    public partial class Choose_Any_DHCP_Reserv_Rule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Any_DHCP_Reserv_Rule instance = new Choose_Any_DHCP_Reserv_Rule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Any_DHCP_Reserv_Rule()
        {
            MAC_address_DHCP = "";
            IP_Address_DHCP = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Any_DHCP_Reserv_Rule Instance
        {
            get { return instance; }
        }

#region Variables

        string _MAC_address_DHCP;

        /// <summary>
        /// Gets or sets the value of variable MAC_address_DHCP.
        /// </summary>
        [TestVariable("709d8fc2-cc2b-4aaf-9d98-0c1b8dba8299")]
        public string MAC_address_DHCP
        {
            get { return _MAC_address_DHCP; }
            set { _MAC_address_DHCP = value; }
        }

        string _IP_Address_DHCP;

        /// <summary>
        /// Gets or sets the value of variable IP_Address_DHCP.
        /// </summary>
        [TestVariable("d3f6e66c-15e8-4acd-b272-d2e18d1c8710")]
        public string IP_Address_DHCP
        {
            get { return _IP_Address_DHCP; }
            set { _IP_Address_DHCP = value; }
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

            Choose_Any_DHCP_Reserv_Rule_To_Delete(MAC_address_DHCP, IP_Address_DHCP);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
