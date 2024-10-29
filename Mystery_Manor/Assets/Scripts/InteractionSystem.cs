using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public UnityEvent onInteract;
    public Collider2D Interact_area;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    public void OnInteraction(){
        onInteract.Invoke();

    }
     void OnCollisionEnter(Collision collision)
    {
       Debug.Log("fonceonou");
    }
}
