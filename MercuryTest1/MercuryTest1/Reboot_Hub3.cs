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
    ///The Reboot_Hub3 recording.
    /// </summary>
    [TestModule("78a5fdbf-2365-4ed2-8c18-dbbff21fea34", ModuleType.Recording, 1)]
    public partial class Reboot_Hub3 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Reboot_Hub3 instance = new Reboot_Hub3();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Reboot_Hub3()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Reboot_Hub3 Instance
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

            repo.WebDocumentIE.Button2.Click("67;28");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Restart') on item 'WebDocument19216801.EnableRestartBtn'.", repo.WebDocument19216801.EnableRestartBtnInfo, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocument19216801.EnableRestartBtnInfo, "Value", "Restart");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.EnableRestartBtn' at 112;31.", repo.WebDocument19216801.EnableRestartBtnInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.EnableRestartBtn.Click("112;31");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}