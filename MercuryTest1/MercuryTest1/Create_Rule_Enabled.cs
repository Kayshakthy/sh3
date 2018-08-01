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
    ///The Create_Rule_Enabled recording.
    /// </summary>
    [TestModule("05129b9a-cce1-417f-a23a-0e5ce909ef2a", ModuleType.Recording, 1)]
    public partial class Create_Rule_Enabled : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Create_Rule_Enabled instance = new Create_Rule_Enabled();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Create_Rule_Enabled()
        {
            Dest_IP_Addr = "";
            SourcePortStart = "";
            SourcePortEnd = "80";
            DestPortStart = "";
            DestPortEnd = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Create_Rule_Enabled Instance
        {
            get { return instance; }
        }

#region Variables

        string _Dest_IP_Addr;

        /// <summary>
        /// Gets or sets the value of variable Dest_IP_Addr.
        /// </summary>
        [TestVariable("2bb35a2d-e467-400f-990b-6ba0099ec5c8")]
        public string Dest_IP_Addr
        {
            get { return _Dest_IP_Addr; }
            set { _Dest_IP_Addr = value; }
        }

        string _SourcePortStart;

        /// <summary>
        /// Gets or sets the value of variable SourcePortStart.
        /// </summary>
        [TestVariable("b6c5d920-d1a8-46d2-b2c3-30070be70591")]
        public string SourcePortStart
        {
            get { return _SourcePortStart; }
            set { _SourcePortStart = value; }
        }

        string _SourcePortEnd;

        /// <summary>
        /// Gets or sets the value of variable SourcePortEnd.
        /// </summary>
        [TestVariable("e36b4de2-895a-4746-84ed-a60d9db994a9")]
        public string SourcePortEnd
        {
            get { return _SourcePortEnd; }
            set { _SourcePortEnd = value; }
        }

        string _DestPortStart;

        /// <summary>
        /// Gets or sets the value of variable DestPortStart.
        /// </summary>
        [TestVariable("eb966637-0d45-490f-9e2b-1e2599e27a89")]
        public string DestPortStart
        {
            get { return _DestPortStart; }
            set { _DestPortStart = value; }
        }

        string _DestPortEnd;

        /// <summary>
        /// Gets or sets the value of variable DestPortEnd.
        /// </summary>
        [TestVariable("b0f74eae-c62d-43a3-bae1-953b19d95cb2")]
        public string DestPortEnd
        {
            get { return _DestPortEnd; }
            set { _DestPortEnd = value; }
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

            //repo.WebDocument19216801.CreateANewRule.Click();
            //Delay.Milliseconds(200);
            
            //repo.WebDocument19216801.IPAdd.Click("110;17");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.FmRbtnEnabled.Click("14;16");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.FmRbtnEnabled'.", repo.WebDocument19216801.FmRbtnEnabledInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.FmRbtnEnabledInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmRadio checked') on item 'WebDocument19216801.FmRbtnEnabled'.", repo.WebDocument19216801.FmRbtnEnabledInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.FmRbtnEnabledInfo, "Class", "fmRadio checked");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmRbtn-Enabled') on item 'WebDocument19216801.FmRbtnEnabled'.", repo.WebDocument19216801.FmRbtnEnabledInfo, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.FmRbtnEnabledInfo, "Id", "fmRbtn-Enabled");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=26,Height=26}) on item 'WebDocument19216801.FmRbtnEnabled'.", repo.WebDocument19216801.FmRbtnEnabledInfo, new RecordItemIndex(6));
            //Validate.ContainsImage(repo.WebDocument19216801.FmRbtnEnabledInfo, FmRbtnEnabled_Screenshot1, FmRbtnEnabled_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage FmRbtnEnabled_Screenshot1
        { get { return repo.WebDocument19216801.FmRbtnEnabledInfo.GetScreenshot1(new Rectangle(0, 0, 26, 26)); } }

        Imaging.FindOptions FmRbtnEnabled_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}