using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakablePole : MonoBehaviour
{
    public bool inTrigger;

    public GameObject wall;
 
    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
 
    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

     void Update()
    {
        if (inTrigger)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Destroy(this.gameObject);
                Destroy(wall);
            }
        }
    }

    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Press E to Break Weak Bar");
        }
    }
}
