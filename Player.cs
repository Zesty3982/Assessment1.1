using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //Player Movements
    public CharacterController controller;
    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    
    //Gun
    public Rigidbody projectile;
    public Transform barrelEnd;

    //Gravity
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    Vector3 velocity;
    bool isGrounded;




    // Update is called once per frame
    void Update()
    {

        //Movement
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        //Shooting
        if (Input.GetButtonDown("Fire1"))
        {
            Rigidbody projectileInstance;
            projectileInstance = Instantiate(projectile, barrelEnd.position, barrelEnd.rotation) as Rigidbody;
            projectileInstance.AddForce(barrelEnd.forward * 2000f);
        }

    }
}
 