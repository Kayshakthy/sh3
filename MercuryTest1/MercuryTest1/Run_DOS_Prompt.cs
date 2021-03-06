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
    ///The Run_DOS_Prompt recording.
    /// </summary>
    [TestModule("0f35b7ad-cb71-4e0f-b3d9-0e9e2cf21e08", ModuleType.Recording, 1)]
    public partial class Run_DOS_Prompt : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Run_DOS_Prompt instance = new Run_DOS_Prompt();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Run_DOS_Prompt()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Run_DOS_Prompt Instance
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

            Report.Log(ReportLevel.Info, "Application", "Run application 'C:\\Windows\\System32\\cmd.exe' with arguments '' in maximized mode.", new RecordItemIndex(0));
            Host.Local.RunApplication("C:\\Windows\\System32\\cmd.exe", "", "", true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWindowsSystem32CmdExe' at 295;125.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(1));
            repo.CWindowsSystem32CmdExe.Self.Click("295;125");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ipconfig{Return}'.", new RecordItemIndex(2));
            Keyboard.Press("ipconfig{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ipconfig/all{Return}'.", new RecordItemIndex(3));
            Keyboard.Press("ipconfig/all{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'exit'.", new RecordItemIndex(4));
            Keyboard.Press("exit");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}'.", new RecordItemIndex(5));
            Keyboard.Press("{Return}");
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(6));
            //Delay.Duration(500, false);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'CWindowsSystem32CmdExe' at 308;396.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(7));
            //repo.CWindowsSystem32CmdExe.Self.Click("308;396");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'ipconfig{Return}' with focus on 'CWindowsSystem32CmdExe'.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(8));
            //repo.CWindowsSystem32CmdExe.Self.PressKeys("ipconfig{Return}");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'exit' with focus on 'CWindowsSystem32CmdExe'.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(9));
            //repo.CWindowsSystem32CmdExe.Self.PressKeys("exit");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'CWindowsSystem32CmdExe'.", repo.CWindowsSystem32CmdExe.SelfInfo, new RecordItemIndex(10));
            //repo.CWindowsSystem32CmdExe.Self.PressKeys("{Return}");
            //Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
