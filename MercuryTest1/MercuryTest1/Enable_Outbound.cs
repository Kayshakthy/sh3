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
    ///The Enable_Outbound recording.
    /// </summary>
    [TestModule("7e232542-fd7e-443d-a02f-f06101a1f2c4", ModuleType.Recording, 1)]
    public partial class Enable_Outbound : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Enable_Outbound instance = new Enable_Outbound();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enable_Outbound()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enable_Outbound Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnInbound' at 14;24.", repo.WebDocument19216801.FmRbtnInboundInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.FmRbtnInbound.Click("14;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_IPv6Filter') on item 'WebDocument19216801.LabelIPv6Filter'.", repo.WebDocument19216801.LabelIPv6FilterInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.LabelIPv6FilterInfo, "Id", "label_IPv6Filter");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='IPv6 port filtering') on item 'WebDocument19216801.LabelIPv6Filter'.", repo.WebDocument19216801.LabelIPv6FilterInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocument19216801.LabelIPv6FilterInfo, "InnerText", "IPv6 port filtering");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnOutbound' at 16;21.", repo.WebDocument19216801.FmRbtnOutboundInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.FmRbtnOutbound.Click("16;21");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
