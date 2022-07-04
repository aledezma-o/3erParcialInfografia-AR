using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkZombieEvent : MonoBehaviour
{
    //movement speed in units per second
    private float movementSpeed = 5f;
    // Start is called before the first frame update
    void Start()
    {
    }



    void Update()
    {
        //get the Input from Horizontal axis
        float horizontalInput = Input.GetAxis("Horizontal");
        //get the Input from Vertical axis
        //float verticalInput = Input.GetAxis("Vertical");

        //update the position
        transform.position = transform.position + new Vector3(horizontalInput * movementSpeed * Time.deltaTime, 0, 0);

        //output to log the position change
        Debug.Log(transform.position);
    }
}
