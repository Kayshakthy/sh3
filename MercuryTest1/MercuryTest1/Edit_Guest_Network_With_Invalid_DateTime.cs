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
    ///The Edit_Guest_Network_With_Invalid_DateTime recording.
    /// </summary>
    [TestModule("0527a775-7f53-4bdf-91f8-96fd2ea49954", ModuleType.Recording, 1)]
    public partial class Edit_Guest_Network_With_Invalid_DateTime : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Edit_Guest_Network_With_Invalid_DateTime instance = new Edit_Guest_Network_With_Invalid_DateTime();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Edit_Guest_Network_With_Invalid_DateTime()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Edit_Guest_Network_With_Invalid_DateTime Instance
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

            repo.WebDocument19216801.ModifyYourGuestNetwork.Click("95;16");
            Delay.Milliseconds(200);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(1));
            
            Validate.Attribute(repo.WebDocument19216801.GuestNetworkInfo, "InnerText", "Guest network");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.TrEditGuestNetworkInfo, "Id", "tr_EditGuestNetwork");
            Delay.Milliseconds(100);
            
            repo.WebDocument19216801.FmChbxEditGuestNetwork.Click("15;20");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocument19216801.FmChbxEditGuestNetworkInfo, "Class", "fmCheckbox checked");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.FmChbxEditGuestNetworkInfo, "Id", "fmChbx-EditGuestNetwork");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(7));
            
            repo.WebDocument19216801.GuestApplyOrNext.Click("44;26");
            Delay.Milliseconds(200);
            
            repo.WebDocument19216801.Button2.Click("84;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='At what times would you like your guest network to be enabled?') on item 'WebDocument19216801.GuestNetworkFrame3.AtWhatTimesWouldYouLikeYourGuest'.", repo.WebDocument19216801.GuestNetworkFrame3.AtWhatTimesWouldYouLikeYourGuestInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.GuestNetworkFrame3.AtWhatTimesWouldYouLikeYourGuestInfo, "InnerText", "At what times would you like your guest network to be enabled?");
            Delay.Milliseconds(100);
            
            repo.WebDocument19216801.FmRbtnGuestTimeBased.Click("14;16");
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument19216801.TrGuestTimeBasedInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.TrGuestTimeBasedInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.GuestNetworkFrame3.Button' at 173;38.", repo.WebDocument19216801.GuestNetworkFrame3.ButtonInfo, new RecordItemIndex(14));
            repo.WebDocument19216801.GuestNetworkFrame3.Button.Click("173;38");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your guest network settings have been updated.') on item 'WebDocument19216801.YourGuestNetworkSettingsHaveBeenUp'.", repo.WebDocument19216801.YourGuestNetworkSettingsHaveBeenUpInfo, new RecordItemIndex(15));
            //Validate.Attribute(repo.WebDocument19216801.YourGuestNetworkSettingsHaveBeenUpInfo, "InnerText", "Your guest network settings have been updated.");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='circle') on item 'WebDocument19216801.Circle'.", repo.WebDocument19216801.CircleInfo, new RecordItemIndex(16));
            //Validate.Attribute(repo.WebDocument19216801.CircleInfo, "TagName", "circle");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button26' at 80;36.", repo.WebDocument19216801.Button26Info, new RecordItemIndex(17));
            //repo.WebDocument19216801.Button26.Click("80;36");
            //Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Please choose a valid date and time.') on item 'WebDocument19216801.PleaseChooseAValidDateAndTime'.", repo.WebDocument19216801.PleaseChooseAValidDateAndTimeInfo, new RecordItemIndex(18));
            Validate.Attribute(repo.WebDocument19216801.PleaseChooseAValidDateAndTimeInfo, "InnerText", "Please choose a valid date and time.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrCloseDatepicker'.", repo.WebDocument19216801.ErrCloseDatepickerInfo, new RecordItemIndex(19));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseDatepickerInfo, "Class", "errTipClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-datepicker') on item 'WebDocument19216801.ErrCloseDatepicker'.", repo.WebDocument19216801.ErrCloseDatepickerInfo, new RecordItemIndex(20));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseDatepickerInfo, "Id", "errClose-datepicker");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
