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
    ///The Software_Info recording.
    /// </summary>
    [TestModule("1ac9eb4b-6a9e-4b0c-a22b-9be9e22a48e4", ModuleType.Recording, 1)]
    public partial class Software_Info : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Software_Info instance = new Software_Info();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Software_Info()
        {
            SoftwareVersion = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Software_Info Instance
        {
            get { return instance; }
        }

#region Variables

        string _SoftwareVersion;

        /// <summary>
        /// Gets or sets the value of variable SoftwareVersion.
        /// </summary>
        [TestVariable("19e00216-fb04-465d-8820-9cf901b644fb")]
        public string SoftwareVersion
        {
            get { return _SoftwareVersion; }
            set { _SoftwareVersion = value; }
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

            repo.WebDocument19216801.Admin.Click("17;10");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Info.Click("12;7");
            Delay.Milliseconds(200);
            
            Validate_SoftwareVersion();
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$SoftwareVersion) on item 'WebDocument19216801.SoftwareVersion'.", repo.WebDocument19216801.SoftwareVersionInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.SoftwareVersionInfo, "InnerText", SoftwareVersion);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
