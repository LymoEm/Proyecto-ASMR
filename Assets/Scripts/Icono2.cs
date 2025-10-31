using UnityEngine;

public class Icono2 : MonoBehaviour
{
    public GameObject icono2;  // Este �cono
    public Animator anim;     // Animator del objeto
    public string animationDefault = "Default";
    AnimatorStateInfo infoAnim;

    public void OnMouseDown()
    {
        // Oculta el �cono
        icono2.SetActive(false);

        // Reproduce la animaci�n
        anim.SetTrigger("PlayAnim");

        Debug.Log("Bandera2");

        infoAnim = anim.GetCurrentAnimatorStateInfo(0);
        if (infoAnim.IsName(animationDefault))
        {
            restartCameraPosition();

        }

    }

    public void restartCameraPosition()
    {


    }
}