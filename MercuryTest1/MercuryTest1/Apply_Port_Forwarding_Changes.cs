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
    ///The Apply_Port_Forwarding_Changes recording.
    /// </summary>
    [TestModule("7a93fa29-b7d5-49aa-8fd4-42e78ab5cc7b", ModuleType.Recording, 1)]
    public partial class Apply_Port_Forwarding_Changes : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Apply_Port_Forwarding_Changes instance = new Apply_Port_Forwarding_Changes();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Apply_Port_Forwarding_Changes()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Apply_Port_Forwarding_Changes Instance
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

            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Apply changes') on item 'WebDocument19216801.Button12'.", repo.WebDocument19216801.Button12Info, new RecordItemIndex(0));
            //Validate.Attribute(repo.WebDocument19216801.Button12Info, "Value", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Validate_PortFwdRule();
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.FmCbxFm02' at 21;15.", repo.WebDocumentIE.FmCbxFm02Info, new RecordItemIndex(2));
            //repo.WebDocumentIE.FmCbxFm02.Click("21;15");
            //Delay.Milliseconds(200);
            
            Delay.Duration(1000, false);
            
            repo.WebDocument19216801.Button15.Click("93;21");
            Delay.Milliseconds(200);
            
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}