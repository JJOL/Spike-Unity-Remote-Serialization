using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System;
using UnityEngine.Networking;
using System.Collections.Generic;
using UnityEngine.Rendering;

public static class ButtonExtension
{
    public static void AddEventListener <T>(this Button button, T param, Action<T> OnClick)
    {
        button.onClick.AddListener(delegate
        {
            OnClick(param);
        });
    }
}

public class DLCSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public string url;

    [Header("UI DLC")]
    public Transform rootContainer;
    public Button prefab;
    public Text labelText;

    private static Dictionary<string, AssetBundle> assetBundlesMap = new Dictionary<string, AssetBundle>();

    IEnumerator Start()
    {
        if (!assetBundlesMap.ContainsKey(url))
        {
            using (UnityWebRequest req = UnityWebRequestAssetBundle.GetAssetBundle(url))
            {
                yield return req.Send();

                if (req.isNetworkError)
                {
                    Debug.LogError(req.error);
                }
                else
                {
                    assetBundlesMap[url] = ((DownloadHandlerAssetBundle)req.downloadHandler).assetBundle;
                }
            }
        }
        // Load Scenes Buttons
        AssetBundle assetBundle = assetBundlesMap[url];
        makeProjectButtons(assetBundle.GetAllScenePaths());
    }

    private void makeProjectButtons(string [] scenes)
    {
        foreach (string sceneName in scenes)
        {
            string prettySceneName = Path.GetFileNameWithoutExtension(sceneName);

            labelText.text = prettySceneName;
            var clone = Instantiate(prefab.gameObject) as GameObject;

            clone.GetComponent<Button>().AddEventListener(sceneName, GoToScene);

            clone.SetActive(true);
            clone.transform.SetParent(rootContainer);

        }
    }

    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Scene Switched");
    }

}
