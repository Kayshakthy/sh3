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
    ///The Navigate_To_Device_Admin_Remote_access recording.
    /// </summary>
    [TestModule("91953acb-ea6a-441a-90a4-afbd323cb3a1", ModuleType.Recording, 1)]
    public partial class Navigate_To_Device_Admin_Remote_access : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Navigate_To_Device_Admin_Remote_access instance = new Navigate_To_Device_Admin_Remote_access();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_To_Device_Admin_Remote_access()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_To_Device_Admin_Remote_access Instance
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

            //repo.WebDocument19216801.Admin.Click("30;11");
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.Info.Click("15;5");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(2));
            Delay.Duration(30000, false);
            
            repo.WebDocument19216801.Admin.Click("28;12");
            Delay.Milliseconds(200);
            
            repo.WebDocumentIE.RemoteAccess.Click("48;10");
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument19216801.LabelRemoteAccessInfo, "InnerText", "Remote access");
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}