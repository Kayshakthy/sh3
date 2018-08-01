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
    ///The Choose_First_Port_Forward_Rule recording.
    /// </summary>
    [TestModule("38fa91f6-702f-4afd-a49c-e7dee813c68f", ModuleType.Recording, 1)]
    public partial class Choose_First_Port_Forward_Rule : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Choose_First_Port_Forward_Rule instance = new Choose_First_Port_Forward_Rule();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Choose_First_Port_Forward_Rule()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Choose_First_Port_Forward_Rule Instance
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

            //repo.WebDocumentIE.Self.MoveTo("1355;89");
            //Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //repo.WebDocumentIE.Self.MoveTo("1344;381");
            //Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmCheckbox') on item 'WebDocumentIE.FmCbxFm02'.", repo.WebDocumentIE.FmCbxFm02Info, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocumentIE.FmCbxFm02Info, "Class", "fmCheckbox");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmCbx-fm-0-2') on item 'WebDocumentIE.FmCbxFm02'.", repo.WebDocumentIE.FmCbxFm02Info, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocumentIE.FmCbxFm02Info, "Id", "fmCbx-fm-0-2");
            //Delay.Milliseconds(100);
            
            repo.WebDocumentIE.FmCbxFm02.Click("15;19");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocumentIE.FmCbxFm02'.", repo.WebDocumentIE.FmCbxFm02Info, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocumentIE.FmCbxFm02Info, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='fmCheckbox checked') on item 'WebDocumentIE.FmCbxFm02'.", repo.WebDocumentIE.FmCbxFm02Info, new RecordItemIndex(6));
            //Validate.Attribute(repo.WebDocumentIE.FmCbxFm02Info, "Class", "fmCheckbox checked");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='fmCbx-fm-0-2') on item 'WebDocumentIE.FmCbxFm02'.", repo.WebDocumentIE.FmCbxFm02Info, new RecordItemIndex(7));
            //Validate.Attribute(repo.WebDocumentIE.FmCbxFm02Info, "Id", "fmCbx-fm-0-2");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=26,Height=26}) on item 'WebDocumentIE.FmCbxFm02'.", repo.WebDocumentIE.FmCbxFm02Info, new RecordItemIndex(8));
            Validate.ContainsImage(repo.WebDocumentIE.FmCbxFm02Info, FmCbxFm02_Screenshot1, FmCbxFm02_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report_Screenshot_FmCbxFm02();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage FmCbxFm02_Screenshot1
        { get { return repo.WebDocumentIE.FmCbxFm02Info.GetScreenshot1(new Rectangle(0, 0, 26, 26)); } }

        Imaging.FindOptions FmCbxFm02_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}