using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerBehavior : MonoBehaviour
{
    public Joystick joystick;
    public float joystickHorizontalSensitivity;
    public float joystickVerticalSensitivity;

    public bool isGrounded;
    public bool isJumping;
    public float horizontalForce;
    public float verticalForce;
    public Transform spawnPoint;

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private Animator animator;

    public int LifeCount;
    public GameObject LifeText;
    Text TargetLifeText;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        TargetLifeText = LifeText.GetComponent<Text>();
        LifeCount = 3;
    }

    void Update()
    {
        TargetLifeText.text = LifeCount.ToString();
        Move();

    }


    void LateUpdate()
    {

    }

    private void Move()
    {
        if (isGrounded)
        {
            if (joystick.Horizontal > joystickHorizontalSensitivity)
            {
                rb.AddForce(Vector3.right * horizontalForce * Time.deltaTime);
                spriteRenderer.flipX = true;
                animator.SetInteger("CatState", 1);
            }
            else if (joystick.Horizontal < -joystickHorizontalSensitivity)
            {
                rb.AddForce(Vector3.left * horizontalForce * Time.deltaTime);
                spriteRenderer.flipX = false;
                animator.SetInteger("CatState", 1);
            }
            else if (!isJumping)
            {
                animator.SetInteger("CatState", 0);
            }


            if (joystick.Vertical > joystickVerticalSensitivity)
            {
                rb.AddForce(Vector3.up * verticalForce * Time.deltaTime);
                animator.SetInteger("CatState", 2);
                isJumping = true;
            }
            else
            {
                isJumping = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        isGrounded = false;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("DeathPlane"))
        {
            
            if (LifeCount - 1 < 0)
            {
                SceneManager.LoadScene("GameOver");
            }
            else
            {
                LifeCount--;
                transform.position = spawnPoint.position;

            }
        }
    }
}
