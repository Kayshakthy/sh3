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
    ///The Enable_IPv6_Port_Filtering_Rule recording.
    /// </summary>
    [TestModule("a8194ed0-17b8-48b6-a07b-ecefdbd6c565", ModuleType.Recording, 1)]
    public partial class Enable_IPv6_Port_Filtering_Rule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Enable_IPv6_Port_Filtering_Rule instance = new Enable_IPv6_Port_Filtering_Rule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enable_IPv6_Port_Filtering_Rule()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enable_IPv6_Port_Filtering_Rule Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Enabled') on item 'WebDocument19216801.Enabled'.", repo.WebDocument19216801.EnabledInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocument19216801.EnabledInfo, "InnerText", "Enabled");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.FmRbtnIPv6FilterEnabled' at 16;18.", repo.WebDocument19216801.FmRbtnIPv6FilterEnabledInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.FmRbtnIPv6FilterEnabled.MoveTo("16;18");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnIPv6FilterEnabled' at 17;20.", repo.WebDocument19216801.FmRbtnIPv6FilterEnabledInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.FmRbtnIPv6FilterEnabled.Click("17;20");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
