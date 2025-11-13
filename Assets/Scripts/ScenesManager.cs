using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    //Para bienvenida
    public void LoadSceneSelected()
    {
        SceneManager.LoadScene(ChosenScene.selected);
    }

    //Para inicio
    public void ChosenScenes(string name)
    {
        ChosenScene.selected = name;
        SceneManager.LoadScene("seleccion estudio");
    }


}
