using UnityEngine;

public class IconoLibroAnimacion : MonoBehaviour
{
    public GameObject iconoLibro;  // Este �cono
    public Animator animLibro;     // Animator del objeto libreta

    void Start()
    {
        iconoLibro.SetActive(false); // Est� oculto hasta que lo active el script anterior
    }

    public void OnClickAnimar()
    {
        // Oculta el �cono
        iconoLibro.SetActive(false);

        // Reproduce la animaci�n
        animLibro.SetTrigger("PlayAnim");
    }
}
