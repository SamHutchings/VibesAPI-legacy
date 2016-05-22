﻿using FluentNHibernate.Automapping;
using System;

namespace Vibes.Core.Data
{
	public class VibesMappingConfiguration : DefaultAutomappingConfiguration
	{
		public override bool ShouldMap(Type type)
		{
			if (type.Namespace.StartsWith("Vibes.Domain"))
				return true;

			return false;
		}
	}
}