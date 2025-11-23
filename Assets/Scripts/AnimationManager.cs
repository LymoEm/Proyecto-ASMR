using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEditor;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator anim;     // Animator del objeto
    public string currentAnimation;

    public AudioManager audioManager;

    public Icono1 icono1;
    public CameraMove cameraMove;

    public bool isAnimating = false;
    public bool startAnimation = false;


    void Start()
    {
        audioManager = GetComponent<AudioManager>();

        anim = GetComponent<Animator>();
        if (anim == null)
        {
            Debug.Log("falta animator");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (isAnimating)
        {
            return;
        }
        else if(startAnimation)
        {
            StartCoroutine(TriggerAnimation());
        }
    }

    public IEnumerator TriggerAnimation()
    {
        startAnimation = false;
        isAnimating = true;

        // Reproduce la animación

        anim.SetTrigger("PlayAnim");

        yield return StartCoroutine(WaitForAnimation());

    }

    private IEnumerator WaitForAnimation()
    {
        yield return null;

        while (anim.GetCurrentAnimatorStateInfo(0).IsName("Default"))
        {
            Debug.Log("here");
            yield return null;
        }

        audioManager.clickToPlaySound = true;

        while (anim.GetCurrentAnimatorStateInfo(0).IsName(currentAnimation))
        {
            Debug.Log("Entre");
            yield return null;
        }

        Debug.Log("Sali");
        cameraMove.setZoom(null, false);
        audioManager.clickToPauseSound = true;
        cameraMove.cameraReset = true;
        isAnimating = false;
        icono1.activeicon();

        yield return null;
    }
}


