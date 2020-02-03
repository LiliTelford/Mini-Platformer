using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;
    public float speed = 5f;
    public float jumpHeight = 5f;
    public bool isOnFloor = false;

    // Update is called once per frame
    void Update()
    {
        bool runRightBool = false;
        bool runLeftBool = false;

        //tells us if either the A or D keys are being pressed
        Debug.Log(Input.GetAxisRaw("Horizontal"));

        Rigidbody2D Player = GetComponent<Rigidbody2D>();

        //checks if the player is holding down the D key
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            //moves the player character right
            transform.position += new Vector3(1, 0) * speed * Time.deltaTime;
            runRightBool = true;
        }
        //checks if the player is holding down the A key
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            //moves the player character left
            transform.position += new Vector3(-1, 0) * speed * Time.deltaTime;
            runLeftBool = true;
        }

        if(Input.GetKeyDown("space") && isOnFloor == true)
        {
            Player.AddForce(new Vector2(0f, jumpHeight), ForceMode2D.Impulse);
        }
        //sets the animation bools as true or false depending if the A or D keys are being held down
        animator.SetBool("runRightBool", runRightBool);
        animator.SetBool("runLeftBool", runLeftBool);
        animator.SetBool("grounded", isOnFloor);
    }

    void Jump()
    {

    }

    void FixedUpdate()
    {

    }
}
