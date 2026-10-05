using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x0200000B RID: 11
	[ClassInterface(0)]
	[Guid("86F18A4E-9C4E-4F02-8036-9CEABFCCCD99")]
	[ComImport]
	public class LuaFunctionClass : ILuaFunction, LuaFunction
	{
		// Token: 0x06000026 RID: 38
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal extern LuaFunctionClass();

		// Token: 0x06000027 RID: 39
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.Struct)]
		public virtual extern object Call([MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg1, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg2, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg3, [MarshalAs(UnmanagedType.Struct)] [In] [Optional] object arg4);

		// Token: 0x06000028 RID: 40
		[DispId(2)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		[return: MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)]
		public virtual extern Array CallEx([MarshalAs(UnmanagedType.SafeArray, SafeArraySubType = VarEnum.VT_VARIANT)] [In] [Optional] Array args);
	}
}
