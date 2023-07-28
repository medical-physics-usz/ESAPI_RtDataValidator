# ESAPI Script to evaluate plan parameters

This script was developed over several years at the Radiation Oncology Department of the University Hospital Zurich to verify plan parameters of RT plans. 

In the anonymized example below, you can see the script in action with several entries:
1) Green entries: values within parameters
2) Violet entries: values that require a manual review
3) Red entries: values outside the accepted range

![image](https://github.com/riccardodalbelloUSZ/ESAPI_RtDataValidator/assets/79981471/85ad2b6d-192f-4656-a0af-9834055df604)

Examples of successful tests:
- line 3: there are non-zero couch shifts assigned to the plan
- line 4: this plan type does not require gating and gating is turned off
- line 12: the slice separation in the CT dataset is 2mm
- line 27: all VMAT fields have the same beam quality

Example of manual review:
- line 18: the plan will deliver 15 fractions of 2 Gy/fx

Example of failed test:
- line 9: there are too many days between today and the date of the planning CT

Use of the code:

The code was developed for the specific needs of the Radiation Oncology Department of the University Hospital Zurich. By no means, the tests and the validity ranges of the tests should be taken without critical inspection and directly implemented for clinical use. The code is shared "as is" without warranty or responsibility of any type. The proprietary ESAPI libraries should be requested directly to Varian and will not be distributed in this repository. To use the code, proceed with the following steps:

1) Change to the appropriate values the settings in: settings.xml
2) Point to the folders where you compiled the executable in: USZ_RtDataValidator.cs
3) Compile the Visual Studio project

Support:

The code is shared solely for the benefit of scientific collaboration between Radiation Oncology departments. It may be downloaded, edited and used for no-profit research purposes. The code may not be used for the development of commercial software. We are glad to share the code, but we do not have dedicated personnel and capacity to provide support or for adapting it and implementing it in you Aria installation.

License:

The code is distributed under the Creative Common Attribution-NonCommercial 4.0 International (CC BY-NC 4.0) 
https://creativecommons.org/licenses/by-nc/4.0/ 
You are free to:

Share: copy and redistribute the material in any medium or format

Adapt: remix, transform, and build upon the material

Under the following terms:

Attribution: You must give appropriate credit, provide a link to the license, and indicate if changes were made. You may do so in any reasonable manner, but not in any way that suggests the licensor endorses you or your use.

NonCommercial: You may not use the material for commercial purposes.

Disclaimer:

Please read this disclaimer carefully before using the open-source software ("RtDataValidator"). By using the Software, you agree to be bound by the terms and conditions set forth in this disclaimer. If you do not agree with these terms, do not use the Software RtDataValidator.

1. Non-Clinical Use Only: The Software is intended for non-clinical purposes only. It is not designed, tested, or validated for use in any clinical, medical, or healthcare-related applications, including but not limited to diagnosis, treatment, or monitoring of patients. The use of this Software for any clinical purpose is strictly prohibited.

2. No Warranty: The Software is provided "as is" without warranty of any kind, either expressed or implied, including but not limited to the implied warranties of merchantability, fitness for a particular purpose, or non-infringement. The developers and contributors of the Software make no representations or warranties concerning the suitability, reliability, or accuracy of the Software for any purpose.

3. Use at Your Own Risk: The use of the Software is at your own risk. In no event shall the developers or contributors of the Software be liable for any damages, direct or indirect, arising out of the use or inability to use the Software, even if advised of the possibility of such damages.

4. No Support: The developers and contributors of the Software are not obligated to provide any support, maintenance, updates, or bug fixes. While efforts may be made to improve the Software, there is no guarantee of continued development or enhancements.

