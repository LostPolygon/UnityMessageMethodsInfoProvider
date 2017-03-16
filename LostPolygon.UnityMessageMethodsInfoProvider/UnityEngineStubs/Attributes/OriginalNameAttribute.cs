using System;

namespace LostPolygon.UnityMessageMethodsInfoProvider {
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Enum | AttributeTargets.Class, Inherited = false)]
    internal sealed class OriginalNameAttribute : Attribute {
        public string OriginalName { get; }

        public OriginalNameAttribute(string originalName) {
            OriginalName = originalName;
        }
    }
}
