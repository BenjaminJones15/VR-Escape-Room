using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{ 
    public Animator DoorAnim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("doorkey"))
        {
            DoorAnim.SetTrigger("dooropen");
            Debug.Log("it worked");
            gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //DoorAnim.SetTrigger("open");
    }
}
