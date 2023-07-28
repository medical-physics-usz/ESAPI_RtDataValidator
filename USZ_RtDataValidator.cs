using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.Collections.Generic;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using System.IO;
using System.Windows.Media.Media3D;
using System.Windows.Media;
using System.Diagnostics;

namespace VMS.TPS
{
	/// <summary>
    /// Class script (default).
	/// Author: R. Dal Bello / 24.09.2021
    /// </summary>
    public class Script
    {
        public Script()
        {
        }

        /// <summary>
        /// Start/execute script (default).
        /// Start validator with input patient and plan id.
        /// Author: R. Dal Bello / 24.09.2021
        /// </summary>
        public void Execute(ScriptContext context)
        {
			// Get patient id.
            Patient patient = context.Patient;
			
            if (patient == null)
            {
                MessageBox.Show("Please select a patient");

            }
            else
            {
			
            if (context.PlanSetup == null)
                {
                    MessageBox.Show("Please open the plan you would like to verify");
                }
            else
                {
                    StartValidator(context.Patient.Id, context.PlanSetup.Id, context.Course.Id, context.CurrentUser.Id);
                }
            }
        }

        /// <summary>
        /// Start validator.
        /// Start validator with input patient id.
        /// Author: R. Dal Bello / 24.09.2021
        /// </summary>
        public static void StartValidator(string patientId, string planSetupId, string courseId, string userID)
        {

	    string userID_noSlash = userID.Replace("\\","_"); 
            string args = patientId.Trim() +  " \"" + planSetupId.Trim() + "\" \"" + courseId.Trim() + "\" \"" + userID_noSlash.Trim() + "\"";
            
				
            // Run process with argument patient id.
            Process proc = new Process();
            proc.StartInfo.UseShellExecute = true;

            // Do not create cmd window.
            proc.StartInfo.CreateNoWindow = true;

            proc.StartInfo.FileName = @"\\VM-0000\raoariaapps$\RtDataValidator_ARIA16\RtDataValidator.exe";
            proc.StartInfo.WorkingDirectory = @"\\VM-0000\raoariaapps$\RtDataValidator_ARIA16";
            proc.StartInfo.Arguments = args;

            proc.Start();
        }
    }
}