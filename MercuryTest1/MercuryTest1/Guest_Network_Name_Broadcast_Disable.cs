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
    ///The Guest_Network_Name_Broadcast_Disable recording.
    /// </summary>
    [TestModule("40756115-0885-4812-85af-83ce705fdfda", ModuleType.Recording, 1)]
    public partial class Guest_Network_Name_Broadcast_Disable : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Guest_Network_Name_Broadcast_Disable instance = new Guest_Network_Name_Broadcast_Disable();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Guest_Network_Name_Broadcast_Disable()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Guest_Network_Name_Broadcast_Disable Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnDisableSSIDBroadcastGuest' at 16;19.", repo.WebDocument19216801.FmRbtnDisableSSIDBroadcastGuestInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.FmRbtnDisableSSIDBroadcastGuest.Click("16;19");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button7' at 122;36.", repo.WebDocument19216801.Button7Info, new RecordItemIndex(1));
            //repo.WebDocument19216801.Button7.Click("122;36");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button7' at 89;23.", repo.WebDocument19216801.Button7Info, new RecordItemIndex(2));
            //repo.WebDocument19216801.Button7.Click("89;23");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button7' at 116;31.", repo.WebDocument19216801.Button7Info, new RecordItemIndex(3));
            repo.WebDocument19216801.Button7.Click("116;31");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(4));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
