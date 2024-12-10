using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD;
using FMOD.Studio;
using FMODUnityResonance;

public class Player_Movement : MonoBehaviour
{
 public float speed = 5f;
 public GameObject pointerMarkerPrefab;
private Vector3 target;
public float ActualSpeed = 0;
[SerializeField] private EventReference Footstap;
    private FMOD.Studio.EventInstance FootstapsAudio;
	public bool soundBool = true;
	public Animator animator;
	public float NPosition = 0;
	public bool Virar = false;


	void Start()
{
   FootstapsAudio = RuntimeManager.CreateInstance(Footstap);
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
			animator.SetFloat ("PlayerSpeed", 1);



        }
		if (transform.position == target){
			ActualSpeed = 0;
			animator.SetFloat ("PlayerSpeed", 0);
			

		}
		else if(transform.position != target){
			ActualSpeed = speed;
			if (ActualSpeed == speed && soundBool == true){
				soundBool = false;
				FootstapsAudio.start();
			}
			if(transform.position.x < target.x){
				Virar = true;
				this.transform.rotation = Quaternion.Euler(new Vector3(16f, Virar ? 180f : 0f, 16f));

			}
			else if (transform.position.x > target.x){
				this.transform.rotation = Quaternion.Euler(new Vector3(16f, Virar ? 90f : 0f, 16f));
			}
			
		}
		if (ActualSpeed == 0){
			soundBool = true;
			FootstapsAudio.stop(FMOD.Studio.STOP_MODE.ALLOWFADEOUT);
		}
	transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

	}
	
}
