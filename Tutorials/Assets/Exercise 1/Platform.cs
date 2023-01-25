using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public float distance;
    public float timer;
    public float direction;//in degrees
    private float x;
    private float z;

    Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        //Q1.1) What would happen if we didnt save this? (see Q1.2)
        //platforms don't start at designated location
        start = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Q1.2) Why would we add start?
        //to define a relative transform
        x= Mathf.Cos(direction * Mathf.PI / 180) * distance;
        z= Mathf.Sin(direction * Mathf.PI / 180) * distance;
        gameObject.transform.position = start + new Vector3(x * Mathf.Cos(timer*speed), 0, z * Mathf.Cos(timer*speed));
        timer += Time.deltaTime ;
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject obj = collision.gameObject;
        if (obj.tag == "Player")
            obj.transform.SetParent(this.transform);
    }
    void OnCollisionExit(Collision collision)
    {
        GameObject obj = collision.gameObject;
            obj.transform.SetParent(null);
    }
}
