﻿using System;
using System.Linq;
using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Logging.Serilog;

namespace Korot
{
	class Program
	{
		// Initialization code. Don't use any Avalonia, third-party APIs or any
		// SynchronizationContext-reliant code before AppMain is called: things aren't initialized
		// yet and stuff might break.
		[STAThread]
		public static void Main(string[] args)
		{
			BuildKorot()
			// workaround for https://github.com/AvaloniaUI/Avalonia/issues/3533
			.With(new AvaloniaNativePlatformOptions { UseGpu = false })
			.StartWithClassicDesktopLifetime(args);
		}


		// Avalonia configuration, don't remove; also used by visual designer.
		public static AppBuilder BuildKorot()
			=> AppBuilder.Configure<App>()
				.UsePlatformDetect()
				.LogToDebug();
	}
}
