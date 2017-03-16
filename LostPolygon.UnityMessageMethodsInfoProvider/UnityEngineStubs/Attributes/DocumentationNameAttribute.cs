using System;

namespace LostPolygon.UnityMessageMethodsInfoProvider {
    [AttributeUsage(AttributeTargets.Interface | AttributeTargets.Method, Inherited = false)]
    internal sealed class DocumentationNameAttribute : Attribute {
        public string FileName { get; }

        public DocumentationNameAttribute(string fileName) {
            FileName = fileName;
        }
    }
}
