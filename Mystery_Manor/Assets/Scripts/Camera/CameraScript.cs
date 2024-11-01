using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject camera;
    public float speedMove = 2;
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
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Vector3 targetPosition = transform.position;
        targetPosition.z = -10.0f;
        StartCoroutine(SmoothMoveCamera(targetPosition));
    }

    private IEnumerator SmoothMoveCamera(Vector3 targetPosition)
    {
        // Enquanto a posição da câmera não estiver próxima da posição desejada, continue a mover suavemente
        while (Vector3.Distance(camera.transform.position, targetPosition) > 0.01f)
        {
            // Interpola entre a posição atual e a nova posição usando Lerp
            camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, speedMove * Time.deltaTime);
            yield return null; // Espera o próximo frame
        }

        // Garante que a câmera termine exatamente na posição alvo
        camera.transform.position = targetPosition;
    }
}
