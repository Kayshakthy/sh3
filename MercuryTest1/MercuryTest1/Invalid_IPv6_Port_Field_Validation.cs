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
    ///The Invalid_IPv6_Port_Field_Validation recording.
    /// </summary>
    [TestModule("2cc65d29-8c39-4796-be1d-9dcc93d077e3", ModuleType.Recording, 1)]
    public partial class Invalid_IPv6_Port_Field_Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the MercuryTest1Repository repository.
        /// </summary>
        public static MercuryTest1Repository repo = MercuryTest1Repository.Instance;

        static Invalid_IPv6_Port_Field_Validation instance = new Invalid_IPv6_Port_Field_Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Invalid_IPv6_Port_Field_Validation()
        {
            protocolType = "";
            sourceIP = "";
            destinationIP = "";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Invalid_IPv6_Port_Field_Validation Instance
        {
            get { return instance; }
        }

#region Variables

        string _protocolType;

        /// <summary>
        /// Gets or sets the value of variable protocolType.
        /// </summary>
        [TestVariable("c0b9fa82-408d-44ea-9005-48423bbc6a91")]
        public string protocolType
        {
            get { return _protocolType; }
            set { _protocolType = value; }
        }

        string _sourceIP;

        /// <summary>
        /// Gets or sets the value of variable sourceIP.
        /// </summary>
        [TestVariable("57449db7-9261-4487-be84-5848ae2a46ee")]
        public string sourceIP
        {
            get { return _sourceIP; }
            set { _sourceIP = value; }
        }

        string _destinationIP;

        /// <summary>
        /// Gets or sets the value of variable destinationIP.
        /// </summary>
        [TestVariable("1e58adbe-ca45-4c66-8fdc-423e5a8433d7")]
        public string destinationIP
        {
            get { return _destinationIP; }
            set { _destinationIP = value; }
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

            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Id='label_IPv6Filter') on item 'WebDocument19216801.LabelIPv6Filter'.", repo.WebDocument19216801.LabelIPv6FilterInfo, new RecordItemIndex(0));
            Validate.Attribute(repo.WebDocument19216801.LabelIPv6FilterInfo, "Id", "label_IPv6Filter");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='IPv6 port filtering') on item 'WebDocument19216801.LabelIPv6Filter'.", repo.WebDocument19216801.LabelIPv6FilterInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.WebDocument19216801.LabelIPv6FilterInfo, "InnerText", "IPv6 port filtering");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WebDocument19216801.IPv6Add' at 110;29.", repo.WebDocument19216801.IPv6AddInfo, new RecordItemIndex(2));
            repo.WebDocument19216801.IPv6Add.Click("110;29");
            Delay.Milliseconds(200);
            
            Choose_Protocol_SourceIP_DestinationIP(protocolType, sourceIP, destinationIP);
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
