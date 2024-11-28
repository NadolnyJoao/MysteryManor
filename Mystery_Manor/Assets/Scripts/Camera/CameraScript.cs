using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject MyCamera;
    public float speedMove = 2;
    public  Vector3 targetPosition ;
    // Start is called before the first frame update
    void Start()
    {
        if (MyCamera == null)
            MyCamera = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }
    private void OnTriggerEnter2D(Collider2D Target)
    {
        if (Target.tag == "Cenário")
        targetPosition = Target.gameObject.transform.position;
        Debug.Log("name of sala "+ gameObject.name);
        targetPosition.z = -10.0f;
        
    }

    private void MoveCamera()
    {
        // Enquanto a posição da câmera não estiver próxima da posição desejada, continue a mover suavemente
        if (Vector3.Distance(MyCamera.transform.position, targetPosition) > 0.1f)
        {
         
            MyCamera.transform.position = Vector3.Lerp(MyCamera.transform.position, targetPosition, speedMove * Time.deltaTime);
        }

        // // Garante que a câmera termine exatamente na posição alvo
        // MyCamera.transform.position = targetPosition;
    }
}
