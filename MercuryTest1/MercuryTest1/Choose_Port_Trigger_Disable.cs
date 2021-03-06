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
    ///The Choose_Port_Trigger_Disable recording.
    /// </summary>
    [TestModule("ddbe2492-10e0-49ed-92af-3de2e4a8175d", ModuleType.Recording, 1)]
    public partial class Choose_Port_Trigger_Disable : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Port_Trigger_Disable instance = new Choose_Port_Trigger_Disable();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Port_Trigger_Disable()
        {
            Enable_Disable = "Off";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Port_Trigger_Disable Instance
        {
            get { return instance; }
        }

#region Variables

        string _Enable_Disable;

        /// <summary>
        /// Gets or sets the value of variable Enable_Disable.
        /// </summary>
        [TestVariable("d4432c9d-e685-4308-98b1-343af9796ec2")]
        public string Enable_Disable
        {
            get { return _Enable_Disable; }
            set { _Enable_Disable = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.SomeSpanTag9' at 166;10.", repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9Info, new RecordItemIndex(0));
            repo.WebDocument19216801.FmSelEnabled.SomeSpanTag9.Click("166;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelEnabled.LiTagOff' at 48;9.", repo.WebDocument19216801.FmSelEnabled.LiTagOffInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.FmSelEnabled.LiTagOff.Click("48;9");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Enable_Disable' with focus on 'WebDocumentIE.CiteTagOn'.", repo.WebDocumentIE.CiteTagOnInfo, new RecordItemIndex(2));
            //repo.WebDocumentIE.CiteTagOn.PressKeys(Enable_Disable);
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Off') on item 'WebDocumentIE.CiteTagOff'.", repo.WebDocumentIE.CiteTagOffInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocumentIE.CiteTagOffInfo, "InnerText", "Off");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
