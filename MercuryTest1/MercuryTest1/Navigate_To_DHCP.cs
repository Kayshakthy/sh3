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
    ///The Navigate_To_DHCP recording.
    /// </summary>
    [TestModule("98730d7a-6a2b-48cf-afc4-591781075304", ModuleType.Recording, 1)]
    public partial class Navigate_To_DHCP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Navigate_To_DHCP instance = new Navigate_To_DHCP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_To_DHCP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_To_DHCP Instance
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

            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(0));
            Delay.Duration(20000, false);
            
            repo.WebDocument19216801.AdvancedSettings.Click("71;9");
            Delay.Milliseconds(200);
            
            repo.WebDocumentIE.DHCP.Click("13;4");
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocumentIE.DHCPInfo, "InnerText", "DHCP");
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
