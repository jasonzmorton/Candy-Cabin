using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyItemController : MonoBehaviour
{
    [SerializeField] private bool Door = false;
    [SerializeField] private bool Key = false;

    [SerializeField] private KeyInventory _keyInventory = null;

    private KeyDoorController doorObject;

    private void Start()
    {
        if(Door)
        {
            doorObject = GetComponent<KeyDoorController>();
        }
    }

    public void ObjectInteraction()
    {
        if (Door)
        {
            gameObject.SetActive(false);
        }
        
        else if (Key)
        {
            _keyInventory.hasKey = true;
            gameObject.SetActive(false);
        }
    }
}
