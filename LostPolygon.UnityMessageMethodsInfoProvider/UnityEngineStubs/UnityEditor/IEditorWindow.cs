namespace LostPolygon.UnityMessageMethodsInfoProvider.UnityEngineStubs {
    [OriginalName("UnityEditor.EditorWindow")]
    internal interface IEditorWindow : IScriptableObject {
        [Description("Called when the EditorWindow is closed.")]
        [DocumentationName("EditorWindow.OnDestroy")]
        [MinimalUnityVersion("4.5")]
        new void OnDestroy();

        [Description("Called when the window gets keyboard focus.")]
        [DocumentationName("EditorWindow.OnFocus")]
        [MinimalUnityVersion("4.5")]
        void OnFocus();

        [Description("Called for rendering and handling GUI events. Implement your own editor GUI here.")]
        [DocumentationName("EditorWindow.OnGUI")]
        [MinimalUnityVersion("4.5")]
        void OnGUI();

        [Description("Called whenever the scene hierarchy has changed.")]
        [DocumentationName("EditorWindow.OnHierarchyChange")]
        [MinimalUnityVersion("4.5")]
        void OnHierarchyChange();

        [Description("Called at 10 frames per second to give the inspector a chance to update.")]
        [DocumentationName("EditorWindow.OnInspectorUpdate")]
        [MinimalUnityVersion("4.5")]
        void OnInspectorUpdate();

        [Description("Called when the window loses keyboard focus.")]
        [DocumentationName("EditorWindow.OnLostFocus")]
        [MinimalUnityVersion("4.5")]
        void OnLostFocus();

        [Description("Called whenever the project has changed.")]
        [DocumentationName("EditorWindow.OnProjectChange")]
        [MinimalUnityVersion("4.5")]
        void OnProjectChange();

        [Description("Called whenever the selection has changed.")]
        [DocumentationName("EditorWindow.OnSelectionChange")]
        [MinimalUnityVersion("4.5")]
        void OnSelectionChange();

        [Description("Called 100 times per second on all visible windows.")]
        [DocumentationName("EditorWindow.Update")]
        [MinimalUnityVersion("4.5")]
        void Update();
    }
}