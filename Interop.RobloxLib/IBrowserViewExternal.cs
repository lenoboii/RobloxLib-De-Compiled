using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000012 RID: 18
	[TypeLibType(4288)]
	[Guid("DB4E00C1-D221-41B1-88CE-F9BB32A68C02")]
	[ComImport]
	public interface IBrowserViewExternal
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000030 RID: 48
		[DispId(1)]
		bool IsRobloxAppIDE { [DispId(1)] [MethodImpl(MethodImplOptions.InternalCall)] get; }

		// Token: 0x06000031 RID: 49
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object GetApp();

		// Token: 0x06000032 RID: 50
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void StartGame([MarshalAs(UnmanagedType.BStr)] [In] string authenticationTicket, [MarshalAs(UnmanagedType.BStr)] [In] string authenticationUrl, [MarshalAs(UnmanagedType.BStr)] [In] string script);

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000033 RID: 51
		[DispId(4)]
		string InstallHost { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }
	}
}
