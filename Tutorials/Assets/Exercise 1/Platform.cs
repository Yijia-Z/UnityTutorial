using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public float distance;
    public float timer;

    Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        //Q1.1) What would happen if we didnt save this? (see Q1.2)
        start = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Q1.2) Why would we add start?
        gameObject.transform.position = start + new Vector3(distance * Mathf.Cos(timer*speed), 0, 0);
        timer += Time.deltaTime ;
    }
}
