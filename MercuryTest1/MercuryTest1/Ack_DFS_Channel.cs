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
    ///The Ack_DFS_Channel recording.
    /// </summary>
    [TestModule("5d8b66b2-d44e-4326-b461-a31b45f5fd4a", ModuleType.Recording, 1)]
    public partial class Ack_DFS_Channel : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Ack_DFS_Channel instance = new Ack_DFS_Channel();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Ack_DFS_Channel()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Ack_DFS_Channel Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelChannel50.SomeSpanTag11' at 153;20.", repo.WebDocument19216801.FmSelChannel50.SomeSpanTag11Info, new RecordItemIndex(0));
            repo.WebDocument19216801.FmSelChannel50.SomeSpanTag11.Click("153;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.FmSelChannel50.SomeUlTag' at 159;48.", repo.WebDocument19216801.FmSelChannel50.SomeUlTagInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.FmSelChannel50.SomeUlTag.MoveTo("159;48");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.FmSelChannel50.SomeUlTag' at 160;88.", repo.WebDocument19216801.FmSelChannel50.SomeUlTagInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.FmSelChannel50.SomeUlTag.MoveTo("160;88");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelChannel50.Channel116' at 80;17.", repo.WebDocument19216801.FmSelChannel50.Channel116Info, new RecordItemIndex(3));
            repo.WebDocument19216801.FmSelChannel50.Channel116.Click("80;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by 480 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(480);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='closetext') on item 'WebDocument19216801.Close1'.", repo.WebDocument19216801.Close1Info, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocument19216801.Close1Info, "Class", "closetext");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Close') on item 'WebDocument19216801.Close1'.", repo.WebDocument19216801.Close1Info, new RecordItemIndex(6));
            Validate.Attribute(repo.WebDocument19216801.Close1Info, "InnerText", "Close");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=108,Height=56}) on item 'WebDocument19216801.Close1'.", repo.WebDocument19216801.Close1Info, new RecordItemIndex(7));
            Validate.ContainsImage(repo.WebDocument19216801.Close1Info, Close1_Screenshot1, Close1_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Close1' at 64;25.", repo.WebDocument19216801.Close1Info, new RecordItemIndex(8));
            repo.WebDocument19216801.Close1.Click("64;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelChannel50.SomeSpanTag11' at 149;20.", repo.WebDocument19216801.FmSelChannel50.SomeSpanTag11Info, new RecordItemIndex(9));
            repo.WebDocument19216801.FmSelChannel50.SomeSpanTag11.Click("149;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelChannel50.Channel132' at 110;9.", repo.WebDocument19216801.FmSelChannel50.Channel132Info, new RecordItemIndex(10));
            repo.WebDocument19216801.FmSelChannel50.Channel132.Click("110;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='overlaycontent-title') on item 'WebDocument19216801.DfsWizardFrame0.Warning'.", repo.WebDocument19216801.DfsWizardFrame0.WarningInfo, new RecordItemIndex(11));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.WarningInfo, "Class", "overlaycontent-title");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Warning!') on item 'WebDocument19216801.DfsWizardFrame0.Warning'.", repo.WebDocument19216801.DfsWizardFrame0.WarningInfo, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.WarningInfo, "InnerText", "Warning!");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=862,Height=106}) on item 'WebDocument19216801.DfsWizardFrame0.Warning'.", repo.WebDocument19216801.DfsWizardFrame0.WarningInfo, new RecordItemIndex(13));
            Validate.ContainsImage(repo.WebDocument19216801.DfsWizardFrame0.WarningInfo, Warning_Screenshot1, Warning_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='wizard_button') on item 'WebDocument19216801.DfsWizardFrame0.Button26'.", repo.WebDocument19216801.DfsWizardFrame0.Button26Info, new RecordItemIndex(14));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.Button26Info, "Class", "wizard_button");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='No') on item 'WebDocument19216801.DfsWizardFrame0.Button26'.", repo.WebDocument19216801.DfsWizardFrame0.Button26Info, new RecordItemIndex(15));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.Button26Info, "TagValue", "No");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='No') on item 'WebDocument19216801.DfsWizardFrame0.Button26'.", repo.WebDocument19216801.DfsWizardFrame0.Button26Info, new RecordItemIndex(16));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.Button26Info, "Value", "No");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='wizard_button') on item 'WebDocument19216801.DfsWizardFrame0.Button27'.", repo.WebDocument19216801.DfsWizardFrame0.Button27Info, new RecordItemIndex(17));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.Button27Info, "Class", "wizard_button");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Yes') on item 'WebDocument19216801.DfsWizardFrame0.Button27'.", repo.WebDocument19216801.DfsWizardFrame0.Button27Info, new RecordItemIndex(18));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.Button27Info, "TagValue", "Yes");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Yes') on item 'WebDocument19216801.DfsWizardFrame0.Button27'.", repo.WebDocument19216801.DfsWizardFrame0.Button27Info, new RecordItemIndex(19));
            Validate.Attribute(repo.WebDocument19216801.DfsWizardFrame0.Button27Info, "Value", "Yes");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=143,Height=75}) on item 'WebDocument19216801.DfsWizardFrame0.Button27'.", repo.WebDocument19216801.DfsWizardFrame0.Button27Info, new RecordItemIndex(20));
            Validate.ContainsImage(repo.WebDocument19216801.DfsWizardFrame0.Button27Info, Button27_Screenshot1, Button27_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.DfsWizardFrame0.Button26' at 69;43.", repo.WebDocument19216801.DfsWizardFrame0.Button26Info, new RecordItemIndex(21));
            repo.WebDocument19216801.DfsWizardFrame0.Button26.Click("69;43");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrTipClose'.", repo.WebDocument19216801.ErrTipCloseInfo, new RecordItemIndex(22));
            Validate.Attribute(repo.WebDocument19216801.ErrTipCloseInfo, "Class", "errTipClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocument19216801.ErrTipClose'.", repo.WebDocument19216801.ErrTipCloseInfo, new RecordItemIndex(23));
            Validate.ContainsImage(repo.WebDocument19216801.ErrTipCloseInfo, ErrTipClose_Screenshot1, ErrTipClose_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='132 is a DFS channel.') on item 'WebDocument19216801.SpanTag132IsADFSChannel'.", repo.WebDocument19216801.SpanTag132IsADFSChannelInfo, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocument19216801.SpanTag132IsADFSChannelInfo, "InnerText", "132 is a DFS channel.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelChannel50.SomeSpanTag11' at 152;18.", repo.WebDocument19216801.FmSelChannel50.SomeSpanTag11Info, new RecordItemIndex(25));
            repo.WebDocument19216801.FmSelChannel50.SomeSpanTag11.Click("152;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmSelChannel50.Channel116' at 107;20.", repo.WebDocument19216801.FmSelChannel50.Channel116Info, new RecordItemIndex(26));
            repo.WebDocument19216801.FmSelChannel50.Channel116.Click("107;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.DfsWizardFrame0.Button27' at 75;38.", repo.WebDocument19216801.DfsWizardFrame0.Button27Info, new RecordItemIndex(27));
            repo.WebDocument19216801.DfsWizardFrame0.Button27.Click("75;38");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage Close1_Screenshot1
        { get { return repo.WebDocument19216801.Close1Info.GetScreenshot1(new Rectangle(0, 0, 108, 56)); } }

        Imaging.FindOptions Close1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Warning_Screenshot1
        { get { return repo.WebDocument19216801.DfsWizardFrame0.WarningInfo.GetScreenshot1(new Rectangle(0, 0, 862, 106)); } }

        Imaging.FindOptions Warning_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button27_Screenshot1
        { get { return repo.WebDocument19216801.DfsWizardFrame0.Button27Info.GetScreenshot1(new Rectangle(0, 0, 143, 75)); } }

        Imaging.FindOptions Button27_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ErrTipClose_Screenshot1
        { get { return repo.WebDocument19216801.ErrTipCloseInfo.GetScreenshot1(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions ErrTipClose_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
