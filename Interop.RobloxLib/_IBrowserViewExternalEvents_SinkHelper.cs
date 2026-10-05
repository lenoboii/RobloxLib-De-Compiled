using System;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000013 RID: 19
	[ClassInterface(ClassInterfaceType.None)]
	[TypeLibType(TypeLibTypeFlags.FHidden)]
	public sealed class _IBrowserViewExternalEvents_SinkHelper : _IBrowserViewExternalEvents
	{
		// Token: 0x06000034 RID: 52 RVA: 0x00002050 File Offset: 0x00000250
		internal _IBrowserViewExternalEvents_SinkHelper()
		{
			this.m_dwCookie = 0;
		}

		// Token: 0x04000001 RID: 1
		public int m_dwCookie;
	}
}
