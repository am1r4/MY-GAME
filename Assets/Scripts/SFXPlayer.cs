using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXPlayer : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    public GameObject soundObject;
        void Start()
    {
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaySFX()
    {
        audioSource.Play();
        GameObject sfx = Instantiate(soundObject);
        Destroy(sfx,5f);
        //gets destroyed after this time
    }
}
