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
    ///The Restore_Default_Firewall_Settings recording.
    /// </summary>
    [TestModule("8954e5e7-4e03-4977-8fa4-147807f06812", ModuleType.Recording, 1)]
    public partial class Restore_Default_Firewall_Settings : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Restore_Default_Firewall_Settings instance = new Restore_Default_Firewall_Settings();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Restore_Default_Firewall_Settings()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Restore_Default_Firewall_Settings Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxEnablePortScanDetectionv6' at 14;19.", repo.WebDocument19216801.FmChbxEnablePortScanDetectionv6Info, new RecordItemIndex(0));
            repo.WebDocument19216801.FmChbxEnablePortScanDetectionv6.Click("14;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxEnableIPFloodDetectionv6' at 15;16.", repo.WebDocument19216801.FmChbxEnableIPFloodDetectionv6Info, new RecordItemIndex(1));
            repo.WebDocument19216801.FmChbxEnableIPFloodDetectionv6.Click("15;16");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmCheckbox checked') on item 'WebDocument19216801.FmChbxEnableFirewallv6'.", repo.WebDocument19216801.FmChbxEnableFirewallv6Info, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnableFirewallv6Info, "Class", "fmCheckbox checked");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmChbx-EnableFirewallv6') on item 'WebDocument19216801.FmChbxEnableFirewallv6'.", repo.WebDocument19216801.FmChbxEnableFirewallv6Info, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnableFirewallv6Info, "Id", "fmChbx-EnableFirewallv6");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmCheckbox checked') on item 'WebDocument19216801.FmChbxEnablePortScanDetectionv6'.", repo.WebDocument19216801.FmChbxEnablePortScanDetectionv6Info, new RecordItemIndex(4));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnablePortScanDetectionv6Info, "Class", "fmCheckbox checked");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmChbx-EnablePortScanDetectionv6') on item 'WebDocument19216801.FmChbxEnablePortScanDetectionv6'.", repo.WebDocument19216801.FmChbxEnablePortScanDetectionv6Info, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnablePortScanDetectionv6Info, "Id", "fmChbx-EnablePortScanDetectionv6");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmCheckbox checked') on item 'WebDocument19216801.FmChbxEnableIPFloodDetectionv6'.", repo.WebDocument19216801.FmChbxEnableIPFloodDetectionv6Info, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnableIPFloodDetectionv6Info, "Class", "fmCheckbox checked");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmChbx-EnableIPFloodDetectionv6') on item 'WebDocument19216801.FmChbxEnableIPFloodDetectionv6'.", repo.WebDocument19216801.FmChbxEnableIPFloodDetectionv6Info, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocument19216801.FmChbxEnableIPFloodDetectionv6Info, "Id", "fmChbx-EnableIPFloodDetectionv6");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button5' at 87;24.", repo.WebDocument19216801.Button5Info, new RecordItemIndex(8));
            repo.WebDocument19216801.Button5.Click("87;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3ms.", new RecordItemIndex(9));
            Delay.Duration(3, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(10));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
