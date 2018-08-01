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
    ///The Apply_Mac_Filter_Changes_Recording recording.
    /// </summary>
    [TestModule("a521a04a-0912-4afd-8802-781aa71ee25f", ModuleType.Recording, 1)]
    public partial class Apply_Mac_Filter_Changes_Recording : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Apply_Mac_Filter_Changes_Recording instance = new Apply_Mac_Filter_Changes_Recording();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Apply_Mac_Filter_Changes_Recording()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Apply_Mac_Filter_Changes_Recording Instance
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.Http19216801InternetExplorer' at 23;9.", repo.Explorer.Http19216801InternetExplorerInfo, new RecordItemIndex(0));
            repo.Explorer.Http19216801InternetExplorer.Click("23;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.AdvancedSettings' at 64;14.", repo.WebDocument19216801.AdvancedSettingsInfo, new RecordItemIndex(1));
            repo.WebDocument19216801.AdvancedSettings.Click("64;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Wireless' at 35;11.", repo.WebDocument19216801.WirelessInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.Wireless.Click("35;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Security' at 39;10.", repo.WebDocument19216801.SecurityInfo, new RecordItemIndex(3));
            repo.WebDocument19216801.Security.Click("39;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -2160 units.", new RecordItemIndex(4));
            Mouse.ScrollWheel(-2160);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxMacAddressFilterTableDelete0' at 19;18.", repo.WebDocument19216801.FmChbxMacAddressFilterTableDelete0Info, new RecordItemIndex(5));
            repo.WebDocument19216801.FmChbxMacAddressFilterTableDelete0.Click("19;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxMacAddressFilterTableDelete1' at 14;17.", repo.WebDocument19216801.FmChbxMacAddressFilterTableDelete1Info, new RecordItemIndex(6));
            repo.WebDocument19216801.FmChbxMacAddressFilterTableDelete1.Click("14;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='macAddressFilterTable') on item 'WebDocument19216801.MacAddressFilterTable'.", repo.WebDocument19216801.MacAddressFilterTableInfo, new RecordItemIndex(7));
            Validate.Attribute(repo.WebDocument19216801.MacAddressFilterTableInfo, "Id", "macAddressFilterTable");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='table') on item 'WebDocument19216801.MacAddressFilterTable'.", repo.WebDocument19216801.MacAddressFilterTableInfo, new RecordItemIndex(8));
            Validate.Attribute(repo.WebDocument19216801.MacAddressFilterTableInfo, "TagName", "table");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagName='input') on item 'WebDocument19216801.Button13'.", repo.WebDocument19216801.Button13Info, new RecordItemIndex(9));
            Validate.Attribute(repo.WebDocument19216801.Button13Info, "TagName", "input");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (TagValue='Apply changes') on item 'WebDocument19216801.Button13'.", repo.WebDocument19216801.Button13Info, new RecordItemIndex(10));
            Validate.Attribute(repo.WebDocument19216801.Button13Info, "TagValue", "Apply changes");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Tabindex='37') on item 'WebDocument19216801.Button13'.", repo.WebDocument19216801.Button13Info, new RecordItemIndex(11));
            Validate.Attribute(repo.WebDocument19216801.Button13Info, "Tabindex", "37");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Value='Apply changes') on item 'WebDocument19216801.Button13'.", repo.WebDocument19216801.Button13Info, new RecordItemIndex(12));
            Validate.Attribute(repo.WebDocument19216801.Button13Info, "Value", "Apply changes");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button13' at 53;32.", repo.WebDocument19216801.Button13Info, new RecordItemIndex(13));
            repo.WebDocument19216801.Button13.Click("53;32");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Down item 'WebDocument19216801.WebDocument19216801' at 1909;733.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(14));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1909;733");
            Mouse.ButtonDown(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Move item 'WebDocument19216801.WebDocument19216801' at 1917;725.", repo.WebDocument19216801.WebDocument19216801Info, new RecordItemIndex(15));
            repo.WebDocument19216801.WebDocument19216801.MoveTo("1917;725");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Up item 'WebDocument19216801.Fm0' at 1888;90.", repo.WebDocument19216801.Fm0Info, new RecordItemIndex(16));
            repo.WebDocument19216801.Fm0.MoveTo("1888;90");
            Mouse.ButtonUp(System.Windows.Forms.MouseButtons.Left);
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.LogOut' at 42;12.", repo.WebDocument19216801.LogOutInfo, new RecordItemIndex(17));
            repo.WebDocument19216801.LogOut.Click("42;12");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.WarningWizard.Button12' at 171;52.", repo.WebDocument19216801.WarningWizard.Button12Info, new RecordItemIndex(18));
            repo.WebDocument19216801.WarningWizard.Button12.Click("171;52");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -1440 units.", new RecordItemIndex(19));
            Mouse.ScrollWheel(-1440);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.FmChbxMacAddressFilterTableDelete0' at 12;18.", repo.WebDocument19216801.FmChbxMacAddressFilterTableDelete0Info, new RecordItemIndex(20));
            repo.WebDocument19216801.FmChbxMacAddressFilterTableDelete0.Click("12;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by -2400 units.", new RecordItemIndex(21));
            Mouse.ScrollWheel(-2400);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.Button25' at 101;17.", repo.WebDocument19216801.Button25Info, new RecordItemIndex(22));
            repo.WebDocument19216801.Button25.Click("101;17");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Scroll Vertical by 1200 units.", new RecordItemIndex(23));
            Mouse.ScrollWheel(1200);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='confirm-wizard-text') on item 'WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdated'.", repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, new RecordItemIndex(24));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, "Class", "confirm-wizard-text");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Your settings have been updated.') on item 'WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdated'.", repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, new RecordItemIndex(25));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.YourSettingsHaveBeenUpdatedInfo, "InnerText", "Your settings have been updated.");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Visible='True') on item 'WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvg'.", repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, new RecordItemIndex(26));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, "Visible", "True");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Src='http://192.168.0.1/i/allgood-icon.svg') on item 'WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvg'.", repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, new RecordItemIndex(27));
            Validate.Attribute(repo.WebDocumentIE.ConfirmWizard1.Http19216801IAllgoodIconSvgInfo, "Src", "http://192.168.0.1/i/allgood-icon.svg");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
