namespace LostPolygon.UnityMessageMethodsInfoProvider.UnityEngineStubs {
    [OriginalName("UnityEditor.AssetModificationProcessor")]
    internal interface IAssetModificationProcessor {
        [Description("Called when Unity is about to create an asset not imported by the user, eg. \".meta\" files.")]
        [DocumentationName("AssetModificationProcessor.OnWillCreateAsset")]
        [MinimalUnityVersion("4.5")]
        [IsStatic]
        void OnWillCreateAsset(string path);

        [Description("Called when Unity is about to write serialized assets or scene files to disk.")]
        [DocumentationName("AssetModificationProcessor.OnWillSaveAssets")]
        [MinimalUnityVersion("4.5")]
        [IsStatic]
        string[] OnWillSaveAssets(string[] paths);

        [Description("Called when Unity is about to move an asset on disk.")]
        [DocumentationName("AssetModificationProcessor.OnWillMoveAsset")]
        [MinimalUnityVersion("4.5")]
        [IsStatic]
        AssetMoveResult OnWillMoveAsset(string oldPath, string newPath);

        [Description("Called when Unity is about to delete an asset from disk.")]
        [DocumentationName("AssetModificationProcessor.OnWillDeleteAsset")]
        [MinimalUnityVersion("4.5")]
        [IsStatic]
        AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions option);

        [Description("Called when inspecting an asset to determine if an editor should be disabled.")]
        [DocumentationName("AssetModificationProcessor.IsOpenForEdit")]
        [MinimalUnityVersion("4.5")]
        [IsStatic]
        bool IsOpenForEdit(string assetPath, out string message);
    }
}