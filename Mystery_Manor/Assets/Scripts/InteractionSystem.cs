using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;


public class InteractionSystem : MonoBehaviour
{
    // Start is called before the first frame update
   public UnityEvent onInteract;
   public bool InArea = false;
   public TMP_Text InteractText;
   
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      if (InArea == true && Input.GetKeyDown(KeyCode.Space)){
        InteractText = "Aperte Espaço para interagir";
        
        onInteract.Invoke();

      }
    }
   public void OnInteraction(){
        onInteract.Invoke();

    }
    void OnTriggerEnter2D (Collider2D collision) {
    if(collision.gameObject.CompareTag("Player")){
        Debug.Log("Primeira parte funciona");
       
            InArea = true;
        }
        
        
        
       
       
    }
    }

