using UnityEngine;

public class RadioController : MonoBehaviour
{

    public AudioSource radioAudioSource;

    void Start()
    {

        if (radioAudioSource == null)
        {
            Debug.LogError("Error: Asigna el AudioSource de la radio al script RadioController.");
        }

    }

    // Método para ser llamado cuando OTRA animación COMIENZA
    public void PauseRadio()
    {
        if (radioAudioSource != null && radioAudioSource.isPlaying)
        {
            radioAudioSource.Pause();
            Debug.Log("Radio pausada debido a la interacción/animación.");
        }
    }

    // Método para ser llamado cuando OTRA animación TERMINA
    public void ResumeRadio()
    {
        if (radioAudioSource != null && !radioAudioSource.isPlaying)
        {
            // Solo reanuda si no estaba en pausa por alguna otra razón
            radioAudioSource.UnPause();
            Debug.Log("Radio reanudada después de la interacción/animación.");
        }
    }
}