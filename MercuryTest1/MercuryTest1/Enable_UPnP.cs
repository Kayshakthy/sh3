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
    ///The Enable_UPnP recording.
    /// </summary>
    [TestModule("9b9a0323-05c4-45db-9d02-ccb73ea8d99a", ModuleType.Recording, 1)]
    public partial class Enable_UPnP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Enable_UPnP instance = new Enable_UPnP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enable_UPnP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Enable_UPnP Instance
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

            repo.WebDocument19216801.FmRbtnEnableUPnP.Click("15;18");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Enabled='True') on item 'WebDocument19216801.TrEnableUPnP'.", repo.WebDocument19216801.TrEnableUPnPInfo, new RecordItemIndex(1));
            //Validate.Attribute(repo.WebDocument19216801.TrEnableUPnPInfo, "Enabled", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (HasFocus='True') on item 'WebDocument19216801.TrEnableUPnP'.", repo.WebDocument19216801.TrEnableUPnPInfo, new RecordItemIndex(2));
            //Validate.Attribute(repo.WebDocument19216801.TrEnableUPnPInfo, "HasFocus", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocument19216801.TrEnableUPnP'.", repo.WebDocument19216801.TrEnableUPnPInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.TrEnableUPnPInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='div_radiobox_without_tt') on item 'WebDocument19216801.TrEnableUPnP'.", repo.WebDocument19216801.TrEnableUPnPInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.TrEnableUPnPInfo, "Class", "div_radiobox_without_tt");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='tr_EnableUPnP') on item 'WebDocument19216801.TrEnableUPnP'.", repo.WebDocument19216801.TrEnableUPnPInfo, new RecordItemIndex(5));
            //Validate.Attribute(repo.WebDocument19216801.TrEnableUPnPInfo, "Id", "tr_EnableUPnP");
            //Delay.Milliseconds(100);
            
            //Report.Snapshot(ReportLevel.Info, "User", "UPnP", repo.WebDocument19216801.TrEnableUPnP, new RecordItemIndex(6));
            
            Report.Screenshot(ReportLevel.Info, "User", "Enable UPnP", repo.WebDocument19216801.TrEnableUPnP, false, new RecordItemIndex(7));
            
            Validate_TrEnableUPnP();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
        CompressedImage TrEnableUPnP_Screenshot1
        { get { return repo.WebDocument19216801.TrEnableUPnPInfo.GetScreenshot1(new Rectangle(0, 0, 219, 26)); } }

        Imaging.FindOptions TrEnableUPnP_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
