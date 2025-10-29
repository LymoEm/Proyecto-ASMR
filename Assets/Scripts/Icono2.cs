using UnityEngine;

public class Icono2 : MonoBehaviour
{
    public GameObject icono2;  // Este ícono
    public Animator anim;     // Animator del objeto 
    public void OnMouseDown()
    {
        // Oculta el ícono
        icono2.SetActive(false);

        // Reproduce la animación
        anim.SetTrigger("PlayAnim");

        Debug.Log("prueba2");
    }
}