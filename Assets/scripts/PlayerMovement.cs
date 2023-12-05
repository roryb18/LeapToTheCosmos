using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D myRigid;
    private BoxCollider2D coll;

    [SerializeField] private LayerMask jumpableGround; 
    [SerializeField] private int maxJumps = 2; 

    private int jumpsRemaining; 

    // Start is called before the first frame update
    private void Start()
    {
        myRigid = GetComponent<Rigidbody2D>();
        coll = GetComponent<BoxCollider2D>();
        jumpsRemaining = maxJumps; 
    }

    // Update is called once per frame
    private void Update()
    {
        float dirX = Input.GetAxisRaw("Horizontal");

        myRigid.velocity = new Vector2(dirX * 3.5f, myRigid.velocity.y);

        if (IsGrounded())
        {
            jumpsRemaining = maxJumps;
        }

        if (Input.GetButtonDown("Jump") && jumpsRemaining > 0)
        {
            myRigid.velocity = new Vector2(myRigid.velocity.x, 7f);
            jumpsRemaining--;
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(coll.bounds.center, coll.bounds.size, 0f, Vector2.down, .1f, jumpableGround);
    }

}
