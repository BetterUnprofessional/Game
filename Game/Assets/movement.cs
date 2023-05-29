using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
 public class movement : MonoBehaviour {
     //Variables
     public float speed = 6.0F;
     public float jumpSpeed = 8.0F; 
     public float gravity = 20.0F;
     private Vector3 moveDirection = Vector3.zero;
 
     void Update() {
         CharacterController controller = GetComponent<CharacterController>();
         // is the controller on the ground?
         if (controller.isGrounded) {
            Debug.Log("hello");
             //Feed moveDirection with input.
             moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
             moveDirection = transform.TransformDirection(moveDirection);
             //Multiply it by speed.
             moveDirection *= speed;
             //Jumping
             if (Input.GetButton("Jump"))
                 moveDirection.y = jumpSpeed;
                Debug.Log("hello");
         }
         //Applying gravity to the controller
         moveDirection.y -= gravity * Time.deltaTime;
         //Making the character move
         controller.Move(moveDirection * Time.deltaTime);
     }
 }