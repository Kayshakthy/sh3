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
    ///The Error_Messages_Different_Access_Time recording.
    /// </summary>
    [TestModule("3365c236-840b-4afb-ada1-414e031f6f20", ModuleType.Recording, 1)]
    public partial class Error_Messages_Different_Access_Time : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Error_Messages_Different_Access_Time instance = new Error_Messages_Different_Access_Time();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Error_Messages_Different_Access_Time()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Error_Messages_Different_Access_Time Instance
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

            //Validate.Attribute(repo.WebDocumentIE.IOnlyWantToRestrictInternetAccessInfo, "InnerText", "I only want to restrict internet access at:");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='I only want to restrict internet access at') on item 'WebDocument19216801.IOnlyWantToRestrictInternetAccess'.", repo.WebDocument19216801.IOnlyWantToRestrictInternetAccessInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.IOnlyWantToRestrictInternetAccessInfo, "InnerText", "I only want to restrict internet access at");
            Delay.Milliseconds(100);
            
            repo.WebDocument19216801.FmRbtnTimeLimitation.Click("12;20");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.FmRbtnDaily.Click("13;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -2520 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(-2520);
            Delay.Milliseconds(500);
            
            Validate.Attribute(repo.WebDocument19216801.Slidersel.ClearAllInfo, "InnerText", "Clear All");
            Delay.Milliseconds(100);
            
            repo.WebDocument19216801.Slidersel.ClearAll.Click("26;12");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Button25.Click("93;25");
            Delay.Milliseconds(200);
            
            //Validate_TimeScheduleNotSpecified();
            //Delay.Milliseconds(0);
            
            Validate.Attribute(repo.WebDocumentIE.WarnCloseInfo, "Class", "warnClose");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.WarnCloseInfo, WarnClose_Screenshot4, WarnClose_Screenshot4_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.TheTotalNumberOfTimeRulesMustBeBInfo, "InnerText", "The total number of time rules must be between 1 and 32.");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(12));
            
            Validate_TheTotalNumberOfTimeRulesMustBeB();
            Delay.Milliseconds(0);
            
            repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdating.Click("606;33");
            Delay.Milliseconds(200);
            
            //Validate_SorryThereWasAnErrorWhileUpdating();
            //Delay.Milliseconds(0);
            
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.Http19216801IErrorIconSvgInfo, "Src", "http://192.168.0.1/i/error-icon.svg");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.ConfirmWizard1.Http19216801IErrorIconSvgInfo, Http19216801IErrorIconSvg_Screenshot3, Http19216801IErrorIconSvg_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdatingInfo, "Class", "confirm-wizard-text");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdatingInfo, "InnerText", "Sorry! There was an error while updating your settings. Please try again a bit later.");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(20));
            
            Validate_SorryThereWasAnErrorWhileUpdating1();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage TimeScheduleNotSpecified_Screenshot1
        { get { return repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions TimeScheduleNotSpecified_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage WarnClose_Screenshot4
        { get { return repo.WebDocumentIE.WarnCloseInfo.GetScreenshot4(new Rectangle(0, 0, 25, 29)); } }

        Imaging.FindOptions WarnClose_Screenshot4_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage SorryThereWasAnErrorWhileUpdating_Screenshot1
        { get { return repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdatingInfo.GetScreenshot1(new Rectangle(0, 0, 0, 0)); } }

        Imaging.FindOptions SorryThereWasAnErrorWhileUpdating_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Http19216801IErrorIconSvg_Screenshot3
        { get { return repo.WebDocumentIE.ConfirmWizard1.Http19216801IErrorIconSvgInfo.GetScreenshot3(new Rectangle(0, 0, 30, 30)); } }

        Imaging.FindOptions Http19216801IErrorIconSvg_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
