using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : MonoBehaviour
{

    public Animator DoorAnim;
    public Light MyLight;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("chestkey")) {
            DoorAnim.SetTrigger("KeyOpen");
            Debug.Log("it worked");
            MyLight.enabled = !MyLight.enabled;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //DoorAnim.SetTrigger("KeyOpen");
    }
}
