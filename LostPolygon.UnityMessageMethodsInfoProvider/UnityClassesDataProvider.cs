using System;
using System.Collections.Generic;
using System.Reflection;
using LostPolygon.UnityMessageMethodsInfoProvider.UnityEngineStubs;

namespace LostPolygon.UnityMessageMethodsInfoProvider {
    using MethodInfoDataDict = IReadOnlyDictionary<string, UnityMessageMethodInfoData>;

    public static class UnityClassesDataProvider {
        private static readonly Dictionary<string, MethodInfoDataDict> _unityClassesMessageMethods =
            new Dictionary<string, MethodInfoDataDict>();

        private static readonly Type[] _unityTypes = {
            typeof(IMonoBehaviour),
            typeof(IScriptableObject),

            typeof(IEditor),
            typeof(IEditorWindow),
            typeof(IScriptableWizard),
            typeof(IAssetPostprocessor),
            typeof(IAssetModificationProcessor),
            typeof(IAssetModificationProcessorDeprecated)
        };

        public static IReadOnlyDictionary<string, IReadOnlyDictionary<string, UnityMessageMethodInfoData>> UnityClassesMessageMethods =>
            _unityClassesMessageMethods;

        static UnityClassesDataProvider() {
            foreach (Type unityType in _unityTypes) {
                OriginalNameAttribute originalNameAttribute = unityType.GetCustomAttribute<OriginalNameAttribute>();
                string originalTypeName = originalNameAttribute.OriginalName;

                MethodInfo[] methods = GetInterfaceMethodsDeep(unityType);
                Dictionary<string, UnityMessageMethodInfoData> methodsMap = new Dictionary<string, UnityMessageMethodInfoData>(methods.Length);
                foreach (MethodInfo methodInfo in methods) {
                    DocumentationNameAttribute documentationNameAttribute = methodInfo.GetCustomAttribute<DocumentationNameAttribute>();
                    DescriptionAttribute descriptionAttribute = methodInfo.GetCustomAttribute<DescriptionAttribute>();
                    MinimalUnityVersionAttribute minimalUnityVersionAttribute = methodInfo.GetCustomAttribute<MinimalUnityVersionAttribute>();
                    IsStaticAttribute isStaticAttribute = methodInfo.GetCustomAttribute<IsStaticAttribute>();

                    string description = descriptionAttribute?.Description;
                    Version minimalVersion = minimalUnityVersionAttribute?.MinimalVersion;
                    bool isStatic = isStaticAttribute != null;

                    if (methodsMap.ContainsKey(methodInfo.Name))
                        continue;

                    methodsMap.Add(
                        methodInfo.Name,
                        new UnityMessageMethodInfoData(
                            methodInfo,
                            isStatic,
                            originalTypeName,
                            description,
                            documentationNameAttribute.FileName,
                            minimalVersion
                        )
                    );
                }

                _unityClassesMessageMethods.Add(originalTypeName, methodsMap);
            }
        }

        public static MethodInfoDataDict GetUnityClassMethods(string className) {
            _unityClassesMessageMethods.TryGetValue(className, out MethodInfoDataDict methodsData);
            return methodsData;
        }

        private static MethodInfo[] GetInterfaceMethodsDeep(Type interfaceType) {
            List<MethodInfo> methods = new List<MethodInfo>();
            methods.AddRange(interfaceType.GetRuntimeMethods());
            foreach (Type parentInterfaceType in interfaceType.GetInterfaces()) {
                methods.AddRange(GetInterfaceMethodsDeep(parentInterfaceType));
            }

            return methods.ToArray();
        }
    }
}
