using System;
using System.Linq;
using System.Reflection;

namespace LostPolygon.UnityMessageMethodsInfoProvider {
    public class UnityMessageMethodInfoData {
        public string[] ParameterTypeNames { get; }
        public string FullName { get; }
        public string UIName { get; }

        public string Description { get; }
        public string DocumentationName { get; }
        public Version MinimalVersion { get; }
        public bool IsStatic { get; }

        public UnityMessageMethodInfoData(
            MethodInfo methodInfo,
            bool isStatic,
            string declaringType,
            string description,
            string documentationName,
            Version minimalVersion
            ) {
            ParameterTypeNames =
                methodInfo
                .GetParameters()
                .Select(GetParameterTypeFullName)
                .ToArray();
            FullName = declaringType + "." + methodInfo.Name;
            UIName = documentationName;

            Description = description;
            DocumentationName = documentationName;
            MinimalVersion = minimalVersion;
            IsStatic = isStatic;
        }

        private static string GetParameterTypeFullName(ParameterInfo parameterInfo) {
            bool isArray = parameterInfo.ParameterType.IsArray;
            Type elementType = isArray ? parameterInfo.ParameterType.GetElementType() : parameterInfo.ParameterType;
            OriginalNameAttribute originalTypeName = elementType.GetCustomAttribute<OriginalNameAttribute>();
            if (originalTypeName == null)
                return parameterInfo.ParameterType.FullName;

            string name = originalTypeName.OriginalName;
            if (isArray) {
                name += "[]";
            }

            return name;
        }
    }
}