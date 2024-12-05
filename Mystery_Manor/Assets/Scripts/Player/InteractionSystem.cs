using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class InteractionSystem : MonoBehaviour
{
    public UnityEvent onInteract;
    public bool InArea = false;
    public TMP_Text InteractText;

    void Start()
    {
        // Ensure the interaction text is hidden at the start
        if (InteractText != null)
        {
            InteractText.gameObject.SetActive(false);
        }
    }

    void Update()
    {
        if (InArea && Input.GetKeyDown(KeyCode.Space))
        {
            onInteract.Invoke();
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Player entered interaction area");
            InArea = true;

            // Show interaction text
            if (InteractText != null)
            {
                InteractText.gameObject.SetActive(true);
                InteractText.text = "Press Space to interact";
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //Debug.Log("Player exited interaction area");
            InArea = false;

            // Hide interaction text
            if (InteractText != null)
            {
                InteractText.gameObject.SetActive(false);
            }
        }
    }
}