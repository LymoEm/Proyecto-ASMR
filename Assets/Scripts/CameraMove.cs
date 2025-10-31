using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float Speed = 10f;
    public Vector3 offset; //Respecto al objeto a cuanto está 
    private bool cameraZoom = false;

    private Transform target;

    //Para guardar la posicion inicial de la camara
    private Vector3 startPosition;
    private Quaternion startRotation;


    // Start is called before the first frame update
    void Start()
    {
        offset = new(-35, 20f, 7f);
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraZoom == true && target != null)
        {
            Zoom();
        }
    }

    public void setZoom(Transform actualTarget)
    {
        target = actualTarget;
        cameraZoom = true;
    }

    public void Zoom()
    {
        Vector3 NewPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, NewPosition, Time.deltaTime * Speed);

        Quaternion NewRotation = Quaternion.LookRotation(target.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, NewRotation, Time.deltaTime * Speed);
    }

    public void resetPosition()
    {

    }
}
