using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System.Collections;

public class VideoCarta : MonoBehaviour
{
    public string Carta = "Carta";

    // Llama a este método desde un Animation Event
    public void ChangeScene()
    {
        StartCoroutine(LoadVideoScene());
    }

    private IEnumerator LoadVideoScene()
    {
        Debug.Log("[VideoCarta] Cambiando a escena: " + Carta);


        AsyncOperation load = SceneManager.LoadSceneAsync(Carta);

        if (load == null)
        {
            Debug.LogError("[VideoCarta] LoadSceneAsync devolvió NULL. Revisa que la escena esté en Build Settings.");
            yield break;
        }

        // Esperar a que termine la carga
        while (!load.isDone)
        {
            yield return null;
        }

        // Buscar VideoPlayer en la escena cargada
        VideoPlayer vp = FindObjectOfType<VideoPlayer>();
        if (vp == null)
        {
            Debug.LogError("[VideoCarta] No se encontró VideoPlayer en la escena " + Carta);
            yield break;
        }

        // Por si acaso, esperar un frame para que se dibuje correctamente
        yield return null;

        // Iniciar el video si no está reproduciéndose
        if (!vp.isPlaying)
            vp.Play();

        Debug.Log("[VideoCarta] Video iniciado correctamente.");
    }
}

