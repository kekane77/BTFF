using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 1;

    private Vector2 input;
    private Rigidbody2D body; // to prevent wall breaking
    private Animator animator;

    private void Start()
    {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update () {
        GetInput();
        Move();
        Animate();

        // enable movement layer
        if (input.x != 0 || input.y != 0)
        {
            animator.SetLayerWeight(1, 1);
        }
        else // disable movement layer
        {
            animator.SetLayerWeight(1, 0);
        }
        
    } // end Update

    private Vector2 GetInput()
    {
        input.x = Input.GetAxisRaw("Horizontal");
        input.y = Input.GetAxisRaw("Vertical");
        return input;
    }

    private void Move()
    {
        body.MovePosition(new Vector2((transform.position.x + input.x * speed * Time.deltaTime),
            transform.position.y + input.y * speed * Time.deltaTime));
    }

    public void Animate()
    {
        animator.SetFloat("x", input.x);
        animator.SetFloat("y", input.y);
    }

}
