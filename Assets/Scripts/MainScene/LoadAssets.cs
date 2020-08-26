using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadAssets : MonoBehaviour
{
    static bool loaded = false;
    static AssetBundle anAsset;


    public void loadAnAsset(string assetUrl)
    {
        if (!loaded)
        {
            anAsset = AssetBundle.LoadFromFile(assetUrl);
            loaded = true;
        }
        
        string sceneName = anAsset.GetAllScenePaths()[0];
        Debug.Log(sceneName);

        SceneManager.LoadScene(sceneName);
        //anAsset.LoadAsset(sceneName)
    }

}
