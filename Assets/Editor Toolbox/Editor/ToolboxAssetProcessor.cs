﻿using UnityEditor;

namespace Toolbox.Editor
{
    public class ToolboxAssetProcessor : UnityEditor.AssetModificationProcessor
    {
        private static AssetDeleteResult OnWillDeleteAsset(string assetPath, RemoveAssetOptions options)
        {
            if (ToolboxManager.Settings)
            {
                if (ToolboxManager.SettingsGuid == AssetDatabase.AssetPathToGUID(assetPath))
                {
                    ToolboxManager.InitializeSettings((string)null);
                }
            }

            return AssetDeleteResult.DidNotDelete;
        }
    }
}