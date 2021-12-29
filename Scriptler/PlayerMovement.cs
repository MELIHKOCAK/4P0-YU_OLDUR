using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D karakter;
    Vector3 velocity;
    float speedAmount = 5f;
    public float jumpAmount = 6f;
    public Animator animator;
    public int score;
    public TextMeshProUGUI scoreText;
    public Joystick joystick;
    float horizontalMoveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        karakter = GetComponent<Rigidbody2D>();
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (joystick.Horizontal>0.002f)
        {
            horizontalMoveSpeed = 1;
        }

        else if (joystick.Horizontal < -0.002f)
        {
            horizontalMoveSpeed = -1;
        }
        else
        {
            horizontalMoveSpeed = 0;
        }

        scoreText.text = score.ToString(); 
        animator.SetFloat("speed", Mathf.Abs(joystick.Horizontal));
        velocity = new Vector3(horizontalMoveSpeed , 0f);                //Input Unity Oyun Motorunun Bizlere Kullanıcıdan Veri almak için sağladığı sınıftır.
        transform.position += velocity * speedAmount * Time.deltaTime;

        if (horizontalMoveSpeed == -1)
        {
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }

        else if (horizontalMoveSpeed == 1)
        {
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }

        if (joystick.Vertical>0.5f && !animator.GetBool("IsJumping"))
        {
            karakter.AddForce(Vector3.up * jumpAmount, ForceMode2D.Impulse);
            animator.SetBool("IsJumping", true);
        }

 
    }
    
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            animator.SetBool("IsJumping",false);
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Ground")
        {
            animator.SetBool("IsJumping",true);
        }
    }

}
