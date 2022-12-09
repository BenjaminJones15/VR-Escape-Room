using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wrong : MonoBehaviour
{
    public GameObject sphere;
    public AudioSource audioSource;
    public AudioClip clip;
    public float volume=1f;
    public Animator CrawlerAnim;
    public GameObject Crawler;
    public GameObject Player;
    public Transform Target;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("ball"))
        {
            Debug.Log("it worked");
            sphere.GetComponent<MeshRenderer>().enabled = false;
            audioSource.PlayOneShot(clip, volume);
            Crawler.GetComponent<SkinnedMeshRenderer>().enabled = true;
            CrawlerAnim.SetTrigger("Wrong");
            Player.transform.position = Target.transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
