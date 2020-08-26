using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class BundleBuilder : Editor
{
   [MenuItem("Assets/Build AssetBundles")]
   public static void buildAllAssetBundles()
    {
        BuildPipeline.BuildAssetBundles(@"C:\Users\jjoul\Documents\projects\UBP-Tec\Asset Bundle DLC PoC\AssetBundles", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }
}
