using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerControl : MonoBehaviour
{
    [SerializeReference] Rigidbody2D rigi;
    [SerializeReference] float speed = 5f;
    [SerializeReference] SpriteRenderer sprite;
    [SerializeReference] Animator anim;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }
    private void FixedUpdate()
    {
        
    }
    void Move() 
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rigi.velocity += new Vector2(speed * Time.deltaTime, 0f);
            sprite.flipX = false;
            
                
            anim.SetBool("isRun", true);                
            

        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rigi.velocity -= new Vector2(speed * Time.deltaTime, 0f);
            sprite.flipX = true;
                            
            anim.SetBool("isRun", true);
            
            
        }

        if (rigi.velocity == new Vector2(0f,0f) && anim.GetCurrentAnimatorStateInfo(0).IsName("RPGboy_walk"))
        {
            anim.SetBool("isRun", false);
        }        

        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            anim.SetBool("isJump", false);
            rigi.AddForce(new Vector2(0f, 10f),ForceMode2D.Impulse);          
        }
        Debug.Log(rigi.velocity.x);
    }

   

}
