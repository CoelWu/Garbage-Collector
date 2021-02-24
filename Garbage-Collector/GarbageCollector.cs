using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

namespace Garbage_Collector
{
    public class GarbageCollector
    {
		[DllImport("kernel32.dll")]
		private static extern bool SetProcessWorkingSetSize(IntPtr proc, int min, int max);

		private void FlushMemory()
		{
			GC.Collect();
			GC.WaitForPendingFinalizers();
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1);
			}
		}

		public void StartCollecting(int sleepSpan = 30)
		{
			Task.Factory.StartNew(delegate ()
			{
				for (;;)
				{
					try
					{
						FlushMemory();
						Thread.Sleep(TimeSpan.FromSeconds((double)sleepSpan));
					}
					catch (Exception)
					{
					}
				}
			});
		}
	}
}
