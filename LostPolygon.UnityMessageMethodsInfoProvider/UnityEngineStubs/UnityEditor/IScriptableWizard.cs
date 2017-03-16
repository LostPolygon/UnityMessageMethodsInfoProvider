namespace LostPolygon.UnityMessageMethodsInfoProvider.UnityEngineStubs {
    [OriginalName("UnityEditor.ScriptableWizard")]
    internal interface IScriptableWizard : IEditorWindow {
        [Description("Called when the user clicks on the Create button.")]
        [DocumentationName("ScriptableWizard.OnWizardCreate")]
        [MinimalUnityVersion("4.5")]
        void OnWizardCreate();

        [Description("Called when the user clicks on the other button.")]
        [DocumentationName("ScriptableWizard.OnWizardOtherButton")]
        [MinimalUnityVersion("4.5")]
        void OnWizardOtherButton();

        [Description("Called when the wizard is opened or whenever the user changes something in the wizard.")]
        [DocumentationName("ScriptableWizard.OnWizardUpdate")]
        [MinimalUnityVersion("4.5")]
        void OnWizardUpdate();

        [Description("called for drawing contents when the ScriptableWizard needs to update its GUI.")]
        [DocumentationName("ScriptableWizard.DrawWizardGUI")]
        [MinimalUnityVersion("4.5")]
        void DrawWizardGUI();
    }
}