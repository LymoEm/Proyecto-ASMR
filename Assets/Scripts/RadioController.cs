using UnityEngine;

public class RadioController : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource radioAudioSource;
    public AudioClip[] canciones;   // Lista de canciones disponibles

    private bool estabaPausada = false;

    void Start()
    {
        if (radioAudioSource == null)
        {
            Debug.LogError("Error: Asigna el AudioSource de la radio al script RadioController.");
        }

        if (canciones.Length == 0)
        {
            Debug.LogWarning("Advertencia: No hay canciones asignadas en la lista.");
        }
    }

    // ---------------------------------------------------------------
    // MÉTODO PARA PAUSAR LA RADIO
    // ---------------------------------------------------------------
    public void PauseRadio()
    {
        if (radioAudioSource != null && radioAudioSource.isPlaying)
        {
            radioAudioSource.Pause();
            estabaPausada = true;
            Debug.Log("Radio pausada.");
        }
    }

    // ---------------------------------------------------------------
    // REANUDAR EN UN PUNTO ALEATORIO
    // ---------------------------------------------------------------
    public void ResumeRadio()
    {
        if (radioAudioSource != null && estabaPausada)
        {
            if (radioAudioSource.clip != null)
            {
                // Asignar un punto aleatorio dentro de la canción
                radioAudioSource.time = Random.Range(0f, radioAudioSource.clip.length);
            }

            radioAudioSource.UnPause();
            estabaPausada = false;
            Debug.Log("Radio reanudada en un punto aleatorio.");
        }
    }

    // ---------------------------------------------------------------
    // CAMBIAR A OTRA CANCIÓN ALEATORIA
    // ---------------------------------------------------------------
    public void CambiarCancionAleatoria()
    {
        if (canciones.Length == 0 || radioAudioSource == null)
        {
            Debug.LogWarning("No hay canciones disponibles o falta el AudioSource.");
            return;
        }

        // Seleccionar una canción distinta a la actual
        AudioClip nueva;
        do
        {
            nueva = canciones[Random.Range(0, canciones.Length)];
        }
        while (nueva == radioAudioSource.clip && canciones.Length > 1);

        radioAudioSource.clip = nueva;
        radioAudioSource.time = 0f; // Opcional: iniciar desde el inicio
        radioAudioSource.Play();

        Debug.Log("Cambiando a canción aleatoria: " + nueva.name);
    }
}
