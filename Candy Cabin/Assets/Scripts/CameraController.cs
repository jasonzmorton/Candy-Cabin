using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    public Transform target;

     public Vector3 boundsMax;
    public Vector3 boundsMin;

    public Vector3 offset;

    public float pitch = 2f;

    private float currentZoom = 10f;

    void Update () 
    {
        transform.position = target.position - offset * currentZoom;
        transform.LookAt(target.position + Vector3.up * pitch);
        transform.position = new Vector3 (Mathf.Clamp (transform.position.x, boundsMin.x, boundsMax.x),
        Mathf.Clamp (transform.position.y, boundsMin.y, boundsMax.y), 
        Mathf.Clamp (transform.position.z, boundsMin.z, boundsMax.z));
    }
    
}
