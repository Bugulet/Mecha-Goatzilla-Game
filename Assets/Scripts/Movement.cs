using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour
{
    public Rigidbody rb;
    public float lookSpeed = 10;
    public float movementSpeed = 5;
    private Vector3 curLoc;
    private Vector3 prevLoc;
    private Transform targetLocation;
    

    private float appliedMovementSpeed;
    private float counter = 0f;

    private void Start()
    {
        targetLocation = new GameObject().transform;
    }

    void Update()
    {
        InputListen();
        transform.rotation = Quaternion.Slerp(transform.rotation, targetLocation.rotation,counter);
        appliedMovementSpeed = movementSpeed * Mathf.Sqrt(transform.localScale.x);
        counter += Time.deltaTime;
    }

    private void InputListen()
    {
        prevLoc = curLoc;
        curLoc = transform.position;

        if (Input.GetKey(KeyCode.A))
        {
            targetLocation.position = transform.position + Vector3.left * 10;
            
            curLoc.x -= appliedMovementSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            targetLocation.position = transform.position + Vector3.right * 10;
            curLoc.x += appliedMovementSpeed * Time.fixedDeltaTime;

        }
        if (Input.GetKey(KeyCode.W))
        {
            targetLocation.position = transform.position + Vector3.forward * 10;
            curLoc.z += appliedMovementSpeed * Time.fixedDeltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            targetLocation.position = transform.position -Vector3.forward * 10;
            curLoc.z -= appliedMovementSpeed * Time.fixedDeltaTime;
        }
        transform.position = curLoc;

        Debug.DrawLine(transform.position, targetLocation.position, Color.red, 0.5f);

    }
}
    