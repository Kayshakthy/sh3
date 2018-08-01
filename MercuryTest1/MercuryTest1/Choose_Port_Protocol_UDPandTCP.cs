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
    ///The Choose_Port_Protocol_UDPandTCP recording.
    /// </summary>
    [TestModule("31d2a5d5-5e70-45e5-93d8-f20fe318ac49", ModuleType.Recording, 1)]
    public partial class Choose_Port_Protocol_UDPandTCP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Port_Protocol_UDPandTCP instance = new Choose_Port_Protocol_UDPandTCP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Port_Protocol_UDPandTCP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Port_Protocol_UDPandTCP Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 168;18.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(0));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("168;18");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.UDPAndTCP' at 94;12.", repo.WebDocument19216801.FmSelProtocol.UDPAndTCPInfo, new RecordItemIndex(1));
            //repo.WebDocument19216801.FmSelProtocol.UDPAndTCP.Click("94;12");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmSelProtocol.UDPAndTCP'.", repo.WebDocument19216801.FmSelProtocol.UDPAndTCPInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.UDPAndTCPInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='UDP and TCP') on item 'WebDocument19216801.FmSelProtocol.UDPAndTCP'.", repo.WebDocument19216801.FmSelProtocol.UDPAndTCPInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.UDPAndTCPInfo, "InnerText", "UDP and TCP");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.FmSelProtocol.UDPAndTCP'.", repo.WebDocument19216801.FmSelProtocol.UDPAndTCPInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.UDPAndTCPInfo, "Visible", "True");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 165;8.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(5));
            repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("165;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Return}' with focus on 'WebDocument19216801.FmSelProtocol.SomeSpanTag8'.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(6));
            repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.PressKeys("{Down}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{Return}' with focus on 'WebDocument19216801.FmSelProtocol.SomeSpanTag8'.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(7));
            repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.PressKeys("{Down}{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}