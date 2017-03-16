using System;

namespace LostPolygon.UnityMessageMethodsInfoProvider {
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Method, Inherited = false)]
    internal sealed class DescriptionAttribute : Attribute {
        public string Description { get; }

        public DescriptionAttribute(string description) {
            Description = description;
        }
    }
}
