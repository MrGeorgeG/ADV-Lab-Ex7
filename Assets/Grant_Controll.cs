using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grant_Controll : MonoBehaviour
{
    Animator animator;
    Rigidbody2D body;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        body = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 scale = gameObject.transform.localScale;
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("jump");
            body.AddForce(Vector3.up * 100);
            animator.SetBool("isGrounded", !animator.GetBool("isGrounded"));

        }
        if (Input.GetKey(KeyCode.LeftArrow)) 
        {
            body.AddForce(Vector3.left * 50);
            gameObject.transform.localScale = new Vector3(-1, scale.y, scale.z);
        }
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            body.AddForce(Vector3.right * 50);
            gameObject.transform.localScale = new Vector3(1, scale.y, scale.z);
        }
        float veloclty = body.velocity.magnitude;
        animator.SetFloat("veloclty", veloclty);

    }
}
