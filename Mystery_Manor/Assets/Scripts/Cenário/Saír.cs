using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saír : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject comCartao;
    public GameObject senha;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Saida(){
        if(comCartao.activeInHierarchy == true ){
            senha.SetActive(true);

        }
    }
}
