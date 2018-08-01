/*
 * Created by Ranorex
 * User: KiruShakthy
 * Date: 12/7/2015
 * Time: 4:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
    /// <summary>
    /// Description of Enable_All_Port_Fwd_Rules.
    /// </summary>
    [TestModule("2669BD6C-C428-4DEE-8940-DB197DAD51E8", ModuleType.UserCode, 1)]
    public class Enable_All_Port_Fwd_Rules : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Enable_All_Port_Fwd_Rules()
        {
            // Do not delete - a parameterless constructor is required!
            

            
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
            this.Enable_All_Port_Forwarding_Rules();
        }
        public void Enable_All_Port_Forwarding_Rules(){
        	//select all the port forwarding rules to enable
            Delay.Seconds(15);
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            //TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); 
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']");  //As per R3.5 (9.1.116J)
            //Count the total no of port forwarding rules (rows)
	     	IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");//count the rows
	     	int rulesCount = totalRules.Count;
	     	//Report.Info("Total Rules",rulesCount.ToString());
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	Report.Info("Port Forwarding ",totalPortRules);
	     	
	     	if(rulesCount > 0){
	     					// is there are any active rules ??
		     	//walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
				int j=1;
				Report.Info("Total colsCount",colsCount.ToString());

				foreach(TdTag col in cols)  
		    	{  
					Report.Info("Column #",j.ToString());
		        	Report.Info("Column Value",col.InnerText); 

					if(j==7){	//enable or disable ?
		        		Report.Info("Enable or Disable ?");
		        		IList<InputTag> inputVals = col.Find<InputTag>("./input");
		        		Report.Info("input count :  "+inputVals.Count);
		        		foreach(InputTag inputVal in inputVals){
		        			Ranorex.InputTag testTag = inputVal;
		        			//Report.Info(inputVal.GetPath().ToString());
		        			if(testTag.Checked.ToString() == "True"){	//  already enabled ??
		        				Report.Info(" portForwardingTableEnabledTag is already enabled ");
		        				//inputVal.Checked="False";
		        				//Delay.Seconds(5);
		        				Report.Log(ReportLevel.Success,"This port forwarding rule is enabled");
		        				Report.Screenshot("PortForwardingRule",col.Element,true);
		        			}else if(testTag.Checked.ToString() == "False"){		// currently disabled and enable it now
		        				//Report.Info(" portForwardingTableEnabledTag is currently disabled ");
							    inputVal.PerformClick();
							    Delay.Seconds(2);
		        				Report.Log(ReportLevel.Success,"This port forwarding rule is enabled now...!!!");
		        				Report.Screenshot("PortForwardingRule",col.Element,true);
		        			}
		        			
		        		}//end of for-loop
						        				
						j++;//increment the column
						
		        	}else if(j==8){
						//delete box
						j=1;
		        	}else{ 	j++; }
	
				} // end of FOR-LOOP :TdTag

				Report.Log(ReportLevel.Success,"The following port forwarding rule(s) are Enabled ");
				Delay.Seconds(1);
				//Report.Screenshot();
				Report.Screenshot("PortForwardingRule",myTable.Element,true);

        	}else{
				Report.Failure("Port Forwarding ","There are no active Port Forwarding rules to Enable !!");
	     		TestSuite.Current.GetTestCase("Apply_Port_Forward_Changes_Enable_All").Checked = false;
	     		return;
        	}// end of if-else        	
        	            
        }
    }
}
