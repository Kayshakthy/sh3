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
    ///The Choose_Port_Protocol_UDP recording.
    /// </summary>
    [TestModule("1e42d96b-5763-4c37-af55-9f8d338d08a8", ModuleType.Recording, 1)]
    public partial class Choose_Port_Protocol_UDP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_Port_Protocol_UDP instance = new Choose_Port_Protocol_UDP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_Port_Protocol_UDP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_Port_Protocol_UDP Instance
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

            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 163;16.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(0));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("163;16");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 167;11.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(1));
            //repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("167;11");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.CiteTagUDP' at 138;14.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(2));
            //repo.WebDocument19216801.FmSelProtocol.CiteTagUDP.Click("138;14");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='UDP') on item 'WebDocument19216801.FmSelProtocol.CiteTagUDP'.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, "InnerText", "UDP");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.FmSelProtocol.CiteTagUDP'.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='cite') on item 'WebDocument19216801.FmSelProtocol.CiteTagUDP'.", repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.FmSelProtocol.CiteTagUDPInfo, "TagName", "cite");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelProtocol.SomeSpanTag8' at 163;9.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(6));
            repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.Click("163;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Return}' with focus on 'WebDocument19216801.FmSelProtocol.SomeSpanTag8'.", repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8Info, new RecordItemIndex(7));
            repo.WebDocument19216801.FmSelProtocol.SomeSpanTag8.PressKeys("{Return}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
