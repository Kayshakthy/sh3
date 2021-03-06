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
    ///The Confirm_MM_Disable recording.
    /// </summary>
    [TestModule("71245357-1caa-432d-8906-487c3f8bec01", ModuleType.Recording, 1)]
    public partial class Confirm_MM_Disable : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Confirm_MM_Disable instance = new Confirm_MM_Disable();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Confirm_MM_Disable()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Confirm_MM_Disable Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.FmRbtnRouterMode' at 16;23.", repo.WebDocument1921681001.FmRbtnRouterModeInfo, new RecordItemIndex(0));
            repo.WebDocument1921681001.FmRbtnRouterMode.Click("16;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.ApplyButton' at 95;20.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(1));
            repo.WebDocument1921681001.ApplyButton.Click("95;20");
            Delay.Milliseconds(200);
            
            // Confirm the changes
            //Report.Log(ReportLevel.Info, "Mouse", "Confirm the changes\r\nMouse Left Click item 'WebDocument1921681001.Button1' at 136;63.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(2));
            //repo.WebDocument1921681001.Button1.Click("136;63");
            //Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Just to make sure') on item 'WebDocument1921681001.JustToMakeSure'.", repo.WebDocument1921681001.JustToMakeSureInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument1921681001.JustToMakeSureInfo, "InnerText", "Just to make sure");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Device will reboot after applying the changes.Continue?') on item 'WebDocument1921681001.DeviceWillRebootAfterApplyingTheCh'.", repo.WebDocument1921681001.DeviceWillRebootAfterApplyingTheChInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument1921681001.DeviceWillRebootAfterApplyingTheChInfo, "InnerText", "Device will reboot after applying the changes.Continue?");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.Button1' at 121;29.", repo.WebDocument1921681001.Button1Info, new RecordItemIndex(5));
            //repo.WebDocument1921681001.Button1.Click("121;29");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.FmRbtnRouterMode' at 15;16.", repo.WebDocument1921681001.FmRbtnRouterModeInfo, new RecordItemIndex(6));
            //repo.WebDocument1921681001.FmRbtnRouterMode.Click("15;16");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.ApplyButton' at 87;20.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(7));
            //repo.WebDocument1921681001.ApplyButton.Click("87;20");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='overlaycontent-title') on item 'WebDocument1921681001.RebootWizard1Frame0.JustToMakeSure1'.", repo.WebDocument1921681001.RebootWizard1Frame0.JustToMakeSure1Info, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument1921681001.RebootWizard1Frame0.JustToMakeSure1Info, "Class", "overlaycontent-title");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Just to make sure') on item 'WebDocument1921681001.RebootWizard1Frame0.JustToMakeSure1'.", repo.WebDocument1921681001.RebootWizard1Frame0.JustToMakeSure1Info, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument1921681001.RebootWizard1Frame0.JustToMakeSure1Info, "InnerText", "Just to make sure");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Device will reboot after applying the changes.Continue?') on item 'WebDocument1921681001.RebootWizard1Frame0.DeviceWillRebootAfterApplyingTheCh1'.", repo.WebDocument1921681001.RebootWizard1Frame0.DeviceWillRebootAfterApplyingTheCh1Info, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument1921681001.RebootWizard1Frame0.DeviceWillRebootAfterApplyingTheCh1Info, "InnerText", "Device will reboot after applying the changes.Continue?");
            Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.RebootWizard1Frame0.Button3' at 130;28.", repo.WebDocument1921681001.RebootWizard1Frame0.Button3Info, new RecordItemIndex(11));
            //repo.WebDocument1921681001.RebootWizard1Frame0.Button3.Click("130;28");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.ApplyButton' at 89;23.", repo.WebDocument1921681001.ApplyButtonInfo, new RecordItemIndex(12));
            //repo.WebDocument1921681001.ApplyButton.Click("89;23");
            //Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument1921681001.RebootWizard1Frame0.Button4' at 136;35.", repo.WebDocument1921681001.RebootWizard1Frame0.Button4Info, new RecordItemIndex(13));
            repo.WebDocument1921681001.RebootWizard1Frame0.Button4.Click("136;35");
            Delay.Milliseconds(200);
            
            Delay.Duration(1000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
