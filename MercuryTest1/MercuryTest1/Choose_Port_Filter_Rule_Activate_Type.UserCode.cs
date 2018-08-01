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
    public partial class Choose_Port_Filter_Rule_Activate_Type
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Choose_Port_Active_Type(string argument1)
        {
        	Report.Info(argument1);
        	
        	if(argument1=="ALWAYS"){	// Always on
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Always3").Checked = true;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Different_Access_Time2").Checked = false;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_General_Access_Time2").Checked = false;
        	}else if(argument1=="DIFFERENT"){	//Different_Access_Time ,different days of the week
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Different_Access_Time2").Checked = true;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Always3").Checked = false;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_General_Access_Time2").Checked = false;
        	}else if(argument1=="GENERAL"){
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_General_Access_Time2").Checked = true;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Always3").Checked = false;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Different_Access_Time2").Checked = false;
        	}else if(argument1=="NONE"){
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Always3").Checked = false;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_Different_Access_Time2").Checked = false;
        		TestSuite.Current.GetTestCase("Activate_Port_Filtering_Rule_General_Access_Time2").Checked = false;        		
        	}
        }

    }
}