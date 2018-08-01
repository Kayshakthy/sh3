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
    ///The Check_Router_Status_Link recording.
    /// </summary>
    [TestModule("4d406e2b-1cd2-4370-a0be-a5230a1a9452", ModuleType.Recording, 1)]
    public partial class Check_Router_Status_Link : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Check_Router_Status_Link instance = new Check_Router_Status_Link();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Check_Router_Status_Link()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Check_Router_Status_Link Instance
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

            Validate.Attribute(repo.WebDocumentIE.CheckRouterStatusInfo, "InnerText", "Check router status");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.CheckRouterStatusInfo, "TagName", "span");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.CheckRouterStatusInfo, CheckRouterStatus_Screenshot1, CheckRouterStatus_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            repo.WebDocumentIE.CheckRouterStatus.Click("67;13");
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocumentIE.RouterStatusInfo, "Class", "overlaycontent-title");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.RouterStatusInfo, "InnerText", "Router status");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.RouterStatusInfo, RouterStatus_Screenshot1, RouterStatus_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.StatusInfo, "InnerText", "Status");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.StatusInfo, "Href", "http://192.168.0.1/#roustatus");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.StatusInfo, Status_Screenshot1, Status_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData4Info, "InnerText", "Refresh data");
            Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocumentIE.Button7Info, "Class", "wizard_back CMS");
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.Button7Info, "TagName", "input");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.Button7Info, "TagValue", "Back");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.Button7Info, "Value", "Back");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.Button7Info, Button7_Screenshot1, Button7_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, "InnerText", "Downstream");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, "Href", "http://192.168.0.1/#downstream");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, Downstream_Screenshot3, Downstream_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 20s.", new RecordItemIndex(19));
            Delay.Duration(20000, false);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(20));
            
            repo.WebDocument19216801.RouterStatusTabs.Downstream.Click("72;26");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshDataInfo, "InnerText", "Refresh data");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshDataInfo, "TagName", "span");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.RefreshDataInfo, RefreshData_Screenshot1, RefreshData_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, "InnerText", "Upstream");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, "TagName", "a");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, "Href", "http://192.168.0.1/#upstream");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, Upstream_Screenshot3, Upstream_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(29));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(30));
            //Delay.Duration(30000, false);
            
            repo.WebDocument19216801.RouterStatusTabs.Upstream.Click("71;35");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData1Info, "InnerText", "Refresh data");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData1Info, "TagName", "span");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.RefreshData1Info, RefreshData1_Screenshot1, RefreshData1_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "InnerText", "Configuration");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "TagName", "a");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "Href", "http://192.168.0.1/#configuration");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, Configuration_Screenshot2, Configuration_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData1Info, "InnerText", "Refresh data");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData1Info, "TagName", "span");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.RefreshData1Info, RefreshData1_Screenshot1_2, RefreshData1_Screenshot1_2_Options);
            //Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "InnerText", "Configuration");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "Href", "http://192.168.0.1/#configuration");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, Configuration_Screenshot2_2, Configuration_Screenshot2_2_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(45));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(46));
            //Delay.Duration(30000, false);
            
            repo.WebDocument19216801.RouterStatusTabs.Configuration.Click("73;30");
            Delay.Milliseconds(200);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData2Info, "InnerText", "Refresh data");
            Delay.Milliseconds(100);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData2Info, "TagName", "span");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.RefreshData2Info, RefreshData2_Screenshot1, RefreshData2_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo, "InnerText", "Network Log");
            //Delay.Milliseconds(100);
            
            //Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo, "Href", "http://192.168.0.1/#networklog");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo, NetworkLog_Screenshot3, NetworkLog_Screenshot3_Options);
            //Delay.Milliseconds(100);
            
            //repo.WebDocument19216801.RouterStatusTabs.NetworkLog.Click("58;23");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.RouterStatusTabs.NetworkLog1' at 51;24.", repo.WebDocument19216801.RouterStatusTabs.NetworkLog1Info, new RecordItemIndex(55));
            repo.WebDocument19216801.RouterStatusTabs.NetworkLog1.Click("51;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Network Log') on item 'WebDocument19216801.RouterStatusTabs.NetworkLog1'.", repo.WebDocument19216801.RouterStatusTabs.NetworkLog1Info, new RecordItemIndex(56));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.NetworkLog1Info, "InnerText", "Network Log");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='http://192.168.0.1/#networklog') on item 'WebDocument19216801.RouterStatusTabs.NetworkLog1'.", repo.WebDocument19216801.RouterStatusTabs.NetworkLog1Info, new RecordItemIndex(57));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.NetworkLog1Info, "Href", "http://192.168.0.1/#networklog");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.RouterStatusTabs.NetworkLog1'.", repo.WebDocument19216801.RouterStatusTabs.NetworkLog1Info, new RecordItemIndex(58));
            Validate.Exists(repo.WebDocument19216801.RouterStatusTabs.NetworkLog1Info);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(59));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(60));
            //Delay.Duration(30000, false);
            
            Validate.Attribute(repo.WebDocumentIE.RefreshData3Info, "InnerText", "Refresh data");
            Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.RefreshData3Info, RefreshData3_Screenshot1, RefreshData3_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(63));
            
            //Report.Log(ReportLevel.Info, "Delay", "Waiting for 30s.", new RecordItemIndex(64));
            //Delay.Duration(30000, false);
            
            //repo.WebDocumentIE.Status.Click("45;37");
            //Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocumentIE.RefreshData4Info, "InnerText", "Refresh data");
            //Delay.Milliseconds(100);
            
            //Validate.ContainsImage(repo.WebDocumentIE.RefreshData4Info, RefreshData4_Screenshot1, RefreshData4_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
        }

#region Image Feature Data
        CompressedImage CheckRouterStatus_Screenshot1
        { get { return repo.WebDocumentIE.CheckRouterStatusInfo.GetScreenshot1(new Rectangle(0, 0, 162, 22)); } }

        Imaging.FindOptions CheckRouterStatus_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RouterStatus_Screenshot1
        { get { return repo.WebDocumentIE.RouterStatusInfo.GetScreenshot1(new Rectangle(0, 0, 862, 106)); } }

        Imaging.FindOptions RouterStatus_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Status_Screenshot1
        { get { return repo.WebDocumentIE.StatusInfo.GetScreenshot1(new Rectangle(0, 0, 95, 61)); } }

        Imaging.FindOptions Status_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Button7_Screenshot1
        { get { return repo.WebDocumentIE.Button7Info.GetScreenshot1(new Rectangle(0, 0, 177, 75)); } }

        Imaging.FindOptions Button7_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Downstream_Screenshot3
        { get { return repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo.GetScreenshot3(new Rectangle(0, 0, 142, 58)); } }

        Imaging.FindOptions Downstream_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RefreshData_Screenshot1
        { get { return repo.WebDocumentIE.RefreshDataInfo.GetScreenshot1(new Rectangle(0, 0, 105, 22)); } }

        Imaging.FindOptions RefreshData_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Upstream_Screenshot3
        { get { return repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo.GetScreenshot3(new Rectangle(0, 0, 120, 58)); } }

        Imaging.FindOptions Upstream_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RefreshData1_Screenshot1
        { get { return repo.WebDocumentIE.RefreshData1Info.GetScreenshot1(new Rectangle(0, 0, 105, 22)); } }

        Imaging.FindOptions RefreshData1_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Configuration_Screenshot2
        { get { return repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo.GetScreenshot2(new Rectangle(0, 0, 148, 58)); } }

        Imaging.FindOptions Configuration_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RefreshData1_Screenshot1_2
        { get { return repo.WebDocumentIE.RefreshData1Info.GetScreenshot1(new Rectangle(0, 0, 105, 22)); } }

        Imaging.FindOptions RefreshData1_Screenshot1_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Configuration_Screenshot2_2
        { get { return repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo.GetScreenshot2(new Rectangle(0, 0, 148, 58)); } }

        Imaging.FindOptions Configuration_Screenshot2_2_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RefreshData2_Screenshot1
        { get { return repo.WebDocumentIE.RefreshData2Info.GetScreenshot1(new Rectangle(0, 0, 105, 22)); } }

        Imaging.FindOptions RefreshData2_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage NetworkLog_Screenshot3
        { get { return repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo.GetScreenshot3(new Rectangle(0, 0, 135, 58)); } }

        Imaging.FindOptions NetworkLog_Screenshot3_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RefreshData3_Screenshot1
        { get { return repo.WebDocumentIE.RefreshData3Info.GetScreenshot1(new Rectangle(0, 0, 105, 22)); } }

        Imaging.FindOptions RefreshData3_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage RefreshData4_Screenshot1
        { get { return repo.WebDocumentIE.RefreshData4Info.GetScreenshot1(new Rectangle(0, 0, 105, 22)); } }

        Imaging.FindOptions RefreshData4_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
