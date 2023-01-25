using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This script manages all the spanwers, and tells them all to spawn after a delay.
public class SpanwerController : MonoBehaviour
{
    //We have a list of all spanwers implementing the AbstractEnemySpawner class.
    //These references are assigned in the editor
    public List<AbstractEnemySpanwer> spawners = new List<AbstractEnemySpanwer>();


    public float delay = 3.0f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // After every delay time, we call Spawn() for every spawner in the list
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= delay)
        {
            timer = 0;
            foreach(AbstractEnemySpanwer s in spawners)
            {
                s.Spawn();
            }
        }
    }
}
