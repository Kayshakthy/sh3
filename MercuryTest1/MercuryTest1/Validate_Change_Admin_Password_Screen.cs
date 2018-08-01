/*
 * Created by Ranorex
 * User: Sakthivel
 * Date: 09/09/2016
 * Time: 11:36
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
    /// Description of Validate_Change_Admin_Password_Screen.
    /// </summary>
    [TestModule("C3688644-A3BD-4DC6-8632-1FBD4AB63BBA", ModuleType.UserCode, 1)]
    public class Validate_Change_Admin_Password_Screen : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Validate_Change_Admin_Password_Screen()
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
            this.Validate_Admin_Password__Change_Screen();
        }
        private void Validate_Admin_Password__Change_Screen(){
        	Delay.Seconds(30);
        	WebDocument webDocument = "/dom[@domain='192.168.0.1']";
        	webDocument.WaitForDocumentLoaded();
        	//Report.Info(webDocument.GetHtml());
        	TableTag myTable = webDocument.FindSingle("/dom[@domain='192.168.0.1']//div[#'LoginSettings']/table"); 
            //Count the total no of rows
	     	IList<TrTag> totalDeviceRows = myTable.Find<TrTag>("./tbody//tr");
	     	int rulesCount = totalDeviceRows.Count;  
	     	Report.Info(" LoginSettings Password Table Rows : " + rulesCount);
//	     	bool isSuccess=true;
	     	if(rulesCount == 3){
	     		int rowNum = 1;
	     		foreach (var row in totalDeviceRows) {
	     			IList<TdTag> cols = row.Find<TdTag>("./td");
	     			 int colNum = 1;
	     			foreach(TdTag MacCol in cols){
	     				if(colNum ==1){
	     					Report.Info("Col Info: "+MacCol.InnerText);	
	     					//validate lable values
	     				}if(colNum ==2){
			        		IList<SpanTag> spanVals = MacCol.Find<SpanTag>("./span");
			        		if(spanVals.Count==1){
			        			Report.Success("Password field validation is Success");
			        		}
			        		/*
			        		foreach(SpanTag spanVal in spanVals){
			        			devInfo = spanVal.InnerText;
			        			if(devInfo.Length > 0){
			        				devInfoSubstr = devInfo.Substring(1,devInfo.Length-1);	// for validation purpose
			        			}else{
			        				//blank
			        				devInfoSubstr = "";
			        			}
			        		} */	     					
	     				}
	     			 	colNum++;
	     			}//end of Column
	     			 rowNum++;
	     		}//end of ROW
	     	}else{
	     		Report.Failure("Issue with page display !!");
	     	}
        }
    }
}
