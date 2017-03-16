using System;

namespace LostPolygon.UnityMessageMethodsInfoProvider {
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Method, Inherited = false)]
    internal sealed class MinimalUnityVersionAttribute : Attribute {
        public Version MinimalVersion { get; }

        public MinimalUnityVersionAttribute(Version minimalVersion) {
            MinimalVersion = minimalVersion;
        }

        public MinimalUnityVersionAttribute(string minimalVersion) {
            MinimalVersion = new Version(minimalVersion);
        }
    }
}
