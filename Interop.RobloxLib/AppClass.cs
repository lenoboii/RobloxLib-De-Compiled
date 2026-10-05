using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000006 RID: 6
	[Guid("FE0D8F60-5A07-40A1-85EC-4FFB7E0F2306")]
	[ClassInterface(0)]
	[TypeLibType(2)]
	[ComImport]
	public class AppClass : IApp, App
	{
		// Token: 0x06000019 RID: 25
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern AppClass();

		// Token: 0x0600001A RID: 26
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern Workspace CreateGame([MarshalAs(UnmanagedType.BStr)] [In] string p);

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600001B RID: 27
		[DispId(4)]
		public virtual extern string Version { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600001C RID: 28
		[DispId(11)]
		public virtual extern string ID { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x0600001D RID: 29
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void RobloxAuthenticate([MarshalAs(UnmanagedType.BStr)] [In] string url, [MarshalAs(UnmanagedType.BStr)] [In] string ticket);

		// Token: 0x0600001E RID: 30
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Quit();
	}
}
