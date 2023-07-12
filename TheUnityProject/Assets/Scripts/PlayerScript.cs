using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    [SerializeField]
    float speed = 1f;
    [SerializeField]
    float turnSpeed = 1f;
    [SerializeField]
    Rigidbody body;

    Transform trans;

    float moveInput;
    float turnInput;
    
    // Start is called before the first frame update
    void Start()
    {
        trans = gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = Input.GetAxis("Vertical");
        turnInput = Input.GetAxis("Horizontal");

    }

    private void FixedUpdate()
    {
        trans.Rotate(Vector3.up, turnSpeed * turnInput);

        Vector3 moveVector = trans.forward * speed * moveInput;
        moveVector.y = body.velocity.y;
        body.velocity = moveVector;
    }
}
