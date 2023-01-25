using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSpawner : AbstractEnemySpanwer
{
    public GameObject reference;
    public bool destroy = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Spawn()
    {
        GameObject g = GameObject.Instantiate(reference);
        g.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        g.transform.position = gameObject.transform.position;
        g.AddComponent<Rigidbody>();
        if(destroy)
            g.AddComponent<DelayedDestroy>();
    }
}
