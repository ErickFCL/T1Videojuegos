using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private bool puedoSaltar = false;
   
    private SpriteRenderer sr;
    private Animator animator;
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        sr= GetComponent<SpriteRenderer>();//obtengo el objeto spriterender de player
      //  Debug.Log("hola mundo este es un metodo que se ejecuta una vez");
        //sr.flipX = true;
        animator = GetComponent<Animator>();

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*if(Input.GetKey(KeyCode.RightArrow))
        {
            sr.flipX = false;
            run();
            rb2d.velocity = new Vector2(5,rb2d.velocity.y);
        }else
        {
            SetIdleAnimation();
            rb2d.velocity = new Vector2(0,rb2d.velocity.y);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.flipX = true;
            run();
            rb2d.velocity = new Vector2(-5,rb2d.velocity.y);
        }*/

        //cuando presiono la flecha a la derecha cambio la animacion
        //Input .GetKey(); //mientras presiono
        //Input .GetKeyUp(); //cuando suelto la tecla
        //Input .GetKeyDown();//cuando presiono por primera vez
        //sr.flipX = !sr.flipX;
        //run();
         Debug.Log("hola");
         rb2d.velocity = new Vector2(15,rb2d.velocity.y);

          if (Input.GetKeyDown(KeyCode.Space) && puedoSaltar)
        {
            saltar();
            puedoSaltar = false;
        }
         

            // rb2d.velocity = new Vector2(rb2d.velocity.x,10);
            
            //rb2d.AddForce(new Vector2(0,1000));

         
    
    }
    public void saltar(){
        var upSpeed = 80f;
        rb2d.velocity = Vector2.up * upSpeed;
        
    }
    void OnCollisionEnter2D(Collision2D other){
       // Debug.Log("Collision");
        //Debug.Log(other.gameObject.name);
        puedoSaltar = true;
        
        /*if(other.gameObject.name == "squarename"){
             estaTocandoElSuelo = true;
        }*/
           
    }

    public void run(){
        animator.SetInteger("Estado", 0);
    }
    public void SetJumpAnimation(){
       animator.SetInteger("Estado", 3);
    }
    public void SetIdleAnimation(){
        animator.SetInteger("Estado", 2);        
    }
    public void SetDeadAnimation(){
        animator.SetInteger("Estado", 1);        
    }
}
