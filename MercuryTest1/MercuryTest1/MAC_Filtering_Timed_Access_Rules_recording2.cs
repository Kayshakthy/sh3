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
    ///The MAC_Filtering_Timed_Access_Rules_recording2 recording.
    /// </summary>
    [TestModule("76bef185-ca0c-4608-a5c8-25f299d736c1", ModuleType.Recording, 1)]
    public partial class MAC_Filtering_Timed_Access_Rules_recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static MAC_Filtering_Timed_Access_Rules_recording2 instance = new MAC_Filtering_Timed_Access_Rules_recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public MAC_Filtering_Timed_Access_Rules_recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static MAC_Filtering_Timed_Access_Rules_recording2 Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.MACFiltering' at 72;2.", repo.WebDocument19216801.MACFilteringInfo, new RecordItemIndex(0));
            repo.WebDocument19216801.MACFiltering.Click("72;2");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.WebDocument19216801' at 1725;465.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(1));
            repo.WebDocument19216801.WebDocument19216801.Click("1725;465");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -1080 units.", new RecordItemIndex(2));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnTimeLimitation' at 15;20.", repo.WebDocument19216801.FmRbtnTimeLimitationInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.FmRbtnTimeLimitation.Click("15;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnGeneral' at 13;14.", repo.WebDocument19216801.FmRbtnGeneralInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.FmRbtnGeneral.Click("13;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='The same time every day') on item 'WebDocumentIE.TheSameTimeEveryDay'.", repo.WebDocumentIE.TheSameTimeEveryDayInfo, new RecordItemIndex(5));
            Validate.Attribute(repo.WebDocumentIE.TheSameTimeEveryDayInfo, "InnerText", "The same time every day");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=190,Height=20}) on item 'WebDocumentIE.TheSameTimeEveryDay'.", repo.WebDocumentIE.TheSameTimeEveryDayInfo, new RecordItemIndex(6));
            Validate.ContainsImage(repo.WebDocumentIE.TheSameTimeEveryDayInfo, TheSameTimeEveryDay_Screenshot1, TheSameTimeEveryDay_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='parental_ctrl_schedulelink') on item 'WebDocument19216801.Slidersel.ClearAll'.", repo.WebDocument19216801.Slidersel.ClearAllInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocument19216801.Slidersel.ClearAllInfo, "Class", "parental_ctrl_schedulelink");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Clear All') on item 'WebDocument19216801.Slidersel.ClearAll'.", repo.WebDocument19216801.Slidersel.ClearAllInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.Slidersel.ClearAllInfo, "InnerText", "Clear All");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=72,Height=23}) on item 'WebDocument19216801.Slidersel.ClearAll'.", repo.WebDocument19216801.Slidersel.ClearAllInfo, new RecordItemIndex(9));
            Validate.ContainsImage(repo.WebDocument19216801.Slidersel.ClearAllInfo, ClearAll_Screenshot2, ClearAll_Screenshot2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Slidersel.ClearAll' at 40;15.", repo.WebDocument19216801.Slidersel.ClearAllInfo, new RecordItemIndex(10));
            repo.WebDocument19216801.Slidersel.ClearAll.Click("40;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1904;673.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(11));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1904;673");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1913;786.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(12));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1913;786");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPDelete' at 66;27.", repo.WebDocument19216801.IPDeleteInfo, new RecordItemIndex(13));
            repo.WebDocument19216801.IPDelete.Click("66;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1909;340.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(14));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1909;340");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1919;831.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(15));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1919;831");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnDaily' at 13;18.", repo.WebDocument19216801.FmRbtnDailyInfo, new RecordItemIndex(16));
            repo.WebDocument19216801.FmRbtnDaily.Click("13;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.WeekSchedule.ClearAll' at 32;11.", repo.WebDocument19216801.WeekSchedule.ClearAllInfo, new RecordItemIndex(17));
            repo.WebDocument19216801.WeekSchedule.ClearAll.Click("32;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1908;705.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(18));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1908;705");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1919;814.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(19));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1919;814");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Different times on different days of the week.') on item 'WebDocumentIE.DifferentTimesOnDifferentDaysOfThe'.", repo.WebDocumentIE.DifferentTimesOnDifferentDaysOfTheInfo, new RecordItemIndex(20));
            Validate.Attribute(repo.WebDocumentIE.DifferentTimesOnDifferentDaysOfTheInfo, "InnerText", "Different times on different days of the week.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=340,Height=20}) on item 'WebDocumentIE.DifferentTimesOnDifferentDaysOfThe'.", repo.WebDocumentIE.DifferentTimesOnDifferentDaysOfTheInfo, new RecordItemIndex(21));
            Validate.ContainsImage(repo.WebDocumentIE.DifferentTimesOnDifferentDaysOfTheInfo, DifferentTimesOnDifferentDaysOfThe_Screenshot1, DifferentTimesOnDifferentDaysOfThe_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPDelete' at 94;14.", repo.WebDocument19216801.IPDeleteInfo, new RecordItemIndex(22));
            repo.WebDocument19216801.IPDelete.Click("94;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1905;339.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(23));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1905;339");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1919;904.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(24));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1919;904");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Slidersel.ClearAll' at 28;17.", repo.WebDocument19216801.Slidersel.ClearAllInfo, new RecordItemIndex(25));
            repo.WebDocument19216801.Slidersel.ClearAll.Click("28;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPDelete' at 75;26.", repo.WebDocument19216801.IPDeleteInfo, new RecordItemIndex(26));
            repo.WebDocument19216801.IPDelete.Click("75;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -1080 units.", new RecordItemIndex(27));
            Mouse.ScrollWheel(-1080);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Time schedule not specified') on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(28));
            Validate.Attribute(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, "InnerText", "Time schedule not specified");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='span') on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(29));
            Validate.Attribute(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, "TagName", "span");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=176,Height=26}) on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(30));
            Validate.ContainsImage(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, TimeScheduleNotSpecified_Screenshot1, TimeScheduleNotSpecified_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='warnClose') on item 'WebDocumentIE.WarnClose'.", repo.WebDocumentIE.WarnCloseInfo, new RecordItemIndex(31));
            Validate.Attribute(repo.WebDocumentIE.WarnCloseInfo, "Class", "warnClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnDaily' at 14;22.", repo.WebDocument19216801.FmRbtnDailyInfo, new RecordItemIndex(32));
            repo.WebDocument19216801.FmRbtnDaily.Click("14;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -360 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(-360);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPDelete' at 96;28.", repo.WebDocument19216801.IPDeleteInfo, new RecordItemIndex(34));
            repo.WebDocument19216801.IPDelete.Click("96;28");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -1200 units.", new RecordItemIndex(35));
            Mouse.ScrollWheel(-1200);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Time schedule not specified') on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(36));
            Validate.Attribute(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, "InnerText", "Time schedule not specified");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='span') on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(37));
            Validate.Attribute(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, "TagName", "span");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=176,Height=26}) on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(38));
            Validate.ContainsImage(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, TimeScheduleNotSpecified_Screenshot1_2, TimeScheduleNotSpecified_Screenshot1_2_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='warnClose') on item 'WebDocumentIE.WarnClose'.", repo.WebDocumentIE.WarnCloseInfo, new RecordItemIndex(39));
            Validate.Attribute(repo.WebDocumentIE.WarnCloseInfo, "Class", "warnClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocumentIE.WarnClose'.", repo.WebDocumentIE.WarnCloseInfo, new RecordItemIndex(40));
            Validate.ContainsImage(repo.WebDocumentIE.WarnCloseInfo, WarnClose_Screenshot1, WarnClose_Screenshot1_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmRbtnGeneral' at 14;20.", repo.WebDocument19216801.FmRbtnGeneralInfo, new RecordItemIndex(41));
            repo.WebDocument19216801.FmRbtnGeneral.Click("14;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPDelete' at 120;26.", repo.WebDocument19216801.IPDeleteInfo, new RecordItemIndex(42));
            repo.WebDocument19216801.IPDelete.Click("120;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -840 units.", new RecordItemIndex(43));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Time schedule not specified') on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(44));
            Validate.Attribute(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, "InnerText", "Time schedule not specified");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='span') on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(45));
            Validate.Attribute(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, "TagName", "span");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=176,Height=26}) on item 'WebDocumentIE.TimeScheduleNotSpecified'.", repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, new RecordItemIndex(46));
            Validate.ContainsImage(repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo, TimeScheduleNotSpecified_Screenshot1_3, TimeScheduleNotSpecified_Screenshot1_3_Options);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='warnClose') on item 'WebDocumentIE.WarnClose'.", repo.WebDocumentIE.WarnCloseInfo, new RecordItemIndex(47));
            Validate.Attribute(repo.WebDocumentIE.WarnCloseInfo, "Class", "warnClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='div') on item 'WebDocumentIE.WarnClose'.", repo.WebDocumentIE.WarnCloseInfo, new RecordItemIndex(48));
            Validate.Attribute(repo.WebDocumentIE.WarnCloseInfo, "TagName", "div");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=31,Height=36}) on item 'WebDocumentIE.WarnClose'.", repo.WebDocumentIE.WarnCloseInfo, new RecordItemIndex(49));
            Validate.ContainsImage(repo.WebDocumentIE.WarnCloseInfo, WarnClose_Screenshot2, WarnClose_Screenshot2_Options);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage TheSameTimeEveryDay_Screenshot1
        { get { return repo.WebDocumentIE.TheSameTimeEveryDayInfo.GetScreenshot1(new Rectangle(0, 0, 190, 20)); } }

        Imaging.FindOptions TheSameTimeEveryDay_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage ClearAll_Screenshot2
        { get { return repo.WebDocument19216801.Slidersel.ClearAllInfo.GetScreenshot2(new Rectangle(0, 0, 72, 23)); } }

        Imaging.FindOptions ClearAll_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage DifferentTimesOnDifferentDaysOfThe_Screenshot1
        { get { return repo.WebDocumentIE.DifferentTimesOnDifferentDaysOfTheInfo.GetScreenshot1(new Rectangle(0, 0, 340, 20)); } }

        Imaging.FindOptions DifferentTimesOnDifferentDaysOfThe_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TimeScheduleNotSpecified_Screenshot1
        { get { return repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo.GetScreenshot1(new Rectangle(0, 0, 176, 26)); } }

        Imaging.FindOptions TimeScheduleNotSpecified_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TimeScheduleNotSpecified_Screenshot1_2
        { get { return repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo.GetScreenshot1(new Rectangle(0, 0, 176, 26)); } }

        Imaging.FindOptions TimeScheduleNotSpecified_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage WarnClose_Screenshot1
        { get { return repo.WebDocumentIE.WarnCloseInfo.GetScreenshot1(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions WarnClose_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage TimeScheduleNotSpecified_Screenshot1_3
        { get { return repo.WebDocumentIE.TimeScheduleNotSpecifiedInfo.GetScreenshot1(new Rectangle(0, 0, 176, 26)); } }

        Imaging.FindOptions TimeScheduleNotSpecified_Screenshot1_3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage WarnClose_Screenshot2
        { get { return repo.WebDocumentIE.WarnCloseInfo.GetScreenshot2(new Rectangle(0, 0, 31, 36)); } }

        Imaging.FindOptions WarnClose_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
