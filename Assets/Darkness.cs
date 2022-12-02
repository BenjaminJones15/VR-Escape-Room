using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Darkness : MonoBehaviour
{
    public GameObject sphere;

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
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
