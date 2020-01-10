using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Input.GetAxisRaw("Horizontal"));

        Rigidbody2D player = GetComponent<Rigidbody2D>();
        float speed = 5f;

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.position += new Vector3(1, 0) * speed * Time.deltaTime;
            animator.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        }
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.position += new Vector3(-1, 0) * speed * Time.deltaTime;
        }
    }

    void FixedUpdate()
    {

    }
}
