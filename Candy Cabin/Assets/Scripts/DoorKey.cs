using UnityEngine;
using System.Collections;
 
public class DoorKey : MonoBehaviour {
 
    public bool inTrigger;

    private AudioSource audioSource;
    public AudioClip keyGrab;

    public GameObject soundobject;

    public GameObject keyInventory;

    void Start()
    {
        audioSource = soundobject.GetComponent<AudioSource>();
        keyInventory.SetActive(false);
    }
 
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
                DoorScript.doorKey = true;
                keyInventory.SetActive(true);
                audioSource.clip = keyGrab;
                audioSource.Play();
                Destroy(this.gameObject);
            }
        }
    }
 
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Press E to take key");
        }
    }
}