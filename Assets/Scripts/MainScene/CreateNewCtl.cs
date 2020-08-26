using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEditor;
using UnityEngine.SceneManagement;

public class CreateNewCtl : MonoBehaviour
{
    public InputField newProjectNameIn;
    private const string CREATOR_SCENE = "ProjCreatorScene";
    public void onNewBtnClick()
    {
        string projName = newProjectNameIn.text;
        createNewProject(projName);
    }

    private void createNewProject(string projName)
    {
        Debug.Log($"Main: creating new project with name: {projName}");
        SceneManager.LoadScene(CREATOR_SCENE);
        // Decomentar BuildPipeline. para reproducir error "InvalidOperationException"
        // BuildPipeline.BuildAssetBundles(@"C:\Users\jjoul\Documents\projects\UBP-Tec\Asset Bundle DLC PoC\AssetBundles", BuildAssetBundleOptions.ChunkBasedCompression, BuildTarget.StandaloneWindows64);
    }

}
