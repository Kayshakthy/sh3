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
    ///The Disable_UPnP recording.
    /// </summary>
    [TestModule("0a4c039b-1f4b-4641-b4a8-65b8013d76b3", ModuleType.Recording, 1)]
    public partial class Disable_UPnP : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Disable_UPnP instance = new Disable_UPnP();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Disable_UPnP()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Disable_UPnP Instance
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

            repo.WebDocument19216801.TrDisableUPnP.Click("15;15");
            Delay.Milliseconds(200);
            
            //Validate.Attribute(repo.WebDocument19216801.TrDisableUPnPInfo, "Enabled", "True");
            //Delay.Milliseconds(0);
            
            //Validate.Attribute(repo.WebDocument19216801.TrDisableUPnPInfo, "Visible", "True");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='tr_DisableUPnP') on item 'WebDocument19216801.TrDisableUPnP'.", repo.WebDocument19216801.TrDisableUPnPInfo, new RecordItemIndex(3));
            //Validate.Attribute(repo.WebDocument19216801.TrDisableUPnPInfo, "Id", "tr_DisableUPnP");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating ContainsImage (Screenshot: 'Screenshot1' with region {X=0,Y=0,Width=218,Height=26}) on item 'WebDocument19216801.TrDisableUPnP'.", repo.WebDocument19216801.TrDisableUPnPInfo, new RecordItemIndex(4));
            //Validate.ContainsImage(repo.WebDocument19216801.TrDisableUPnPInfo, TrDisableUPnP_Screenshot1, TrDisableUPnP_Screenshot1_Options);
            //Delay.Milliseconds(100);
            
            //Report.Snapshot(ReportLevel.Info, "User", "UPnP", repo.WebDocument19216801.TrDisableUPnP, new RecordItemIndex(5));
            
            Report.Screenshot(ReportLevel.Info, "User", "Disable UPnP", repo.WebDocument19216801.TrDisableUPnP, false, new RecordItemIndex(6));
            
        }

#region Image Feature Data
        CompressedImage TrDisableUPnP_Screenshot1
        { get { return repo.WebDocument19216801.TrDisableUPnPInfo.GetScreenshot1(new Rectangle(0, 0, 218, 26)); } }

        Imaging.FindOptions TrDisableUPnP_Screenshot1_Options
        { get { return Imaging.FindOptions.Default; } }

#endregion
    }
#pragma warning restore 0436
}
