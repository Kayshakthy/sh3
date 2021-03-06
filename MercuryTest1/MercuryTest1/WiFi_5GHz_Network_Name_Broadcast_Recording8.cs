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
    ///The WiFi_5GHz_Network_Name_Broadcast_Recording8 recording.
    /// </summary>
    [TestModule("bd0ef425-fea7-4d72-a9e8-6cf5b427fcef", ModuleType.Recording, 1)]
    public partial class WiFi_5GHz_Network_Name_Broadcast_Recording8 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static WiFi_5GHz_Network_Name_Broadcast_Recording8 instance = new WiFi_5GHz_Network_Name_Broadcast_Recording8();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public WiFi_5GHz_Network_Name_Broadcast_Recording8()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static WiFi_5GHz_Network_Name_Broadcast_Recording8 Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-DisableSSIDBroadcastSecurity50') on item 'WebDocumentIE.FmRbtnDisableSSIDBroadcastSecurity50'.", repo.WebDocumentIE.FmRbtnDisableSSIDBroadcastSecurity50Info, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocumentIE.FmRbtnDisableSSIDBroadcastSecurity50Info, "Id", "fmRbtn-DisableSSIDBroadcastSecurity50");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.FmRbtnDisableSSIDBroadcastSecurity50' at 13;20.", repo.WebDocumentIE.FmRbtnDisableSSIDBroadcastSecurity50Info, new RecordItemIndex(1));
            repo.WebDocumentIE.FmRbtnDisableSSIDBroadcastSecurity50.Click("13;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-EnableSSIDBroadcastSecurity50') on item 'WebDocumentIE.FmRbtnEnableSSIDBroadcastSecurity50'.", repo.WebDocumentIE.FmRbtnEnableSSIDBroadcastSecurity50Info, new RecordItemIndex(2));
            Validate.Attribute(repo.WebDocumentIE.FmRbtnEnableSSIDBroadcastSecurity50Info, "Id", "fmRbtn-EnableSSIDBroadcastSecurity50");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.FmRbtnEnableSSIDBroadcastSecurity50' at 14;18.", repo.WebDocumentIE.FmRbtnEnableSSIDBroadcastSecurity50Info, new RecordItemIndex(3));
            repo.WebDocumentIE.FmRbtnEnableSSIDBroadcastSecurity50.Click("14;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -2040 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(-2040);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button25' at 102;31.", repo.WebDocument19216801.Button25Info, new RecordItemIndex(5));
            repo.WebDocument19216801.Button25.Click("102;31");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
