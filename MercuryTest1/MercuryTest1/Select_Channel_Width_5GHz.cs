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
    ///The Select_Channel_Width_5GHz recording.
    /// </summary>
    [TestModule("61728bf0-5be3-40ef-a5aa-d39db5557b03", ModuleType.Recording, 1)]
    public partial class Select_Channel_Width_5GHz : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Select_Channel_Width_5GHz instance = new Select_Channel_Width_5GHz();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Select_Channel_Width_5GHz()
        {
            Channel_Width_5GHz = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Select_Channel_Width_5GHz Instance
        {
            get { return instance; }
        }

#region Variables

        string _Channel_Width_5GHz;

        /// <summary>
        /// Gets or sets the value of variable Channel_Width_5GHz.
        /// </summary>
        [TestVariable("9d38b288-01ca-4d7e-b549-7239187ac150")]
        public string Channel_Width_5GHz
        {
            get { return _Channel_Width_5GHz; }
            set { _Channel_Width_5GHz = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.SomeSpanTag2' at 139;21.", repo.WebDocumentIE.SomeSpanTag2Info, new RecordItemIndex(0));
            repo.WebDocumentIE.SomeSpanTag2.Click("139;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.LiTag2040MHz' at 71;12.", repo.WebDocumentIE.LiTag2040MHzInfo, new RecordItemIndex(1));
            repo.WebDocumentIE.LiTag2040MHz.Click("71;12");
            Delay.Milliseconds(200);
            
            Choose_Channel_Width_5GHz(Channel_Width_5GHz);
            Delay.Milliseconds(0);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(3));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
