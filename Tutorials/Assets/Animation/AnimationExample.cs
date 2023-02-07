using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationExample : MonoBehaviour
{
    Animator anim;
    bool crouch = false;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            anim.SetTrigger("Walking");
        }
        if (Input.GetKeyUp(KeyCode.V))
        {
            anim.SetTrigger("Stop");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            crouch = !crouch;
            if(crouch)
                anim.SetTrigger("Crouch");
            else
                anim.SetTrigger("Uncrouch");
        }

    }
}
