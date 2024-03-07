using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

//public class TankControll : MonoBehaviour
public class TankControll : NetworkBehaviour
{

    [SerializeField] private float speed = 20;
    [SerializeField] private float turnSpeed = 45;
    [SerializeField] private float jumpSpeed = 25;
    private float horizontalInput;
    private float forwardInput;
    private float jumpInput;

    void Start()
    {
        
    }

    void Update()
    {
        if (IsOwner == false)
            return;

        horizontalInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * jumpSpeed * jumpInput);
    }
}
