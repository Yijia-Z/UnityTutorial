using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This class inherits from AbstractEnemySpanwer, it also gets MonoBehavior properties and methods
public class SingleSpawner : AbstractEnemySpanwer
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //here, we override Spawn to just make a single game object
    public override void Spawn()
    {
        //creates a sphere primitive
        //If we had a reference to some premade gameobject we wanted to copy, we could do:
        //GameObject g = GameObject.Instatiate(reference_gameobject);
        GameObject g = GameObject.CreatePrimitive(PrimitiveType.Sphere);

        //set scale and position
        g.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        g.transform.position = gameObject.transform.position;

        //add components not default to the primitive
        g.AddComponent<Rigidbody>();
        g.AddComponent<DelayedDestroy>();
    }
}
