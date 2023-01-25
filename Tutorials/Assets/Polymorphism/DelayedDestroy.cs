using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//When attached, a GameBbject will destroy itself after a set time
public class DelayedDestroy : MonoBehaviour
{
    public static float duration = 3;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer > duration)
            Destroy(gameObject);
    }
}
