namespace LostPolygon.UnityMessageMethodsInfoProvider.UnityEngineStubs {
    [OriginalName("UnityEditor.AssetPostprocessor")]
    internal interface IAssetPostprocessor {
        [Description("Called after importing of any number of assets is complete (when the Assets progress bar has reached the end).")]
        [DocumentationName("AssetPostprocessor.OnPostprocessAllAssets")]
        [MinimalUnityVersion("4.5")]
        [IsStatic]
        void OnPostprocessAllAssets(string[] importedAssets, string[] deletedAssets, string[] movedAssets, string[] movedFromAssetPaths);

        [Description("Feeds a source material.")]
        [DocumentationName("AssetPostprocessor.OnAssignMaterialModel")]
        [MinimalUnityVersion("4.5")]
        void OnAssignMaterialModel(Material material, Renderer renderer);

        [Description("Called when asset is assigned to a different asset bundle.")]
        [DocumentationName("AssetPostprocessor.OnPostprocessAssetbundleNameChanged")]
        [MinimalUnityVersion("4.5")]
        void OnPostprocessAssetbundleNameChanged(string assetPath, string previousAssetBundleName, string newAssetBundleName);

        [Description("Called before an audio clip is being imported.")]
        [DocumentationName("AssetPostprocessor.OnPreprocessAudio")]
        [MinimalUnityVersion("4.5")]
        void OnPreprocessAudio();

        [Description("Called when an audio clip has completed importing.")]
        [DocumentationName("AssetPostprocessor.OnPostprocessAudio")]
        [MinimalUnityVersion("4.5")]
        void OnPostprocessAudio(AudioClip audioClip);

        [Description("Called for each GameObject that had at least one user property attached to it in the imported file.")]
        [DocumentationName("AssetPostprocessor.OnPostprocessGameObjectWithUserProperties")]
        [MinimalUnityVersion("4.5")]
        void OnPostprocessGameObjectWithUserProperties(GameObject gameObject, string[] propNames, object[] values);

        [Description("Called before animation from a model (.fbx, .mb file etc.) is imported.")]
        [DocumentationName("AssetPostprocessor.OnPreprocessAnimation")]
        [MinimalUnityVersion("4.5")]
        void OnPreprocessAnimation();

        [Description("Called before a model (.fbx, .mb file etc.) is imported.")]
        [DocumentationName("AssetPostprocessor.OnPreprocessModel")]
        [MinimalUnityVersion("4.5")]
        void OnPreprocessModel();

        [Description("Called when a model has completed importing.")]
        [DocumentationName("AssetPostprocessor.OnPostprocessModel")]
        [MinimalUnityVersion("4.5")]
        void OnPostprocessModel(GameObject modelGameObject);

        [Description("Called just before the texture importer is run.")]
        [DocumentationName("AssetPostprocessor.OnPreprocessTexture")]
        [MinimalUnityVersion("4.5")]
        void OnPreprocessTexture();

        [Description("Called after a texture has completed importing.")]
        [DocumentationName("AssetPostprocessor.OnPostprocessTexture")]
        [MinimalUnityVersion("4.5")]
        void OnPostprocessTexture(Texture2D texture);

        [Description("Called during the texture import after sprites are created.")]
        [DocumentationName("AssetPostprocessor.OnPostprocessSprites")]
        [MinimalUnityVersion("5.0")]
        void OnPostprocessSprites(Texture2D texture, Sprite[] sprites);

        [Description("Called when a SpeedTree asset (.spm file) has completed importing.")]
        [DocumentationName("AssetPostprocessor.OnPostprocessSpeedTree")]
        [MinimalUnityVersion("5.0")]
        void OnPostprocessSpeedTree(GameObject speedTreeGameObject);

        [Description("Called before a SpeedTree asset (.spm file) is imported.")]
        [DocumentationName("AssetPostprocessor.OnPreprocessSpeedTree")]
        [MinimalUnityVersion("5.0")]
        void OnPreprocessSpeedTree();
    }
}