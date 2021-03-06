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
    ///The Inavlid_Private_IP_Ranges_and_Reserved_Addresses_Validation recording.
    /// </summary>
    [TestModule("a7ccfd63-cf08-4f84-863a-29759e844c4c", ModuleType.Recording, 1)]
    public partial class Inavlid_Private_IP_Ranges_and_Reserved_Addresses_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Inavlid_Private_IP_Ranges_and_Reserved_Addresses_Validation instance = new Inavlid_Private_IP_Ranges_and_Reserved_Addresses_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Inavlid_Private_IP_Ranges_and_Reserved_Addresses_Validation()
        {
            IPv4_Source_Single3 = "1";
            IPv4_Source_Single2 = "2";
            No_of_CPE = "1";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Inavlid_Private_IP_Ranges_and_Reserved_Addresses_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _IPv4_Source_Single3;

        /// <summary>
        /// Gets or sets the value of variable IPv4_Source_Single3.
        /// </summary>
        [TestVariable("17eb8d28-a35b-4cce-9163-07a7413bcdc4")]
        public string IPv4_Source_Single3
        {
            get { return _IPv4_Source_Single3; }
            set { _IPv4_Source_Single3 = value; }
        }

        string _IPv4_Source_Single2;

        /// <summary>
        /// Gets or sets the value of variable IPv4_Source_Single2.
        /// </summary>
        [TestVariable("3882fbaf-82f9-4f51-b7c0-a1bd7a141f08")]
        public string IPv4_Source_Single2
        {
            get { return _IPv4_Source_Single2; }
            set { _IPv4_Source_Single2 = value; }
        }

        string _No_of_CPE;

        /// <summary>
        /// Gets or sets the value of variable No_of_CPE.
        /// </summary>
        [TestVariable("be5dc990-f21a-43db-b745-5b942d41b557")]
        public string No_of_CPE
        {
            get { return _No_of_CPE; }
            set { _No_of_CPE = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocumentIE.StartIPAddress2' at 24;10.", repo.WebDocumentIE.StartIPAddress2Info, new RecordItemIndex(0));
            repo.WebDocumentIE.StartIPAddress2.Click("24;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocumentIE.StartIPAddress2'.", repo.WebDocumentIE.StartIPAddress2Info, new RecordItemIndex(1));
            Keyboard.PrepareFocus(repo.WebDocumentIE.StartIPAddress2);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.MaxUsers'.", repo.WebDocument19216801.MaxUsersInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.MaxUsers.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IPv4_Source_Single2' with focus on 'WebDocumentIE.StartIPAddress2'.", repo.WebDocumentIE.StartIPAddress2Info, new RecordItemIndex(3));
            repo.WebDocumentIE.StartIPAddress2.PressKeys(IPv4_Source_Single2);
            Delay.Milliseconds(0);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='seconds') on item 'WebDocument19216801.Seconds'.", repo.WebDocument19216801.SecondsInfo, new RecordItemIndex(4));
            //Validate.Attribute(repo.WebDocument19216801.SecondsInfo, "InnerText", "seconds");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.StartIPAddress3' at 29;10.", repo.WebDocument19216801.StartIPAddress3Info, new RecordItemIndex(5));
            repo.WebDocument19216801.StartIPAddress3.Click("29;10");
            Delay.Milliseconds(3300);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.StartIPAddress3'.", repo.WebDocument19216801.StartIPAddress3Info, new RecordItemIndex(6));
            Keyboard.PrepareFocus(repo.WebDocument19216801.StartIPAddress3);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.StartIPAddress3'.", repo.WebDocument19216801.StartIPAddress3Info, new RecordItemIndex(7));
            repo.WebDocument19216801.StartIPAddress3.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$IPv4_Source_Single3' with focus on 'WebDocument19216801.StartIPAddress3'.", repo.WebDocument19216801.StartIPAddress3Info, new RecordItemIndex(8));
            repo.WebDocument19216801.StartIPAddress3.PressKeys(IPv4_Source_Single3);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.MaxUsers' at 44;8.", repo.WebDocument19216801.MaxUsersInfo, new RecordItemIndex(9));
            repo.WebDocument19216801.MaxUsers.Click("44;8");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'WebDocument19216801.MaxUsers'.", repo.WebDocument19216801.MaxUsersInfo, new RecordItemIndex(10));
            Keyboard.PrepareFocus(repo.WebDocument19216801.MaxUsers);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, 30, Keyboard.DefaultKeyPressTime, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Delete}' with focus on 'WebDocument19216801.MaxUsers'.", repo.WebDocument19216801.MaxUsersInfo, new RecordItemIndex(11));
            repo.WebDocument19216801.MaxUsers.PressKeys("{Delete}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$No_of_CPE' with focus on 'WebDocument19216801.MaxUsers'.", repo.WebDocument19216801.MaxUsersInfo, new RecordItemIndex(12));
            repo.WebDocument19216801.MaxUsers.PressKeys(No_of_CPE);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.DHCPv4' at 84;25.", repo.WebDocument19216801.DHCPv4Info, new RecordItemIndex(13));
            repo.WebDocument19216801.DHCPv4.Click("84;25");
            Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.DHCPv4' at 69;17.", repo.WebDocument19216801.DHCPv4Info, new RecordItemIndex(14));
            //repo.WebDocument19216801.DHCPv4.Click("69;17");
            //Delay.Milliseconds(200);
            
            //Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='IP address is invalid.') on item 'WebDocument19216801.IPAddressIsInvalid'.", repo.WebDocument19216801.IPAddressIsInvalidInfo, new RecordItemIndex(15));
            //Validate.Attribute(repo.WebDocument19216801.IPAddressIsInvalidInfo, "InnerText", "IP address is invalid.");
            //Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Class='errTipClose') on item 'WebDocument19216801.ErrCloseStartIPAddress'.", repo.WebDocument19216801.ErrCloseStartIPAddressInfo, new RecordItemIndex(16));
            Validate.Attribute(repo.WebDocument19216801.ErrCloseStartIPAddressInfo, "Class", "errTipClose");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Sorry! There was an error while updating your settings. Please try again a bit later.') on item 'WebDocumentIE.SorryThereWasAnErrorWhileUpdating'.", repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdatingInfo, new RecordItemIndex(17));
            Validate.Attribute(repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdatingInfo, "InnerText", "Sorry! There was an error while updating your settings. Please try again a bit later.");
            Delay.Milliseconds(100);
            
            Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(18));
            
            //Report.Screenshot(ReportLevel.Info, "User", "", null, false, new RecordItemIndex(19));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
