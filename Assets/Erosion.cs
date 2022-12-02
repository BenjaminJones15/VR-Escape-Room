using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Erosion : MonoBehaviour
{
    public GameObject sphere;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=0.5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("ball"))
        {
            Debug.Log("it worked");
            sphere.GetComponent<Rigidbody>().isKinematic = false;
            audioSource.PlayOneShot(clip, volume);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
