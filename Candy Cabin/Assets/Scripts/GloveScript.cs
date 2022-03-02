using UnityEngine;
using System.Collections;
 
public class GloveScript : MonoBehaviour {
 
    public bool inTrigger;

    public GameObject soundObject;
    private AudioSource glove;
    public AudioClip gloveGrab;

    public GameObject gloveInventory;

    public GameObject follow;

    void Start()
    {
        glove = soundObject.GetComponent<AudioSource>();
        gloveInventory.SetActive(false);
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
                ObstaclePush.hasGlove = true;
                gloveInventory.SetActive(true);
                glove.clip = gloveGrab;
                glove.Play();
                Destroy(this.gameObject);
            }
        }

        if (follow.transform.position.x <= -49)
        {
            gloveInventory.SetActive(false);
        }
    }
 
    void OnGUI()
    {
        if (inTrigger)
        {
            GUI.Box(new Rect(0, 60, 200, 25), "Press E to take glove");
        }
    }
}