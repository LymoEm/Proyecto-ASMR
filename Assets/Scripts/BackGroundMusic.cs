using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundMusic : MonoBehaviour
{
    //Lista de canciones de fondo
    public List<AudioClip> listamusicafondo;
    private AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        RandomMusic();

    }

    // Update is called once per frame
    void Update()
    {
        //Si se acaba, se reproduce una al azar
        if (audioSource.isPlaying == false)
        {
            RandomMusic();
        }
    }

    void RandomMusic()
    {
        int random = Random.Range(0, listamusicafondo.Count);
        audioSource.clip = listamusicafondo[random];
        audioSource.Play();
    }
}
