using UnityEngine;

public class IconoLibroAnimacion : MonoBehaviour
{
    public GameObject iconoLibro;  // Este ícono
    public Animator animLibro;     // Animator del objeto libreta

    void Start()
    {
        iconoLibro.SetActive(false); // Está oculto hasta que lo active el script anterior
    }

    public void OnClickAnimar()
    {
        // Oculta el ícono
        iconoLibro.SetActive(false);

        // Reproduce la animación
        animLibro.SetTrigger("PlayAnim");
    }
}
