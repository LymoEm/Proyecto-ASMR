using UnityEngine;

public class Icono2 : MonoBehaviour
{
    public GameObject icono2;  // Este ícono
    public Animator anim;     // Animator del objeto
    public string animationDefault = "Default";
    AnimatorStateInfo infoAnim;

    public void OnMouseDown()
    {
        // Oculta el ícono
        icono2.SetActive(false);

        // Reproduce la animación
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