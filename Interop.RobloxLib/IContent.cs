using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace RobloxLib
{
	// Token: 0x02000005 RID: 5
	[TypeLibType(4288)]
	[Guid("CC40955B-B371-4516-A776-CF1236E0F2A5")]
	[ComImport]
	public interface IContent
	{
		// Token: 0x06000018 RID: 24
		[DispId(1)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		void Upload([MarshalAs(UnmanagedType.BStr)] [In] string url);
	}
}
