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
    public partial class Guest_5GHz_Not_Sufficient_Pass_Validate
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_Guest_5GHz_NotSufficient_Pass(string argument1)
        {
			string str1 = repo.WebDocument19216801.PasstextWifi.InnerText;
            string str2 = "Not Sufficient";
            string rstStr ="";
            if (String.Compare(str1,str2 ) == 0){
	            //valid success
	            rstStr = "The Password strength : "+ argument1 + " : is : " + repo.WebDocument19216801.PasstextWifi.InnerText ;
				Report.Info("Validation",rstStr);
	          	Report.Screenshot(repo.WebDocument19216801.PasstextWifi.Element,true);
	          	
             }else {            
                   	//valid failure
                	rstStr = "The Password strength is : " + repo.WebDocument19216801.PasstextWifi.InnerText;
                	Report.Info("Validation",rstStr);
                	Report.Screenshot(repo.WebDocument19216801.PasstextWifi.Element,true);
                	
            }
           // Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Not Sufficient') on item 'WebDocument19216801.PasstextWifi'.", repo.WebDocument19216801.PasstextWifiInfo);
           Validate.Attribute(repo.WebDocument19216801.PasstextWifiInfo, "InnerText", "Not Sufficient","{3}",false);            	        	
        }

    }
}