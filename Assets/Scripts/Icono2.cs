using UnityEngine;

public class Icono2 : MonoBehaviour
{
    public GameObject icono2;  // Este �cono
    public Animator anim;     // Animator del objeto 
    public void OnMouseDown()
    {
        // Oculta el �cono
        icono2.SetActive(false);

        // Reproduce la animaci�n
        anim.SetTrigger("PlayAnim");

        Debug.Log("prueba2");
    }
}