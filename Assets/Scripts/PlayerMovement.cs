using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        bool runRightBool = false;

        Debug.Log(Input.GetAxisRaw("Horizontal"));

        Rigidbody2D player = GetComponent<Rigidbody2D>();
        float speed = 5f;

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position += new Vector3(1, 0) * speed * Time.deltaTime;
            runRightBool = true;
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.position += new Vector3(-1, 0) * speed * Time.deltaTime;
        }

        animator.SetBool("runRightBool", runRightBool);
    }

    void FixedUpdate()
    {

    }
}
