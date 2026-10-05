using System;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000011 RID: 17
	[Guid("DB4E00C1-D221-41B1-88CE-F9BB32A68C02")]
	[CoClass(typeof(BrowserViewExternalClass))]
	[ComImport]
	public interface BrowserViewExternal : IBrowserViewExternal, _IBrowserViewExternalEvents_Event
	{
	}
}
