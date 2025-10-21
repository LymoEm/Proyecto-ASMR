using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{

    public static string ChosenScene;
    public void LoadScenes(string name)
    {
        ChosenScene = name;
        SceneManager.LoadScene(name);
    }
}
