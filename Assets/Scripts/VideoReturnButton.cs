using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class VideoReturnButton : MonoBehaviour
{
    public string returnScene = "Escena estudio";

    public void ReturnToStudy()
    {
        StartCoroutine(DoReturn());
    }

    private IEnumerator DoReturn()
    {
        AsyncOperation op = SceneManager.LoadSceneAsync(returnScene);

        if (op == null)
        {
            Debug.LogError("[VideoReturnButton] Error al cargar la escena: " + returnScene);
            yield break;
        }

        while (!op.isDone)
        {
            yield return null;
        }

        yield return null;
    }
}


