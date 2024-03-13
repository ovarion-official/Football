using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class JoystickPlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    //[SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed = 5f;
    //[SerializeField] private float rotationSpeed = 10f;



    private void FixedUpdate()
    {


        _rigidbody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidbody.velocity.y, _joystick.Vertical * _moveSpeed);
        
        //float h = _joystick.Horizontal;
        //float v = _joystick.Vertical;
        //Vector3 directionVector = new Vector3(h, 0, v);
        //if(directionVector.magnitude > Mathf.Abs(0.05f))
        
        //transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.LookRotation(directionVector), Time.deltaTime * rotationSpeed);
        

        //_animator.SetFloat("speed", Vector3.ClampMagnitude(directionVector, 1).magnitude);
        //_rigidbody.velocity = Vector3.ClampMagnitude(directionVector, 1) * _moveSpeed;
        

    }
}