using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerController : MonoBehaviour {

    CharacterController _Controller;
    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    private Vector3 moveDirection = Vector3.zero;
    // Use this for initialization
    void Start () {
        _Controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        moveDirection.x = Input.GetAxis("Horizontal");
        moveDirection.x *= speed;

        if (_Controller.isGrounded)
        {
            moveDirection.y = 0;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }

        moveDirection.y -= gravity * Time.deltaTime;
        _Controller.Move(moveDirection * Time.deltaTime);
    }
}
