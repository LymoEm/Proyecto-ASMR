using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System.Collections;

public class VideoLibro : MonoBehaviour
{
    public string Libro = "Libro"; // Nombre real de la escena del video

    // Llama a este método desde un Animation Event
    public void ChangeScene()
    {
        StartCoroutine(LoadVideoScene());
    }

    private IEnumerator LoadVideoScene()
    {
        Debug.Log("[VideoLibro] Cambiando a escena: " + Libro);

        // Cargar escena asíncrona (sin fade)
        AsyncOperation load = SceneManager.LoadSceneAsync(Libro);

        if (load == null)
        {
            Debug.LogError("[VideoLibro] LoadSceneAsync devolvió NULL. Revisa que la escena esté en Build Settings.");
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
            Debug.LogError("[VideoLibro] No se encontró VideoPlayer en la escena " + Libro);
            yield break;
        }

        // Por si acaso, esperar un frame para que se dibuje correctamente
        yield return null;

        // Iniciar el video si no está reproduciéndose
        if (!vp.isPlaying)
            vp.Play();

        Debug.Log("[VideoLibro] Video iniciado correctamente.");
    }
}
