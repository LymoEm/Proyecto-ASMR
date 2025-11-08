using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Icono2 : MonoBehaviour
{
    public AnimationManager anim;
    public GameObject icono2;  // Este ícono

    void Start()
    {
    }

    public void OnMouseDown()
    {
        anim.startAnimation = true;

        Debug.Log("Bandera2");

        icono2.SetActive(false);

    }
  
}