using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject camera;
    public float speedMove = 2;
    public  Vector3 targetPosition ;
    // Start is called before the first frame update
    void Start()
    {
        if (camera == null)
            camera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
         targetPosition = collision.gameObject.transform.position;
        Debug.Log("name of sala "+ gameObject.name);
        targetPosition.z = -10.0f;
        
    }

    private void MoveCamera()
    {
        // Enquanto a posição da câmera não estiver próxima da posição desejada, continue a mover suavemente
        if (Vector3.Distance(camera.transform.position, targetPosition) > 0.1f)
        {
         
            camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, speedMove * Time.deltaTime);
        }

        // // Garante que a câmera termine exatamente na posição alvo
        // camera.transform.position = targetPosition;
    }
}
