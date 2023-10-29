using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Prizes"))
        {
            Debug.Log("score increase!");
            other.gameObject.GetComponent<SFXPlayer>().PlaySFX();
            // Destroy(other.gameObject);
        }
        else
        if(other.gameObject.CompareTag("Obstacles"))
        {
            Debug.Log("Decrease HP");
            other.gameObject.GetComponent<SFXPlayer>().PlaySFX();
        }

    }
}
