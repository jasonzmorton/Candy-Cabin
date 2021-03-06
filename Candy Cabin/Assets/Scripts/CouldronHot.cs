using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CouldronHot : MonoBehaviour
{
    public bool inTrigger;

    void OnTriggerEnter(Collider other)
    {
        inTrigger = true;
    }
 
    void OnTriggerExit(Collider other)
    {
        inTrigger = false;
    }

    void OnGUI()
    {
        if(inTrigger && !ObstaclePush.hasGlove)
        {
            GUI.Box(new Rect(0, 60, 400, 25), "Ouch! The cauldron is too hot to move with my bare hands!");
        }

    }
}
