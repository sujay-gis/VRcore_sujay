using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class open_door_code : MonoBehaviour
{
    public Animator door; // variable to open the door.
    public string tag; // something to trigger

    // Start is called before the first frame update
    void Start()  //main function
    {
        
    }

    // Update is called once per frame
    void Update() //calls itself based on per frames
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(tag)) // Ensure your player GameObject has the "Player" tag
        {
            door.SetBool("character_nearby",true); // this is the trigger function 
        }
      


    }
}
