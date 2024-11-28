using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAxe : MonoBehaviour
{
    public bool withPickAxe = false;
    public GameObject picareta;
    public GameObject pedra;
    public GameObject comOBJ;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPick(){
        picareta.SetActive(false);
        comOBJ.SetActive(true);
    }
    public void OnPedra(){
        if(comOBJ.activeInHierarchy){
            pedra.SetActive(false);
            comOBJ.SetActive(false);
        }

    }
}
