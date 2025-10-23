using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if(ChosenScene.selected == "Escena estudio")
        {
            GetComponent<TMP_Text>().text = "Estudio acogedor";
        }
        else if(ChosenScene.selected == "Escena picnic")
        {
            GetComponent<TMP_Text>().text = "Picnic";
        }

       
    }

}
