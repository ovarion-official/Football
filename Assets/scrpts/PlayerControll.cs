using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class PlayerControll : NetworkBehaviour
{
    private Animator animator;
    private Rigidbody rigidbody;
    public float rotationSpeed = 10f;
    public float speed = 2f;

    public FixedJoystick fixedJoystick;


    
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isOwned) 
        {
            float h = Input.GetAxis("Horizontal") + fixedJoystick.Horizontal;
            float v = Input.GetAxis("Vertical") + fixedJoystick.Vertical;

            Vector3 directionVector = new Vector3(h, 0, v);
            if(directionVector.magnitude > Mathf.Abs(0.05f))
            transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);

            animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
            rigidbody.velocity = Vector3.ClampMagnitude(directionVector, 1) * speed;
        }


    }



}
