/*
 * Created by Ranorex
 * User: Planit
 * Date: 12-11-2025
 * Time: 03:03
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
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

namespace RxDemo_Desktop.CodeModules
{
    /// <summary>
    /// Description of shuffleTable.
    /// </summary>
    [TestModule("5D42E7CA-42CF-4CA1-8488-AC8452AB4F98", ModuleType.UserCode, 1)]
    public class shuffleTable : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public shuffleTable()
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
            
            
            RxDemo_DesktopRepository rx = new RxDemo_DesktopRepository();
            
            //string rowText = rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info.GetAttributeValueText("Text");
            
//            if(!rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info.Equals("John")){
//            		rx.RxMainFrame.RxButtonExit.Click();
//            	}
           
            	rx.RxMainFrame.RxTabUIElements.Table.Btn_Shuffle.Click();
            while(!rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info.Equals("John")){
            		Console.WriteLine(rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info);
            		string name = rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info.ToString();
            	rx.RxMainFrame.RxTabUIElements.Table.Btn_Shuffle.Click();
            	Delay.Milliseconds(500);
            	if(rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info.Equals("John")){
            		rx.RxMainFrame.RxButtonExit.Click();
            	}
            	//Report.Info("Current Row Text: " + rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info);
            	}
            	
            if(rx.RxMainFrame.RxTabUIElements.Table.Table_Row0Info.Equals("John")){
            		rx.RxMainFrame.RxButtonExit.Click();
            	}
            	
            
                    
            
        }
    }
}
