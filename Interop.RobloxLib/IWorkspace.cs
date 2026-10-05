using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000004 RID: 4
	[Guid("794D78C9-B0EC-4BC9-B881-B5F45E1D530B")]
	[TypeLibType(4288)]
	[ComImport]
	public interface IWorkspace
	{
		// Token: 0x0600000D RID: 13
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Insert([MarshalAs(UnmanagedType.BStr)] [In] string url);

		// Token: 0x0600000E RID: 14
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Content Write();

		// Token: 0x0600000F RID: 15
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Content WriteSelection();

		// Token: 0x06000010 RID: 16
		[DispId(4)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)]
		Array ExecUrlScript([MarshalAs(UnmanagedType.BStr)] [In] string url, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg1, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg2, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg3, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg4);

		// Token: 0x06000011 RID: 17
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Close();

		// Token: 0x06000012 RID: 18
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void StartDrag([MarshalAs(UnmanagedType.BStr)] [In] string url);

		// Token: 0x06000013 RID: 19
		[TypeLibFunc(64)]
		[DispId(8)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)]
		Array GetPlayers();

		// Token: 0x06000014 RID: 20
		[DispId(9)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void ReportAbuse([In] int abuserId, [MarshalAs(UnmanagedType.BStr)] [In] string comment);

		// Token: 0x06000015 RID: 21
		[TypeLibFunc(64)]
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Save();

		// Token: 0x06000016 RID: 22
		[DispId(11)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void SaveUrl([MarshalAs(UnmanagedType.BStr)] [In] string url);

		// Token: 0x06000017 RID: 23
		[DispId(12)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void JoinGame([MarshalAs(UnmanagedType.BStr)] [In] string server, [MarshalAs(UnmanagedType.BStr)] [In] string port, [MarshalAs(UnmanagedType.BStr)] [In] string gameTicket);
	}
}
