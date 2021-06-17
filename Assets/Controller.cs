using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    private float moveInput;
    private float speed = 15f;
  
   private float topScore = 0.0f;

   //public Joystick joystick;
    public Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


void Update()
{

if(moveInput < 0)
{
     this.GetComponent<SpriteRenderer>().flipX = false;
   
}
else if(moveInput > 0)
{
     this.GetComponent<SpriteRenderer>().flipX = true;
   
}


  else if(rb.velocity.y >0 && transform.position.y > topScore)
  {
      topScore = transform.position.y;
  }
  scoreText.text = "Score: " + Mathf.Round(topScore).ToString();
}

    // Update is called once per frame

    void FixedUpdate()
    {
        
        moveInput = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);
    }
    }

