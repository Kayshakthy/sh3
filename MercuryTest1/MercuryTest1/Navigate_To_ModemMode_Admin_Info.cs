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
    ///The Navigate_To_ModemMode_Admin_Info recording.
    /// </summary>
    [TestModule("2e4eedeb-b516-48cb-94fa-9457aca0583f", ModuleType.Recording, 1)]
    public partial class Navigate_To_ModemMode_Admin_Info : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Navigate_To_ModemMode_Admin_Info instance = new Navigate_To_ModemMode_Admin_Info();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Navigate_To_ModemMode_Admin_Info()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Navigate_To_ModemMode_Admin_Info Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Admin') on item 'WebDocumentIE.Admin'.", repo.WebDocumentIE.AdminInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocumentIE.AdminInfo, "InnerText", "Admin");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocumentIE.Admin'.", repo.WebDocumentIE.AdminInfo, new RecordItemIndex(1));
            Validate.Exists(repo.WebDocumentIE.AdminInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.Admin' at 29;13.", repo.WebDocumentIE.AdminInfo, new RecordItemIndex(2));
            repo.WebDocumentIE.Admin.Click("29;13");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.Info' at 17;11.", repo.WebDocument1921681001.InfoInfo, new RecordItemIndex(3));
            repo.WebDocument1921681001.Info.Click("17;11");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
