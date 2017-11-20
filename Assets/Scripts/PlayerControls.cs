using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour {

    #region Serialize Fields
    [SerializeField]
    private float playerSpeed = 5f;

    [SerializeField]
    private float playerJumpHeight = 3f;

    [SerializeField]
    private Transform groundCheck;

    [SerializeField]
    float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;
    #endregion

    #region private variables
    private Rigidbody2D playerRidgidBody2D;
    private bool facingRight = true;
    private Animator anim;
    private bool grounded;
    private bool pressedJump;
    private float move;
    private AudioSource audioSource;
    #endregion




    // Use this for initialization
    void Start()
    {
        playerRidgidBody2D = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
    }

    private void UpdateIsOnGround()
    {
        Collider2D[] groundColliders = Physics2D.OverlapCircleAll(groundCheck.position, groundRadius, whatIsGround);
        grounded = groundColliders.Length > 0;
    }
    // Update is called once per frame
    void FixedUpdate()
    {

        HandlePlayerMovement();

        anim.SetBool("Ground", grounded);
        anim.SetFloat("vSpeed", playerRidgidBody2D.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(move));
        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();


    }

    private void Update()
    {
        UpdateIsOnGround();
        GetJumpInput();
        GetMovementInput();
        HandleJump();

    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    private void GetJumpInput()
    {
        pressedJump = Input.GetButtonDown("Jump");
    }

    private void HandleJump()
    {
        if (pressedJump && grounded)
        {
            anim.SetBool("Ground", false);
            //playerRidgidBody2D.AddForce(new Vector2(0, playerJumpHeight));
            playerRidgidBody2D.velocity = new Vector2(playerRidgidBody2D.velocity.x, playerJumpHeight);
            audioSource.Play();
        }
    }

    private void GetMovementInput()
    {
        move = Input.GetAxis("Horizontal");
    }

    private void HandlePlayerMovement()
    {
        playerRidgidBody2D.velocity = new Vector2(move * playerSpeed, playerRidgidBody2D.velocity.y);
    }

}
