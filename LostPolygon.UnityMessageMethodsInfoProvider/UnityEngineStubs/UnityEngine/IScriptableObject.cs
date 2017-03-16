namespace LostPolygon.UnityMessageMethodsInfoProvider.UnityEngineStubs {
    [OriginalName("UnityEngine.ScriptableObject")]
    internal interface IScriptableObject {
        [Description("Called when the scriptable object will be destroyed.")]
        [DocumentationName("ScriptableObject.OnDestroy")]
        [MinimalUnityVersion("4.5")]
        void OnDestroy();

        [Description("Called when the scriptable object goes out of scope.")]
        [DocumentationName("ScriptableObject.OnDisable")]
        [MinimalUnityVersion("4.5")]
        void OnDisable();

        [Description("Called when the scriptable object is loaded.")]
        [DocumentationName("ScriptableObject.OnEnable")]
        [MinimalUnityVersion("4.5")]
        void OnEnable();
    }
}
