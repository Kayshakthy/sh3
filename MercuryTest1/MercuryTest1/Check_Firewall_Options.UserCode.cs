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
    public partial class Check_Firewall_Options
    {
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void Choose_firewallOptions(string argument1)
        {
        	//argument1 - IP_Flood_Detect
        	
        	//check/uncheck checkboxes
        	 WebDocument webDocument = "/dom[@domain='192.168.0.1']";

			//Ranorex.SelectTag enableTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'tr_Enabled']/select[@id='Enabled']");
			
		    //Ranorex.InputTag enableTag =  webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#tr_EnablePortScanDetection']/input[@id='EnablePortScanDetection']");
			
			//Ranorex.InputTag  enableTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'tr_EnableBlockFramentedPkts']/input[#'EnableBlockFramentedPkts']");
			//Ranorex.SelectTag securityTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'tr_SecurityModeGrp']/select[#'SecurityModeGrp']");
			
			//Ranorex.DivTag enableTag = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'tr_EnableBlockFramentedPkts']");
			
			//Ranorex.InputTag enableTag =  webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#tr_EnablePortScanDetection']/input[#'EnablePortScanDetection']");	
			//Ranorex.InputTag enableTag =  webDocument.FindSingle("/dom[@domain='192.168.0.1']//input[#'EnableIPFloodDetection']");
			
			//Ranorex.DivTag divTag = webDocument.FindSingle("dom[@domain='192.168.0.1']//div[#'tr_EnablePortScanDetection']");
			//Report.Info(divTag.GetInnerHtml().ToString());
			Ranorex.InputTag IPv4FirewallProtectTag ="/dom[@domain='192.168.0.1']//div[#'tr_EnableFirewall']/input[#'EnableFirewall']";
			Ranorex.InputTag BlockFragmentTag ="/dom[@domain='192.168.0.1']//div[#'tr_EnableBlockFramentedPkts']/input[#'EnableBlockFramentedPkts']";
			Ranorex.InputTag PortScanTag = "/dom[@domain='192.168.0.1']//div[#'tr_EnablePortScanDetection']/input[#'EnablePortScanDetection']";
			Ranorex.InputTag IPFloodDetectTag ="/dom[@domain='192.168.0.1']//div[#'tr_EnableIPFloodDetection']/input[#'EnableIPFloodDetection']";
				
			//Report.Info(FirewallProtectTag.GetInnerHtml().ToString());
			
			Report.Info("FirewallProtectTag(Default) : "+IPv4FirewallProtectTag.Checked.ToString());
			Report.Info("BlockFragmentTag(Default) : "+BlockFragmentTag.Checked.ToString());
			Report.Info("PortScanTag(Default) : " + PortScanTag.Checked.ToString());
			Report.Info("IPFloodDetectTag(Default) : " + IPFloodDetectTag.Checked.ToString());
			/*
			bool rst = IPv4FirewallProtectTag.Checked.Contains("checked");
			Report.Info(rst.ToString());
			Delay.Seconds(2);
			*/
			
			
			BlockFragmentTag.PerformClick();
			//Delay.Seconds(5);
			
			PortScanTag.PerformClick();
			//Delay.Seconds(5);
			
			//IPFloodDetectTag.PerformClick();	//click the checkbox
			//Delay.Seconds(5);
			if(argument1  == "Enable"){
				Report.Info("----------------- inside IPFloodDetectTag if (Enable) ----- ");
				if (IPFloodDetectTag.Checked.ToString() == "False"){
					Report.Info("----------------- IPFloodDetectTag was False ---");
					IPFloodDetectTag.Checked = "True";
				}else{
					Report.Info(" IPFloodDetectTag is already Enabled ");
				}
			}else{
				IPFloodDetectTag.Checked = "False";
			}
			
			IPv4FirewallProtectTag.Checked = "False";	// False - UnCheck the checkbox
			//IPv4FirewallProtectTag.PerformClick();
			//Delay.Seconds(5);	
			
			Report.Info("IPv4FirewallProtectTag(After) : "+IPv4FirewallProtectTag.Checked.ToString());
			Report.Info("BlockFragmentTag(After) : "+BlockFragmentTag.Checked.ToString());
			Report.Info("PortScanTag(After) : " + PortScanTag.Checked.ToString());
			Report.Info("IPFloodDetectTag(After) : " + IPFloodDetectTag.Checked.ToString());
			
        }

    }
}