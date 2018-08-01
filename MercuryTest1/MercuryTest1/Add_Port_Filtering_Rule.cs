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
    ///The Add_Port_Filtering_Rule recording.
    /// </summary>
    [TestModule("c17b151d-ff12-4f1b-9ee3-3a4c7a0c2ccf", ModuleType.Recording, 1)]
    public partial class Add_Port_Filtering_Rule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Add_Port_Filtering_Rule instance = new Add_Port_Filtering_Rule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Add_Port_Filtering_Rule()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Add_Port_Filtering_Rule Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1354;400.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(0));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1354;400");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1357;493.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(1));
            //repo.WebDocument19216801.WebDocument19216801.MoveTo("1357;493");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Add rule') on item 'WebDocument19216801.AddApply'.", repo.WebDocument19216801.AddApplyInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.AddApplyInfo, "Value", "Add rule");
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.AddApply.Click("55;26");
            Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.FmRbtnAlwaysLimitation.Click("11;14");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Apply changes') on item 'WebDocument19216801.Button6'.", repo.WebDocument19216801.Button6Info, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.Button6Info, "Value", "Apply changes");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button6' at 86;26.", repo.WebDocument19216801.Button6Info, new RecordItemIndex(6));
            //repo.WebDocument19216801.Button6.Click("86;26");
            //Delay.Milliseconds(200);
            
            Validate_New_IPv4Port_Filtering_Rule();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}