using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject camera;
   
    // Start is called before the first frame update
    void Start()
    {
        if (camera == null)
            camera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 npos = transform.position;
        npos.z = -10.0f;
        camera.transform.position = npos; 
        

    }
}
