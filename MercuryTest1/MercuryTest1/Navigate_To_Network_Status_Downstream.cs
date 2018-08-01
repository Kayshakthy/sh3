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
    ///The Navigate_To_Network_Status_Downstream recording.
    /// </summary>
    [TestModule("2757c3f0-70b6-434f-bc94-70a3867336be", ModuleType.Recording, 1)]
    public partial class Navigate_To_Network_Status_Downstream : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Navigate_To_Network_Status_Downstream instance = new Navigate_To_Network_Status_Downstream();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_To_Network_Status_Downstream()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_To_Network_Status_Downstream Instance
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

            repo.WebDocument19216801.AdvancedSettings.Click("71;8");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Tools.Click("17;9");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.NetworkStatus.Click("42;5");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.RouterStatusTabs.Downstream'.", repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Downstream') on item 'WebDocument19216801.RouterStatusTabs.Downstream'.", repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, "InnerText", "Downstream");
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.RouterStatusTabs.Downstream.Click("66;19");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
