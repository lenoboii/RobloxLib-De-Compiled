using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000009 RID: 9
	[ClassInterface(0)]
	[Guid("6614D880-6572-4C04-8A7C-D026502A6B95")]
	[ComImport]
	public class ContentClass : IContent, Content
	{
		// Token: 0x06000024 RID: 36
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern ContentClass();

		// Token: 0x06000025 RID: 37
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Upload([MarshalAs(UnmanagedType.BStr)] [In] string url);
	}
}
