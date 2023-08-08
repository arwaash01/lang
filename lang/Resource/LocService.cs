﻿using Microsoft.Extensions.Localization;
using System.Reflection;

namespace lang.Resource
{
    public class LocService
    {
        private readonly IStringLocalizer _localizer;
        public LocService(IStringLocalizerFactory factory)
        {
            var type = typeof(SharedResource);
            var assemblyName = new AssemblyName(type.GetTypeInfo().Assembly.FullName);
            _localizer = factory.Create("sharedResource", assemblyName.Name);
        }
        public LocalizedString Loc(String key)
        {
            return _localizer[key];
        }
    }
}
