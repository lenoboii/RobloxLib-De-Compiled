using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x0200000D RID: 13
	[Guid("22423A31-9290-4F17-BD95-000F61859FAE")]
	[TypeLibType(4288)]
	[ComImport]
	public interface ILuaFunction
	{
		// Token: 0x06000029 RID: 41
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		object Call([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg1, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg2, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg3, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg4);

		// Token: 0x0600002A RID: 42
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)]
		Array CallEx([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] [In] [Optional] Array args);
	}
}
