using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
 public float speed = 5f;
 public GameObject pointerMarkerPrefab;
private Vector3 target;
	void Start()
{
   
    target = transform.position;
}
	void Update()
	{
	 if (Input.GetMouseButtonDown(1))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;

			//colocar o ponteiro na mesma posição do mause ( target )
			GameObject pointerMarker = Instantiate(pointerMarkerPrefab, target, Quaternion.identity);
			//destruir o ponterMarker apos terminar a animação 
			Destroy(pointerMarker,0.5f);


        }
	transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
	}
	
}
