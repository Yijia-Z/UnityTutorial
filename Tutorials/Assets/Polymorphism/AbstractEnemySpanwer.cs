using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//An abstract class for "Spanwer" type behaivors
//Nothing in start/update
//"virtual" public classes mean a child class has to implement it.
//In this case, what happens with a "spawn" event occurs.
public class AbstractEnemySpanwer : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
        
    }

    // Update is called once per frame
    public void Update()
    {
        
    }

    public virtual void Spawn() { }
    
}
