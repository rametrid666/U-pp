using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            rigi.velocity += new Vector2(speed*Time.deltaTime,0f);
            sprite.flipX = false;
            //anim.SetBool("isRun", true);

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rigi.velocity -= new Vector2(speed * Time.deltaTime, 0f);
            sprite.flipX = true;
            //anim.SetBool("isRun", true);
        }
        if (rigi.velocity == new Vector2(0f, 0)) 
        {
            anim.SetBool("isRun", false);
        }
        else 
        {
            anim.SetBool("isRun", true);

        }
        if(Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) 
        {
            
        }


    }
}
