using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTitle : MonoBehaviour
{
    public GameObject iconosEstudio;
    public GameObject iconosPicnic;

    // Start is called before the first frame update
    void Start()
    {
        if(ChosenScene.selected == "Escena estudio")
        {
            GetComponent<TMP_Text>().text = "Estudio acogedor";
            iconosEstudio.SetActive(true);
            iconosPicnic.SetActive(false);
        }
        else if(ChosenScene.selected == "Escena picnic")
        {
            GetComponent<TMP_Text>().text = "Picnic";
            iconosEstudio.SetActive(false);
            iconosPicnic.SetActive(true);
        }

       
    }

}
