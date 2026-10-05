using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x0200000F RID: 15
	[ComSourceInterfaces("RobloxLib._IBrowserViewExternalEvents\0\0")]
	[Guid("9F4EA997-3E2F-43F5-8337-40EFD6BFD90C")]
	[ClassInterface(0)]
	[ComImport]
	public class BrowserViewExternalClass : IBrowserViewExternal, BrowserViewExternal, _IBrowserViewExternalEvents_Event
	{
		// Token: 0x0600002B RID: 43
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern BrowserViewExternalClass();

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002C RID: 44
		[DispId(1)]
		public virtual extern bool IsRobloxAppIDE { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x0600002D RID: 45
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		public virtual extern object GetApp();

		// Token: 0x0600002E RID: 46
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void StartGame([MarshalAs(UnmanagedType.BStr)] [In] string authenticationTicket, [MarshalAs(UnmanagedType.BStr)] [In] string authenticationUrl, [MarshalAs(UnmanagedType.BStr)] [In] string script);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002F RID: 47
		[DispId(4)]
		public virtual extern string InstallHost { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
