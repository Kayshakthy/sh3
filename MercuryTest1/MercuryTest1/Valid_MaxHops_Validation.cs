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
    ///The Valid_MaxHops_Validation recording.
    /// </summary>
    [TestModule("b98ee739-6df3-45b8-adb4-a2dc767a89f3", ModuleType.Recording, 1)]
    public partial class Valid_MaxHops_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Valid_MaxHops_Validation instance = new Valid_MaxHops_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Valid_MaxHops_Validation()
        {
            Max_hops = "10";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Valid_MaxHops_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _Max_hops;

        /// <summary>
        /// Gets or sets the value of variable Max_hops.
        /// </summary>
        [TestVariable("cc73ecc2-d1bd-4727-ab82-f7758b2c6284")]
        public string Max_hops
        {
            get { return _Max_hops; }
            set { _Max_hops = value; }
        }

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

            repo.WebDocument19216801.Target.Click("23;17");
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Target);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Target);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Target.PressKeys("www.bbc.co.uk");
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Baseport.Click("23;17");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Baseport);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Baseport);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '65535' with focus on 'WebDocument19216801.Baseport'.", repo.WebDocument19216801.BaseportInfo, new RecordItemIndex(7));
            repo.WebDocument19216801.Baseport.PressKeys("65535");
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Maxhops.Click("23;17");
            Delay.Milliseconds(200);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Maxhops);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Keyboard.PrepareFocus(repo.WebDocument19216801.Maxhops);
            Keyboard.Press(System.Windows.Forms.Keys.Delete, Keyboard.DefaultScanCode, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Maxhops.PressKeys(Max_hops);
            Delay.Milliseconds(0);
            
            repo.WebDocument19216801.Start.Click("57;17");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(13));
            Delay.Duration(5000, false);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocumentIE.ErrCloseMaxhops'.", repo.WebDocumentIE.ErrCloseMaxhopsInfo, new RecordItemIndex(14));
            //Validate.Attribute(repo.WebDocumentIE.ErrCloseMaxhopsInfo, "Class", "errTipClose");
            //Delay.Milliseconds(100);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='errClose-Maxhops') on item 'WebDocumentIE.ErrCloseMaxhops'.", repo.WebDocumentIE.ErrCloseMaxhopsInfo, new RecordItemIndex(15));
            //Validate.Attribute(repo.WebDocumentIE.ErrCloseMaxhopsInfo, "Id", "errClose-Maxhops");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating NotExists on item 'WebDocumentIE.ErrCloseMaxhops'.", repo.WebDocumentIE.ErrCloseMaxhopsInfo, new RecordItemIndex(16));
            Validate.NotExists(repo.WebDocumentIE.ErrCloseMaxhopsInfo);
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(17));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
