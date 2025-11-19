using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float Speed = 10f;
    public Vector3 offset = new(-35f, 20f, 7f); //Respecto al objeto a cuanto está 
    private bool cameraZoom = false;
    public bool cameraReset = false;

    private Transform target;

    //Para guardar la posicion inicial de la camara
    private Vector3 startPosition;
    private Quaternion startRotation;


    // Start is called before the first frame update
    void Start()
    {
        //offset = new(-35f, 20f, 7f);
        startPosition = transform.position;
        startRotation = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        if (cameraZoom == true && target != null)
        {
            cameraReset = false;
            Zoom();
        }
        else if(cameraReset == true)
        {
            ResetPosition();
        }
    }

    public void setZoom(Transform actualTarget, bool z)
    {
        target = actualTarget;
        cameraZoom = z;
    }

    public void Zoom()
    {
        Vector3 NewPosition = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, NewPosition, Time.deltaTime * Speed);

        //Quaternion NewRotation = Quaternion.LookRotation(target.position - transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, NewRotation, Time.deltaTime * Speed);
    }

    public void ResetPosition()
    {
        Speed = 2f;
        transform.position = Vector3.Lerp(transform.position, startPosition, Time.deltaTime * Speed);
        transform.rotation = Quaternion.Slerp(transform.rotation, startRotation, Time.deltaTime * Speed);
    }
}
