/*
 * Created by Ranorex
 * User: Planit
 * Date: 11-11-2025
 * Time: 02:57
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
    /// Description of UploadTesting.
    /// </summary>
    [TestModule("EBF5C768-8929-4524-BA58-A9A22BB183A2", ModuleType.UserCode, 1)]
    public class TxtVisble : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public TxtVisble()
        {
            // Do not delete - a parameterless constructor is required!
        }
        string _Speed = "";
        [TestVariable("dac86625-9583-4b4e-b8a8-ac351cf12c99")]
        public string Speed
        {
        	get { return _Speed; }
        	set { _Speed = "Medium"; }
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
                        
            rx.RxMainFrame.RxTabUpload.RdBtn_Speed.Click();
            
            rx.RxMainFrame.RxTabUpload.Btn_Start.Click();
            
        	while(!rx.RxMainFrame.RxTabUpload.Txt_Finished.Visible){
        		Thread.Sleep(10000);
        	}
            
            Validate.AttributeEqual(rx.RxMainFrame.RxTabUpload.Txt_FinishedInfo, "Text", "Upload finished");
                        
            rx.RxMainFrame.RxTabUpload.Btn_Reset.Click();
            
            
            
        }
    }
}
