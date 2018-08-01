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
    public partial class Check_2GHzPassword_Field_Guest
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_Passphrase()
        {
//            Validate.Attribute(repo.WebDocument19216801.PassphraseInfo, "Enabled", "False");
            bool isEnabled = Validate.Attribute(repo.WebDocument19216801.PassphraseInfo, "Enabled", "True","{2}",false);
//            String currentTestcaseName = TestCase.Current.Name;		//obsolete in 6.x
            string currentTestcaseName = TestCaseNode.Current.Name;
            
        	Report.Info("Current TC ", currentTestcaseName);
			if(isEnabled){
				Report.Success(" Guest Passphrase is enabled !");
				if(currentTestcaseName.StartsWith("Validate_2GHz_Good_Password_Field_Guest")){//good
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Good_Password_Validation_Security_Mode").Checked = true;
					TestSuite.Current.GetTestCase("Validate_Good_Pass_2_4GHz_Guest").Checked = true;
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Strong_Password_Field_Guest")){//strong
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Strong_Password_Validation_Security_Mode").Checked = true;
					TestSuite.Current.GetTestCase("Validate_Strong_Pass_2_4GHz_Guest").Checked = true;
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Very_Strong_Password_Field_Guest")){//very strong
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Very_Strong_Password_Validation_Security_Mode").Checked = true;
					TestSuite.Current.GetTestCase("Validate_Very_Strong_Pass_2_4GHz_Guest").Checked = true;					
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Not_Sufficient_Password_Field_Guest")){//not sufficient
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Not_Sufficient_Password_Validation_Security_Mode").Checked = true;
					TestSuite.Current.GetTestCase("Validate_Guest_Not_Sufficient_Pass_2_4GHz").Checked = true;					
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Invalid_Password_Field_Guest")){//invalid
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Invalid_Password_Validation_Security_Mode").Checked = true;
					TestSuite.Current.GetTestCase("Validate_Guest_Invalid_Pass_2.4GHz").Checked = true;					
				}				
        	}else{
				Report.Failure(" Guest Passphrase is disabled !");
				if(currentTestcaseName.StartsWith("Validate_2GHz_Good_Password_Field_Guest")){
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Good_Password_Validation_Security_Mode").Checked = false;
					TestSuite.Current.GetTestCase("Validate_Good_Pass_2_4GHz_Guest").Checked = false;
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Strong_Password_Field_Guest")){//strong
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Strong_Password_Validation_Security_Mode").Checked = false;
					TestSuite.Current.GetTestCase("Validate_Strong_Pass_2_4GHz_Guest").Checked = false;					
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Very_Strong_Password_Field_Guest")){//very strong
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Very_Strong_Password_Validation_Security_Mode").Checked = false;
					TestSuite.Current.GetTestCase("Validate_Very_Strong_Pass_2_4GHz_Guest").Checked = false;						
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Not_Sufficient_Password_Field_Guest")){//not sufficient
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Not_Sufficient_Password_Validation_Security_Mode").Checked = false;
					TestSuite.Current.GetTestCase("Validate_Guest_Not_Sufficient_Pass_2_4GHz").Checked = false;						
				}else if(currentTestcaseName.StartsWith("Validate_2GHz_Invalid_Password_Field_Guest")){//invalid
					TestSuite.Current.GetTestCase("Choose_2.4GHz_Guest_Invalid_Password_Validation_Security_Mode").Checked = false;
					TestSuite.Current.GetTestCase("Validate_Guest_Invalid_Pass_2.4GHz").Checked = false;						
				}
        	}
        	
        }

    }
}