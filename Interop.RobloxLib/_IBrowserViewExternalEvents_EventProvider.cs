using System;
using System.Collections;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Threading;

namespace RobloxLib
{
	// Token: 0x02000014 RID: 20
	internal sealed class _IBrowserViewExternalEvents_EventProvider : _IBrowserViewExternalEvents_Event, IDisposable
	{
		// Token: 0x06000035 RID: 53 RVA: 0x00002074 File Offset: 0x00000274
		private void Init()
		{
			IConnectionPoint connectionPoint = null;
			Guid guid = new Guid(new byte[]
			{
				173,
				36,
				249,
				156,
				229,
				29,
				107,
				68,
				130,
				163,
				177,
				16,
				41,
				157,
				83,
				161
			});
			this.m_ConnectionPointContainer.FindConnectionPoint(ref guid, out connectionPoint);
			this.m_ConnectionPoint = (IConnectionPoint)connectionPoint;
			this.m_aEventSinkHelpers = new ArrayList();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002188 File Offset: 0x00000388
		public _IBrowserViewExternalEvents_EventProvider(object A_1)
		{
			this.m_ConnectionPointContainer = (IConnectionPointContainer)A_1;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000021B0 File Offset: 0x000003B0
		public override void Finalize()
		{
			try
			{
				bool flag;
				Monitor.Enter(this, ref flag);
				if (this.m_ConnectionPoint != null)
				{
					int count = this.m_aEventSinkHelpers.Count;
					int num = 0;
					if (0 < count)
					{
						do
						{
							_IBrowserViewExternalEvents_SinkHelper ibrowserViewExternalEvents_SinkHelper = (_IBrowserViewExternalEvents_SinkHelper)this.m_aEventSinkHelpers[num];
							this.m_ConnectionPoint.Unadvise(ibrowserViewExternalEvents_SinkHelper.m_dwCookie);
							num++;
						}
						while (num < count);
					}
					Marshal.ReleaseComObject(this.m_ConnectionPoint);
				}
			}
			catch (Exception)
			{
			}
			finally
			{
				bool flag;
				if (flag)
				{
					Monitor.Exit(this);
				}
			}
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00002278 File Offset: 0x00000478
		public void Dispose()
		{
			this.Finalize();
			GC.SuppressFinalize(this);
		}

		// Token: 0x04000002 RID: 2
		private IConnectionPointContainer m_ConnectionPointContainer;

		// Token: 0x04000003 RID: 3
		private ArrayList m_aEventSinkHelpers;

		// Token: 0x04000004 RID: 4
		private IConnectionPoint m_ConnectionPoint;
	}
}
