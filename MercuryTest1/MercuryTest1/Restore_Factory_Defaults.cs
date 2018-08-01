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
    ///The Restore_Factory_Defaults recording.
    /// </summary>
    [TestModule("f49c7276-6855-4b82-b4ad-165dc47f4ffa", ModuleType.Recording, 1)]
    public partial class Restore_Factory_Defaults : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Restore_Factory_Defaults instance = new Restore_Factory_Defaults();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Restore_Factory_Defaults()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Restore_Factory_Defaults Instance
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

            //Validate.Attribute(repo.WebDocument19216801.Button17Info, "TagValue", "Restore default");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.Button17Info, "Tabindex", "5");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.Button17Info, "Value", "Restore default");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(3));
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=209,Height=62}) on item 'WebDocument19216801.Button17'.", repo.WebDocument19216801.Button17Info, new RecordItemIndex(4));
            //Validate.ContainsImage(repo.WebDocument19216801.Button17Info, Button17_Screenshot1, Button17_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocument19216801.Button17.Click();
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Button17.Click("128;40");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='wizard_button') on item 'WebDocument19216801.Button19'.", repo.WebDocument19216801.Button19Info, new RecordItemIndex(7));
            //Validate.Attribute(repo.WebDocument19216801.Button19Info, "Class", "wizard_button");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Cancel process') on item 'WebDocument19216801.Button19'.", repo.WebDocument19216801.Button19Info, new RecordItemIndex(8));
            //Validate.Attribute(repo.WebDocument19216801.Button19Info, "TagValue", "Cancel process");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Cancel process') on item 'WebDocument19216801.Button19'.", repo.WebDocument19216801.Button19Info, new RecordItemIndex(9));
            //Validate.Attribute(repo.WebDocument19216801.Button19Info, "Value", "Cancel process");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=353,Height=81}) on item 'WebDocument19216801.Button19'.", repo.WebDocument19216801.Button19Info, new RecordItemIndex(10));
            //Validate.ContainsImage(repo.WebDocument19216801.Button19Info, Button19_Screenshot1, Button19_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='wizard_button') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(11));
            //Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "Class", "wizard_button");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='enableGuestBtn') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(12));
            //Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "Id", "enableGuestBtn");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Restart') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(13));
            //Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "TagValue", "Restart");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Restart') on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocument19216801.EnableGuestBtnInfo, "Value", "Restart");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=220,Height=81}) on item 'WebDocument19216801.EnableGuestBtn'.", repo.WebDocument19216801.EnableGuestBtnInfo, new RecordItemIndex(15));
            //Validate.ContainsImage(repo.WebDocument19216801.EnableGuestBtnInfo, EnableGuestBtn_Screenshot1, EnableGuestBtn_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button19' at 238;44.", repo.WebDocument19216801.Button19Info, new RecordItemIndex(16));
            //repo.WebDocument19216801.Button19.Click("238;44");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button17' at 131;34.", repo.WebDocument19216801.Button17Info, new RecordItemIndex(17));
            //repo.WebDocument19216801.Button17.Click("131;34");
            //Delay.Milliseconds(200);
            
            repo.WebDocument19216801.EnableGuestBtn.Click("161;42");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.Overlaycontent'.", repo.WebDocument19216801.OverlaycontentInfo, new RecordItemIndex(19));
            Validate.Exists(repo.WebDocument19216801.OverlaycontentInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(20));
            
        }

#region Image Feature Data
        CompressedImage Button17_Screenshot1
        { get { return repo.WebDocument19216801.Button17Info.GetScreenshot1(new Rectangle(0, 0, 209, 62)); } }

        Imaging.FindOptions Button17_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button19_Screenshot1
        { get { return repo.WebDocument19216801.Button19Info.GetScreenshot1(new Rectangle(0, 0, 353, 81)); } }

        Imaging.FindOptions Button19_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage EnableGuestBtn_Screenshot1
        { get { return repo.WebDocument19216801.EnableGuestBtnInfo.GetScreenshot1(new Rectangle(0, 0, 220, 81)); } }

        Imaging.FindOptions EnableGuestBtn_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}