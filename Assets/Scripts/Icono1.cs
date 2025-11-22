using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class Icono1 : MonoBehaviour, IPointerClickHandler
{
    public CameraMove cameraMove;

    public Transform target;   //Asigna el objeto del Hierarchy
    public GameObject iconoActual;  //Este mismo ícono (icono 1)
    public GameObject icono2;   //El ícono que aparecerá después

    void Start()
    {
        activeicon();
    }

    void Update()
    {
       
    }
    public void activeicon()
    {
        // Asegura que el ícono esté visible apenas inicia la escena
        iconoActual.SetActive(true);

        icono2.SetActive(false);
    }
    //public void OnMouseDown()
    //{

    //    Debug.Log("Bandera1");

    //    Debug.Log(target);

    //    cameraMove.setZoom(target, true);

    //    //Activa el siguiente ícono
    //    icono2.SetActive(true);

    //    //Desactiva este ícono
    //    iconoActual.SetActive(false);
    //}

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Debug.Log("Bandera1");

        Debug.Log(target);

        cameraMove.setZoom(target, true);

        //Activa el siguiente ícono
        icono2.SetActive(true);

        //Desactiva este ícono
        iconoActual.SetActive(false);
    }

}

