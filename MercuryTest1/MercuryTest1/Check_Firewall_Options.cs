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
    ///The Check_Firewall_Options recording.
    /// </summary>
    [TestModule("7e51d047-28e7-469c-af24-287812ff6341", ModuleType.Recording, 1)]
    public partial class Check_Firewall_Options : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Check_Firewall_Options instance = new Check_Firewall_Options();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Check_Firewall_Options()
        {
            IP_Flood_Detect = "";
            Firewall_Protection = "";
            Block_Fragmented_IP_Pkts = "";
            Port_Scan = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Check_Firewall_Options Instance
        {
            get { return instance; }
        }

#region Variables

        string _IP_Flood_Detect;

        /// <summary>
        /// Gets or sets the value of variable IP_Flood_Detect.
        /// </summary>
        [TestVariable("d664100b-dc06-4209-8234-a39e63f56558")]
        public string IP_Flood_Detect
        {
            get { return _IP_Flood_Detect; }
            set { _IP_Flood_Detect = value; }
        }

        string _Firewall_Protection;

        /// <summary>
        /// Gets or sets the value of variable Firewall_Protection.
        /// </summary>
        [TestVariable("aaf5a42f-3c07-4d16-ba3c-2a8cc8e47a77")]
        public string Firewall_Protection
        {
            get { return _Firewall_Protection; }
            set { _Firewall_Protection = value; }
        }

        string _Block_Fragmented_IP_Pkts;

        /// <summary>
        /// Gets or sets the value of variable Block_Fragmented_IP_Pkts.
        /// </summary>
        [TestVariable("0e85f6b7-e8f4-45ce-a238-ff1da5f3bd2d")]
        public string Block_Fragmented_IP_Pkts
        {
            get { return _Block_Fragmented_IP_Pkts; }
            set { _Block_Fragmented_IP_Pkts = value; }
        }

        string _Port_Scan;

        /// <summary>
        /// Gets or sets the value of variable Port_Scan.
        /// </summary>
        [TestVariable("66e05467-3cda-4bd7-909b-bacc13d4c09c")]
        public string Port_Scan
        {
            get { return _Port_Scan; }
            set { _Port_Scan = value; }
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

            Choose_firewallOptions(IP_Flood_Detect);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}