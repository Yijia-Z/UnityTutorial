using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When a player enters this trigger collider on attached game object, target GameObject active status is toggled
//isActive = false  -----> any scripts attached to it no longer run (included those that render it).
//isActive = true   -----> any scripts attached to it run again.


public class TrollPlatform : MonoBehaviour
{
    //The platform we want to make disappear when this trigger event happens
    public GameObject platform;

    // Start is called before the first frame update
    void Start()
    {
        //nothing to do, all parameters are set in the editor
    }

    // Update is called once per frame
    void Update()
    {
        //nothing to do, behavior is handled by OnTriggerEnter
    }


    //Similar to OnCollisionEnter, but with a collider set as a trigger.
    //No physics are applied to the collider so the player can pass through it freely, but events can trigger.
    private void OnTriggerEnter(Collider other)
    {
        GameObject obj = other.gameObject;
        Debug.Log(obj.name);

        if (obj.tag == "Player")
        {
            platform.active = !platform.active;
        }
    }

}
