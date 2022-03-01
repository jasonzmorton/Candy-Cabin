using UnityEngine;
using System.Collections;
 
public class DoorScript : MonoBehaviour {
 
    public static bool doorKey;
    public bool open;
    public bool close;
    public bool inTrigger;

    public GameObject soundobject;
    private AudioSource door;
    public AudioClip doorOpen;

    public GameObject wall;
    public GameObject Padlock;

    void Start()
    {
        door = soundobject.GetComponent<AudioSource>();
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
            if (close)
            {
                if (doorKey)
                {
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        open = true;
                        close = false;
                        door.clip = doorOpen;
                        door.Play();
                        Destroy(wall);
                        Destroy(Padlock);
                    }
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    close = true;
                    open = false;
                }
            }
        }
 
        if (open)
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, -150.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
        else
        {
            var newRot = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0.0f, 0.0f, 0.0f), Time.deltaTime * 200);
            transform.rotation = newRot;
        }
    }
 
    void OnGUI()
    {
        if (inTrigger)
        {
            if (open)
            {
                GUI.Box(new Rect(0, 0, 200, 25), "Press E to close");
            }
            else
            {
                if (doorKey)
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Press E to open");
                }
                else
                {
                    GUI.Box(new Rect(0, 0, 200, 25), "Need a key!");
                }
            }
        }
    }
}