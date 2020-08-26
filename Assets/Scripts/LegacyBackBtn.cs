using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LegacyBackBtn : MonoBehaviour
{
    public void LoadScene(string sceneName)
    {
        Debug.Log("Este Boton si Sirve porque fue invocado con: " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
