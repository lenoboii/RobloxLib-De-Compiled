using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000008 RID: 8
	[Guid("6343895F-4799-43C8-94F9-3D51A0D293CF")]
	[TypeLibType(4288)]
	[ComImport]
	public interface IApp
	{
		// Token: 0x0600001F RID: 31
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Workspace CreateGame([MarshalAs(UnmanagedType.BStr)] [In] string p);

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000020 RID: 32
		[DispId(4)]
		string Version { [DispId(4)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000021 RID: 33
		[DispId(11)]
		string ID { [DispId(11)] [MethodImpl(MethodImplOptions.InternalCall)] [return: MarshalAs(UnmanagedType.BStr)] get; }

		// Token: 0x06000022 RID: 34
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void RobloxAuthenticate([MarshalAs(UnmanagedType.BStr)] [In] string url, [MarshalAs(UnmanagedType.BStr)] [In] string ticket);

		// Token: 0x06000023 RID: 35
		[DispId(13)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Quit();
	}
}
