using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000002 RID: 2
	[Guid("6BBA69D8-0DD6-41AC-85D9-2488D412C961")]
	[ClassInterface(0)]
	[TypeLibType(2)]
	[ComImport]
	public class WorkspaceClass : IWorkspace, Workspace
	{
		// Token: 0x06000001 RID: 1
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern WorkspaceClass();

		// Token: 0x06000002 RID: 2
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Insert([MarshalAs(UnmanagedType.BStr)] [In] string url);

		// Token: 0x06000003 RID: 3
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern Content Write();

		// Token: 0x06000004 RID: 4
		[DispId(3)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Interface)]
		public virtual extern Content WriteSelection();

		// Token: 0x06000005 RID: 5
		[DispId(4)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)]
		public virtual extern Array ExecUrlScript([MarshalAs(UnmanagedType.BStr)] [In] string url, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg1, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg2, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg3, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg4);

		// Token: 0x06000006 RID: 6
		[DispId(5)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Close();

		// Token: 0x06000007 RID: 7
		[DispId(7)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void StartDrag([MarshalAs(UnmanagedType.BStr)] [In] string url);

		// Token: 0x06000008 RID: 8
		[DispId(8)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)]
		public virtual extern Array GetPlayers();

		// Token: 0x06000009 RID: 9
		[DispId(9)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void ReportAbuse([In] int abuserId, [MarshalAs(UnmanagedType.BStr)] [In] string comment);

		// Token: 0x0600000A RID: 10
		[TypeLibFunc(64)]
		[DispId(10)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void Save();

		// Token: 0x0600000B RID: 11
		[DispId(11)]
		[TypeLibFunc(64)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void SaveUrl([MarshalAs(UnmanagedType.BStr)] [In] string url);

		// Token: 0x0600000C RID: 12
		[TypeLibFunc(64)]
		[DispId(12)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public virtual extern void JoinGame([MarshalAs(UnmanagedType.BStr)] [In] string server, [MarshalAs(UnmanagedType.BStr)] [In] string port, [MarshalAs(UnmanagedType.BStr)] [In] string gameTicket);
	}
}
