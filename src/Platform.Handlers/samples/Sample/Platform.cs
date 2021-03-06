﻿using Xamarin.Platform.Handlers;
using RegistrarHandlers = Xamarin.Platform.Registrar;

namespace Sample
{
	public class Platform
	{
		static bool HasInit;

		public static void Init()
		{
			if (HasInit)
				return;

			HasInit = true;

			//RegistrarHandlers.Handlers.Register<Layout, LayoutHandler>();

			RegistrarHandlers.Handlers.Register<Button, ButtonHandler>();
			//RegistrarHandlers.Handlers.Register<Entry, EntryHandler>();
			//RegistrarHandlers.Handlers.Register<Label, LabelHandler>();
		}
	}
}