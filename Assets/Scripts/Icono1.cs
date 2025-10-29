using UnityEngine;
using UnityEngine.UI;

public class Icono1 : MonoBehaviour
{
    public Camera mainCamera;       //Main Camera desde el Inspector
    public Transform target;   //Asigna el objeto del Hierarchy
    public GameObject iconoActual;  //Este mismo ícono (icono 1)
    public GameObject icono2;   //El ícono que aparecerá después

    void Start()
    {
        // Asegura que el ícono esté visible apenas inicia la escena
        iconoActual.SetActive(true);
        icono2.SetActive(false);
    }

    public void OnMouseDown()
    {

        Debug.Log("Bandera1");

        //Desactiva este ícono
        iconoActual.SetActive(false);

        //Activa el siguiente ícono
        icono2.SetActive(true);

        // Nueva posición
        //mainCamera.transform.position = new Vector3(-13.3f, 253.5f, 254.3f);

        // Nueva rotación (en ángulos Euler)
        //mainCamera.transform.rotation = Quaternion.Euler(78.34f, -147.327f, 123.95f);

        // 3. Mueve la cámara hacia el libro (seguimiento simple)
        //mainCamera.transform.position = new Vector3(
        //  targetLibro.position.x + 2f,
        // targetLibro.position.y + 1.5f,
        //targetLibro.position.z + 2f
        //);

        mainCamera.transform.LookAt(target);
    }
}

