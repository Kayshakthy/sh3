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
    ///The Enable_WPS_Push_Button recording.
    /// </summary>
    [TestModule("77e03b94-09f8-4d7f-ae97-36e11be6fbb9", ModuleType.Recording, 1)]
    public partial class Enable_WPS_Push_Button : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Enable_WPS_Push_Button instance = new Enable_WPS_Push_Button();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enable_WPS_Push_Button()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enable_WPS_Push_Button Instance
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

            repo.WebDocument19216801.FmRbtnEnableWPSpush.Click("17;17");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.Enable'.", repo.WebDocument19216801.EnableInfo, new RecordItemIndex(1));
            //Validate.Attribute(repo.WebDocument19216801.EnableInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Enable') on item 'WebDocument19216801.Enable'.", repo.WebDocument19216801.EnableInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.EnableInfo, "InnerText", "Enable");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=45,Height=16}) on item 'WebDocument19216801.Enable'.", repo.WebDocument19216801.EnableInfo, new RecordItemIndex(3));
            //Validate.ContainsImage(repo.WebDocument19216801.EnableInfo, Enable_Screenshot1, Enable_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Success, "User", "Enable WPS Push Button", repo.WebDocumentIE.TrEnableWPSpush, false, new RecordItemIndex(4));
            
        }

#region Image Feature Data
        CompressedImage Enable_Screenshot1
        { get { return repo.WebDocument19216801.EnableInfo.GetScreenshot1(new Rectangle(0, 0, 45, 16)); } }

        Imaging.FindOptions Enable_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
