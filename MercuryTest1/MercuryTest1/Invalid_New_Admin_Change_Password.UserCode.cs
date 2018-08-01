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
    public partial class Invalid_New_Admin_Change_Password
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Validate_SorryThereWasAnErrorWhileUpdating()
        {
        	/*
            Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Sorry! There was an error while updating your settings. Please try again a bit later.') on item 'WebDocumentIE.SorryThereWasAnErrorWhileUpdating'.", repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdatingInfo);
            Validate.Attribute(repo.WebDocumentIE.SorryThereWasAnErrorWhileUpdatingInfo, "InnerText", "Sorry! There was an error while updating your settings. Please try again a bit later.", Validate.DefaultMessage, false);
            */
           
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            Ranorex.DivTag confirmWizardDivTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'confirm-wizard']");
//            /dom[@page='' and @path='/' and @browsername='IE' and @pageurl='http://192.168.0.1/?change_password&mid=ChangePassword']//div[#'confirm-wizard']
            		// Div --> errClose-NewPassword13,errClose-CurrentPassword, errClose-ReenterPassword
            string confirmWizardPath = confirmWizardDivTag.GetPath().ToString();
//            Report.Info("confirmWizardPath : " + confirmWizardPath);
            IList<DivTag> confirmWizardDivTags =confirmWizardDivTag.Find<DivTag>(confirmWizardPath);
            int rulesCount = confirmWizardDivTags.Count;
//            Report.Info(rulesCount.ToString());
			string rst ="";
            if(rulesCount > 0){
            	foreach (var row in confirmWizardDivTags){
            		IList<DivTag> cols = row.Find<DivTag>("./Div");
            		foreach(DivTag col in cols){
            			//IList<DivTag> spanVals = row.Find<DivTag>("./Div");
            			rst = col.InnerText;
            			Report.Info(rst);
            			Report.Screenshot();
            			Report.Screenshot(confirmWizardDivTag.Element,true);
            		}
            	}
            }
			if(rst.StartsWith("Your settings have been updated")){
				Report.Failure("Incorrect validation");
			}else if(rst.StartsWith("Sorry! There was an error while updating your settings. Please try again a bit later.")){
				//Sorry! There was an error while updating your settings. Please try again a bit later.
				Report.Success("Successful Validation");
			}
			
        }

        public void Refresh_Screen()
        {
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            webDocument.PressKeys("Fn F5");        	
        }

    }
}