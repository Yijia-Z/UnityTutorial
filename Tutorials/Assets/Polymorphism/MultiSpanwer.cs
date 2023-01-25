using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiSpanwer : AbstractEnemySpanwer
{
    void Start()
    {

    }

    void Update()
    {

    }

    //This extension of AbstractEnemySpanwer spawns three different prefabs
    public override void Spawn()
    {
        //see "SingleSpawner" for explanation of this
        GameObject g = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        g.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        g.transform.position = gameObject.transform.position;
        g.AddComponent<Rigidbody>();
        g.AddComponent<DelayedDestroy>();

        g = GameObject.CreatePrimitive(PrimitiveType.Cube);
        g.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        g.transform.position = gameObject.transform.position;
        g.AddComponent<Rigidbody>();
        g.AddComponent<DelayedDestroy>();

        g = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        g.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        g.transform.position = gameObject.transform.position;
        g.AddComponent<Rigidbody>();
        g.AddComponent<DelayedDestroy>();
    }
}
