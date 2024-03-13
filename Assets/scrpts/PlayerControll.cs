using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerControll : NetworkBehaviour
{
    public Animator animator;
    public Rigidbody rb;
    public float rotationSpeed = 10f;
    public float speed = 2f;

    //public FixedJoystick fixedJoystick;


    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOwned) 
        {
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 directionVector = new Vector3(h, 0, v);
            if(directionVector.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);

            animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
            rb.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
        }


    }



}
