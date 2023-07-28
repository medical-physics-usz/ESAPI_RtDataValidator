# ESAPI Script to evaluate plan parameters

This script was developed over several years at the Radiation Oncology Department of the University Hospital Zurich to verify plan parameters of RT plans. 

In the anonymized example below you can see the script in action with several entries:
1) Green entries: values within parameters
2) Violet entries: values that require a manual review
3) Red entries: values outside the accepted range

![image](https://github.com/riccardodalbelloUSZ/ESAPI_RtDataValidator/assets/79981471/85ad2b6d-192f-4656-a0af-9834055df604)

Examples of succesful tests:
- line 3: there are non-zero couch shifts assigned to the plan
- line 4: this plan type does not require gating and gating is turned off
- line 12: the slice separation in the CT dataset is 2mm
- line 27: all VMAT fields have the same beam quality

Example of manual review:
- line 18: the plan will deliver 15 fractions of 2 Gy/fx

Example of failed test:
- line 9: there are too many days between today and the date of the planning CT

Use of the code:
The code was developed for the specific needs of the Radiation Oncology Department of the University Hospital Zurich. By no means the tests and the validity ranges of the tests should be taken without critical inspection and directly implemented for clinical use. The code is shares "as is" without warranty or responsability of any type.

1) Change to the appropriate values the settings in: settings.xml
2) Point to the folders where you compiled the executable in: USZ_RtDataValidator.cs

