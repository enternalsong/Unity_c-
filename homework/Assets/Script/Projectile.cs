using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile: MonoBehaviour {
    [SerializeField]
    
    private float angle;
    private float gravitiy = 9.81f;
    private float PI = Mathf.PI;

    public float speed;
    private float speedx;
    private float speedy;
    //private Transform tb;
    [SerializeField]
    private float Xd;
    private float Yd;
    private Rigidbody rb;
    //public float dd;
    public GameObject Obj;
    //public GameObject player;
    //players = GameObject.FindGameObjectswithTag("player");
	// Use this for initialization
	 void Start () {

        if (Yd <0)
        {
            if (Xd < 0)
            {
                Xd = -Xd;
                speed = Mathf.Sqrt(Xd * gravitiy) / Mathf.Sqrt(  Mathf.Cos(angle * PI / 180) * Mathf.Sin(angle * PI / 180) ) ;
                speedx = speed * Mathf.Cos(angle * PI / 180);
                speedy = speed * Mathf.Sin(angle * PI / 180);

                rb.velocity = new Vector3(1 * speedx, speedy, 0);
            }
            else
            { 
                speed = Mathf.Sqrt(   Xd * gravitiy / (Mathf.Cos(angle * PI / 180) * Mathf.Sin(angle * PI / 180))  );
                speedx = speed * Mathf.Cos(angle * PI / 180);
                speedy = speed * Mathf.Sin(angle * PI / 180);
                rb.velocity = new Vector3(-1 * speedx, speedy, 0);

            }
        }
        else if (Yd == 0)
        {
            speed = Mathf.Sqrt(Xd * gravitiy /(2 * Mathf.Sin(angle * PI / 180) * Mathf.Cos(angle * PI / 180)));
            speedx = speed * Mathf.Cos(angle * PI / 180);
            speedy = speed * Mathf.Sin(angle * PI / 180);
            // rb.velocity = Vector3.up * speedy;
            // rb.velocity = Vector3.left * speedx;
            // rb.velocity = new Vector2(speed.x, speed.y);
            rb.velocity = new Vector3(-1 * speedx, speedy, 0);
        }
        else if(Yd>0)
        {
            speed = Xd*Mathf.Sqrt(gravitiy)/Mathf.Sqrt(2*Yd);
       
         
             speedx = speed * 1; 
            rb.velocity = new Vector3(-1 * speedx, 0, 0);


        }
    }

    // Update is called once per fZrame
    
 }


