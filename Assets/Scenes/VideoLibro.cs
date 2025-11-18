using UnityEngine;
using UnityEngine.SceneManagement;

public class VideoLibro : MonoBehaviour
{
    public string Libro;

    public void ChangeScene()
    {
        SceneManager.LoadScene(Libro);
    }
}
