﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
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

namespace ArrisTest
{
    public partial class Software_Info
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_SoftwareVersion()
        {
           // Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText=$SoftwareVersion) on item 'WebDocument19216801.SoftwareVersion'.", repo.WebDocument19216801.SoftwareVersionInfo);
           // Validate.Attribute(repo.WebDocument19216801.SoftwareVersionInfo, "InnerText", SoftwareVersion);
           
         Boolean softVersion = repo.WebDocument19216801.SoftwareVersion.InnerText.Contains(SoftwareVersion);
    	//string strSoftVersion = repo.WebDocument19216801.SoftwareVersion.InnerText.trim;
    	//Boolean softVersion = repo.WebDocument19216801.SoftwareVersion.InnerText.Equals(SoftwareVersion);
    		
	 	 if(softVersion){// if true
	 		Report.Log(ReportLevel.Success,"Validation","SoftVersion validation success");
	 		Report.Log(ReportLevel.Info,"SoftwareVersion Expected : ",SoftwareVersion);
	 	 	Report.Log(ReportLevel.Info,"SoftVersion Actual : ",repo.WebDocument19216801.SoftwareVersion.InnerText);
	 	 }else{	//if false
	 	 	Report.Log(ReportLevel.Failure,"validation","SoftVersion validation failure");
	 	 	Report.Log(ReportLevel.Info,"SoftVersion Expected : ",SoftwareVersion);
	 	 	Report.Log(ReportLevel.Info,"SoftVersion Actual : ",repo.WebDocument19216801.SoftwareVersion.InnerText);
	 	 }
 	
        }

    }
}