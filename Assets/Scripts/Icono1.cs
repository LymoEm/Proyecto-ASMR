using UnityEngine;
using UnityEngine.UI;

public class Icono1 : MonoBehaviour
{
    public CameraMove cameraMove;

    public Transform target;   //Asigna el objeto del Hierarchy
    public GameObject iconoActual;  //Este mismo �cono (icono 1)
    public GameObject icono2;   //El �cono que aparecer� despu�s

    void Start()
    {
        // Asegura que el �cono est� visible apenas inicia la escena
        iconoActual.SetActive(true);
        icono2.SetActive(false);

    }

    void Update()
    {
       
    }

    public void OnMouseDown()
    {

        Debug.Log("Bandera1");

        Debug.Log(target);

        cameraMove.setZoom(target);

        //Activa el siguiente �cono
        icono2.SetActive(true);

        //Desactiva este �cono
        iconoActual.SetActive(false);

        // Nueva posici�n
        //mainCamera.transform.position = new Vector3(-13.3f, 253.5f, 254.3f);

        // Nueva rotaci�n (en �ngulos Euler)
        //mainCamera.transform.rotation = Quaternion.Euler(78.34f, -147.327f, 123.95f);

        // 3. Mueve la c�mara hacia el libro (seguimiento simple)
        //mainCamera.transform.position = new Vector3(
        //  targetLibro.position.x + 2f,
        // targetLibro.position.y + 1.5f,
        //targetLibro.position.z + 2f
        //);
    }
}

