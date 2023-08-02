using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float keyinput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            GetComponent<Rigidbody>().AddForce (Vector3.up*7,ForceMode.VelocityChange);
        }
        keyinput = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody>().velocity = new Vector3 (keyinput*7, GetComponent<Rigidbody>().velocity.y, 0);
        
    }
}
