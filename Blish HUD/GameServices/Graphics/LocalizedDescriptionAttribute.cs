using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Resources;

namespace Blish_HUD.Graphics {
    [AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
    public class LocalizedDescriptionAttribute : DescriptionAttribute {
        private readonly string _resourceKey;

        private static readonly Dictionary<string, Type> ModuleMapping = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase) {
            { "FramerateLimiter", typeof(Strings.GameServices.GraphicsService) },
            { "DPIScaling",       typeof(Strings.GameServices.GraphicsService) },
            { "UIScaling",        typeof(Strings.GameServices.GraphicsService) },
            { "DynamicHUD",       typeof(Strings.GameServices.OverlayService) },
        };

        public LocalizedDescriptionAttribute(string resourceKey) {
            _resourceKey = resourceKey;
        }

        public override string Description {
            get {
                try {
                    Type targetServiceType = typeof(Strings.GameServices.OverlayService);

                    string[] parts = _resourceKey.Split('_');

                    if (parts.Length > 1) {
                        string moduleKey = parts[1];

                        if (ModuleMapping.TryGetValue(moduleKey, out var mappedType)) {
                            targetServiceType = mappedType;
                        }
                    }

                    var resourceManagerProp = targetServiceType.GetProperty("ResourceManager", BindingFlags.NonPublic | BindingFlags.Static);

                    if (resourceManagerProp != null && resourceManagerProp.GetValue(null) is ResourceManager resourceManager) {
                        var localizedString = resourceManager.GetString(_resourceKey);
                        return localizedString ?? _resourceKey;
                    }
                } catch {
                }

                return _resourceKey;
            }
        }
    }
}
