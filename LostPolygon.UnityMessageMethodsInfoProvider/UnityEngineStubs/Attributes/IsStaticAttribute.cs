using System;

namespace LostPolygon.UnityMessageMethodsInfoProvider {
    [AttributeUsage(AttributeTargets.Method, Inherited = false)]
    internal sealed class IsStaticAttribute : Attribute {
    }
}
