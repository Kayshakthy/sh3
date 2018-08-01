/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 11/04/2016
 * Time: 10:53
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
    /// Description of Choose_All_Port_Forwarding_Rules_To_Enable.
    /// </summary>
    [TestModule("BCC0541D-B8E1-4270-AAE3-E34ECFDB28D1", ModuleType.UserCode, 1)]
    public class Choose_All_Port_Forwarding_Rules_To_Enable : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        int TotalRows = 0;
        public Choose_All_Port_Forwarding_Rules_To_Enable()
        {
            // Do not delete - a parameterless constructor is required!
            WebDocument webDocument1 = "/dom[@domain='192.168.0.1']";
            webDocument1.WaitForDocumentLoaded();
            Delay.Seconds(45);
            //TableTag myTable1 = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']"); //As per R3.5 (9.1.116J)
             TableTag myTable = webDocument1.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); //As per R 3,11.1
            //Report.Screenshot("New Port Triggering Rule", myTable.Element,true);
  
            //highlight the new port triggering rule
            //IList<TrTag> rows1 = myTable1.Find<TrTag>("./tbody//tr");
            IList<TrTag> rows1 = myTable.Find<TrTag>("./tbody//tr");
            TotalRows = rows1.Count;
            Report.Info(" TotalRows(Before Add)",TotalRows.ToString());                
            
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
            this.Select_All_Port_Forwarding_Rules();
        }
        public void Select_All_Port_Forwarding_Rules(){
        	//implemented based on R3.5(9.1.116J)
            //Delay.Seconds(15);
            if(TotalRows <10){
				Delay.Seconds(20);
        	}else if(TotalRows >10 && TotalRows <20){
        		Delay.Seconds(30);
        	}else if(TotalRows >20 && TotalRows <30){
        		Delay.Seconds(40);
        	}else if(TotalRows >30){
        		Delay.Seconds(50);
        	}            
            WebDocument webDocument = "/dom[@domain='192.168.0.1']";
            TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'PortForwardingTable']"); //As per R 3,11.1
           // TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//table[#'portTriggeringTable']");  //As per R3.5 (9.1.116J)
            
            //Count the total no of port forwarding rules (rows)
	     	IList<TrTag> totalRules = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalRules.Count;
	     	//Report.Info("Total Rules",rulesCount.ToString());
	     	string totalPortRules = "Total Rules : "+rulesCount.ToString();
	     	//Report.Info("Port Forwarding ",totalPortRules);
	     	
	     	if(rulesCount > 0){
	     		Report.Info("Total Rules",totalPortRules);
	     		// is there are any active rules ??
		     	//walkthrough the column values
				IList<TdTag> cols = myTable.Find<TdTag>("./tbody//td");  
				int colsCount = cols.Count;
				int j=1;
				//Report.Info("Total colsCount",colsCount.ToString());

				foreach(TdTag col in cols)  
		    	{  
					//Report.Info("Column #",j.ToString());
		        	//Report.Info("Column Value",col.InnerText); 
					if(j==5){
		        		//enable or disable ?
		        		
		        		//Report.Info("Enable or Disable ?");
		        		
		        		IList<InputTag> inputVals = col.Find<InputTag>("./input");
		        		//Report.Info("input count :  "+inputVals.Count);
		        		foreach(InputTag inputVal in inputVals){
		        			Ranorex.InputTag testTag = inputVal;
		        			Report.Info(inputVal.GetPath().ToString());
		        			if(testTag.Checked.ToString() == "False"){
		        				Report.Info(" portForwardingTableEnabledTag is currently  disabled");
		        				//inputVal.Checked="True";
		        				inputVal.PerformClick();
		        				Delay.Seconds(5);
		        				Report.Log(ReportLevel.Success,"This port forwarding rule is  enabled now...");
		        				Report.Screenshot("PortForwardingRule",col.Element,true);
		        			}else{
		        				//Report.Info(" portForwardingTableEnabledTag is currently enabled ");
							    //inputVal.PerformClick();
							    Delay.Seconds(5);
		        				Report.Log(ReportLevel.Success,"This port forwarding rule is already enabled !!!");
		        				Report.Screenshot("PortForwardingRule",col.Element,true);
		        			}
		        			
		        		}//end of for-loop : InputTag
		        		j++;//increment the column
		        	}else if(j==6){
						//delete box
						//Report.Info("delete ?");
						j=1;
		        	}else{ 	j++; }
				}// end of FOR-LOOP :TdTag
				Report.Log(ReportLevel.Success,"The following port forwarding rule(s) are Enabled");
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
