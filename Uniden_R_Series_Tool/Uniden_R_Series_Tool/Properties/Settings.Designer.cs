using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace Uniden_R_Series_Tool.Properties
{
	// Token: 0x0200002F RID: 47
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060001E2 RID: 482 RVA: 0x00022510 File Offset: 0x00020710
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x04000396 RID: 918
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
