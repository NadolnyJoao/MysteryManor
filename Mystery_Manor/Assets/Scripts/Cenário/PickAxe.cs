using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FMODUnity;
using FMOD;
using FMOD.Studio;
using FMODUnityResonance;

public class PickAxe : MonoBehaviour
{
    public bool withPickAxe = false;
    public GameObject picareta;
    public GameObject pedra;
    public GameObject comOBJ;
    
    [SerializeField] private EventReference Pick;
    private FMOD.Studio.EventInstance PickAudio;
    [SerializeField] private EventReference Rock;
    private FMOD.Studio.EventInstance RockAudio;
    
    void Start()
    {
        //PlaySound(SoundKey);
        PickAudio = RuntimeManager.CreateInstance(Pick);
        RockAudio = RuntimeManager.CreateInstance(Rock);
    }

    void Update()
    {
      
    }

    public void OnPick()
    {
        picareta.SetActive(false);
        comOBJ.SetActive(true);
        PickAudio.start();
        //RuntimeManager.PlayOneShot(SoundKey);
    }

    public void OnPedra()
    {
        if (comOBJ.activeInHierarchy)
        {
            pedra.SetActive(false);
            comOBJ.SetActive(false);
            RockAudio.start();
        }
    }

    private void PlaySound(string soundKey)
    {
        var audioEvent = RuntimeManager.CreateInstance(soundKey);
        audioEvent.start();
        audioEvent.release(); // Release the event instance after starting
    }
}