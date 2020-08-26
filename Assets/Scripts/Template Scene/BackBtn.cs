using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackBtn : MonoBehaviour
{
    private const string MAIN_SCENE = "MainScene";
    public void onBackBtnClick()
    {
        Debug.Log("Closing project {projectName} and returning to main");
        SceneManager.LoadScene(MAIN_SCENE);
    }
}
