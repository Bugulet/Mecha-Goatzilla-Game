using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Rigidbody cubeRigidbody;
    [SerializeField] float MovementSpeed=10f;
    [SerializeField] float RotationSpeed = 30f;
    [SerializeField] float MaxSpeed = 20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        //apply force forward
        if (Input.GetKey(KeyCode.W) && cubeRigidbody.velocity.magnitude<MaxSpeed)
        {
            
            cubeRigidbody.AddForce( transform.forward*MovementSpeed*Time.deltaTime);
        }


        //left and right rotation
        if (Input.GetKey(KeyCode.D))
        {
            
           transform.Rotate(transform.up, RotationSpeed * Time.deltaTime * cubeRigidbody.velocity.magnitude/5);
        }
        if (Input.GetKey(KeyCode.A))
        {
           transform.Rotate(transform.up, -RotationSpeed * Time.deltaTime * cubeRigidbody.velocity.magnitude/5);
        }

    }

}
