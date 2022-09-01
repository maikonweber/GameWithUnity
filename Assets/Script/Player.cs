using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float forceMultipler = 3f;
    public float maximumVelocity = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 100x1
    void Update()
    {
        var horizontalInput = Input.GetAxis("Horizontal");

        if(GetComponent<Rigidbody>().velocity.magnitude <= maximumVelocity)
        {
        GetComponent<Rigidbody>().AddForce(new Vector3(horizontalInput * forceMultipler, 0 , 0));        
        }
    }


    private void OnCollisionEnter(Collision collision) 
    {
        if(collision.gameObject.CompareTag("Hazard")) 
        {
            Debug.Log(gameObject);
            Destroy(gameObject);
        }
    }
}

