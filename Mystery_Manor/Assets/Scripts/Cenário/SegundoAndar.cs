using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SegundoAndar : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject estauta180;
    public GameObject luzApagada;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void IrSegundoAndar(){
        if(estauta180.activeInHierarchy && luzApagada.activeInHierarchy == false){
        SceneManager.LoadScene(2);

        }

    }
}
