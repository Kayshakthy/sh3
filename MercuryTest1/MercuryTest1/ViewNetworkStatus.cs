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
    ///The ViewNetworkStatus recording.
    /// </summary>
    [TestModule("8111f3e7-6357-4f5b-ae53-7591abff2055", ModuleType.Recording, 1)]
    public partial class ViewNetworkStatus : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static ViewNetworkStatus instance = new ViewNetworkStatus();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public ViewNetworkStatus()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static ViewNetworkStatus Instance
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.AdvancedSettings1'.", repo.WebDocument19216801.AdvancedSettings1Info, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocument19216801.AdvancedSettings1Info, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='AdvancedSettings') on item 'WebDocument19216801.AdvancedSettings1'.", repo.WebDocument19216801.AdvancedSettings1Info, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.AdvancedSettings1Info, "Id", "AdvancedSettings");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.AdvancedSettings1'.", repo.WebDocument19216801.AdvancedSettings1Info, new RecordItemIndex(2));
            Validate.Exists(repo.WebDocument19216801.AdvancedSettings1Info);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Advanced settings') on item 'WebDocument19216801.AdvancedSettings'.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(3));
            Validate.Attribute(repo.WebDocument19216801.AdvancedSettingsInfo, "InnerText", "Advanced settings");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 71;8.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(4));
            repo.WebDocument19216801.AdvancedSettings.Click("71;8");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 61;9.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(5));
            //repo.WebDocument19216801.AdvancedSettings.Click("61;9");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -480 units.", new RecordItemIndex(6));
            //Mouse.ScrollWheel(-480);
            //Delay.Milliseconds(500);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Tools' at 24;10.", repo.WebDocument19216801.ToolsInfo, new RecordItemIndex(7));
            //repo.WebDocument19216801.Tools.Click("24;10");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.Tools'.", repo.WebDocument19216801.ToolsInfo, new RecordItemIndex(8));
            //Validate.Attribute(repo.WebDocument19216801.ToolsInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Tools' at 17;9.", repo.WebDocument19216801.ToolsInfo, new RecordItemIndex(9));
            repo.WebDocument19216801.Tools.Click("17;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Tools') on item 'WebDocument19216801.Tools'.", repo.WebDocument19216801.ToolsInfo, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.ToolsInfo, "InnerText", "Tools");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.Tools'.", repo.WebDocument19216801.ToolsInfo, new RecordItemIndex(11));
            Validate.Exists(repo.WebDocument19216801.ToolsInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.NetworkStatus1'.", repo.WebDocument19216801.NetworkStatus1Info, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocument19216801.NetworkStatus1Info, "Enabled", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='NetworkStatus') on item 'WebDocument19216801.NetworkStatus1'.", repo.WebDocument19216801.NetworkStatus1Info, new RecordItemIndex(13));
            Validate.Attribute(repo.WebDocument19216801.NetworkStatus1Info, "Id", "NetworkStatus");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.NetworkStatus'.", repo.WebDocument19216801.NetworkStatusInfo, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocument19216801.NetworkStatusInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='http://192.168.0.1/?device_networkstatus&mid=NetworkStatus') on item 'WebDocument19216801.NetworkStatus'.", repo.WebDocument19216801.NetworkStatusInfo, new RecordItemIndex(15));
            //Validate.Attribute(repo.WebDocument19216801.NetworkStatusInfo, "Href", "http://192.168.0.1/?device_networkstatus&mid=NetworkStatus");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.NetworkStatus' at 42;5.", repo.WebDocument19216801.NetworkStatusInfo, new RecordItemIndex(16));
            repo.WebDocument19216801.NetworkStatus.Click("42;5");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.NetworkStatus' at 22;3.", repo.WebDocument19216801.NetworkStatusInfo, new RecordItemIndex(17));
            repo.WebDocument19216801.NetworkStatus.Click("22;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1357;208.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(18));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1357;208");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1364;266.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(19));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1364;266");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1355;391.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(20));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1355;391");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1355;366.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(21));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1355;366");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_NetworkStatus') on item 'WebDocument19216801.LabelNetworkStatus'.", repo.WebDocument19216801.LabelNetworkStatusInfo, new RecordItemIndex(22));
            Validate.Attribute(repo.WebDocument19216801.LabelNetworkStatusInfo, "Id", "label_NetworkStatus");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Network status') on item 'WebDocument19216801.LabelNetworkStatus'.", repo.WebDocument19216801.LabelNetworkStatusInfo, new RecordItemIndex(23));
            Validate.Attribute(repo.WebDocument19216801.LabelNetworkStatusInfo, "InnerText", "Network status");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=728,Height=65}) on item 'WebDocument19216801.LabelNetworkStatus'.", repo.WebDocument19216801.LabelNetworkStatusInfo, new RecordItemIndex(24));
            //Validate.ContainsImage(repo.WebDocument19216801.LabelNetworkStatusInfo, LabelNetworkStatus_Screenshot1, LabelNetworkStatus_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1359;323.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(25));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1359;323");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1365;390.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(26));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1365;390");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.RouterStatusTabs.Downstream'.", repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Downstream') on item 'WebDocument19216801.RouterStatusTabs.Downstream'.", repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, new RecordItemIndex(28));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, "InnerText", "Downstream");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot2' with region {X=0,Y=0,Width=133,Height=48}) on item 'WebDocument19216801.RouterStatusTabs.Downstream'.", repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, new RecordItemIndex(29));
            //Validate.ContainsImage(repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, Downstream_Screenshot2, Downstream_Screenshot2_Options);
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.RouterStatusTabs.Downstream' at 66;19.", repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo, new RecordItemIndex(30));
            repo.WebDocument19216801.RouterStatusTabs.Downstream.Click("66;19");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1356;138.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(31));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1356;138");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1365;95.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(32));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1365;95");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.RouterStatusTabs.Upstream'.", repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, new RecordItemIndex(33));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Upstream') on item 'WebDocument19216801.RouterStatusTabs.Upstream'.", repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, new RecordItemIndex(34));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, "InnerText", "Upstream");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.RouterStatusTabs.Upstream'.", repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, new RecordItemIndex(35));
            Validate.Exists(repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.RouterStatusTabs.Upstream' at 56;24.", repo.WebDocument19216801.RouterStatusTabs.UpstreamInfo, new RecordItemIndex(36));
            repo.WebDocument19216801.RouterStatusTabs.Upstream.Click("56;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.RouterStatusTabs.Configuration'.", repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, new RecordItemIndex(37));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Configuration') on item 'WebDocument19216801.RouterStatusTabs.Configuration'.", repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, new RecordItemIndex(38));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "InnerText", "Configuration");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Href='http://192.168.0.1/?device_networkstatus&mid=NetworkStatus#configuration') on item 'WebDocument19216801.RouterStatusTabs.Configuration'.", repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, new RecordItemIndex(39));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, "Href", "http://192.168.0.1/?device_networkstatus&mid=NetworkStatus#configuration");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.RouterStatusTabs.Configuration' at 63;26.", repo.WebDocument19216801.RouterStatusTabs.ConfigurationInfo, new RecordItemIndex(40));
            repo.WebDocument19216801.RouterStatusTabs.Configuration.Click("63;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1356;172.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(41));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1356;172");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1353;324.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(42));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1353;324");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.TableContainerLengthdata1' at 678;162.", repo.WebDocument19216801.TableContainerLengthdata1Info, new RecordItemIndex(43));
            repo.WebDocument19216801.TableContainerLengthdata1.MoveTo("678;162");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.TableContainerLengthdata1' at 676;333.", repo.WebDocument19216801.TableContainerLengthdata1Info, new RecordItemIndex(44));
            repo.WebDocument19216801.TableContainerLengthdata1.MoveTo("676;333");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.TableContainerLengthdata1' at 676;344.", repo.WebDocument19216801.TableContainerLengthdata1Info, new RecordItemIndex(45));
            repo.WebDocument19216801.TableContainerLengthdata1.MoveTo("676;344");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.TableContainerLengthdata1' at 674;159.", repo.WebDocument19216801.TableContainerLengthdata1Info, new RecordItemIndex(46));
            repo.WebDocument19216801.TableContainerLengthdata1.MoveTo("674;159");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1355;446.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(47));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1355;446");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1341;282.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(48));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1341;282");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Network log') on item 'WebDocument19216801.RouterStatusTabs.NetworkLog'.", repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo, new RecordItemIndex(49));
            Validate.Attribute(repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo, "InnerText", "Network log");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WebDocument19216801.RouterStatusTabs.NetworkLog'.", repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo, new RecordItemIndex(50));
            Validate.Exists(repo.WebDocument19216801.RouterStatusTabs.NetworkLogInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.RouterStatusDiv' at 552;25.", repo.WebDocument19216801.RouterStatusDivInfo, new RecordItemIndex(51));
            repo.WebDocument19216801.RouterStatusDiv.Click("552;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1356;95.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(52));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1356;95");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1345;275.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(53));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1345;275");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.TableContainerLengthdata' at 676;76.", repo.WebDocument19216801.TableContainerLengthdataInfo, new RecordItemIndex(54));
            repo.WebDocument19216801.TableContainerLengthdata.MoveTo("676;76");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.TableContainerLengthdata' at 675;393.", repo.WebDocument19216801.TableContainerLengthdataInfo, new RecordItemIndex(55));
            repo.WebDocument19216801.TableContainerLengthdata.MoveTo("675;393");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1359;455.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(56));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1359;455");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.WebDocument19216801' at 1350;226.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(57));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1350;226");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
        CompressedImage LabelNetworkStatus_Screenshot1
        { get { return repo.WebDocument19216801.LabelNetworkStatusInfo.GetScreenshot1(new Rectangle(0, 0, 728, 65)); } }

        Imaging.FindOptions LabelNetworkStatus_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

        CompressedImage Downstream_Screenshot2
        { get { return repo.WebDocument19216801.RouterStatusTabs.DownstreamInfo.GetScreenshot2(new Rectangle(0, 0, 133, 48)); } }

        Imaging.FindOptions Downstream_Screenshot2_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
