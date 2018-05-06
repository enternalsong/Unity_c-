using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class up_ThrowBall : MonoBehaviour {


    //GameObject Destination;
    Rigidbody2D PlayerRigid;
    public GameObject Player;

    public float ControlTime = 0;

    bool ie=true;

  //  float StartObjetX = 0;

    float VelocX = 0;
    float VelocY = 0;
  
    void Start () {

        //Destination=GameObject.Find("Destination");

         Player = GameObject.Find("SatorAI");

        PlayerRigid = Player.GetComponent<Rigidbody2D>();

    }
	void Update () {



        if (ie/*&&(=Mathf.Abs(Player.transform.position.x-gameObject.transform.position.x)<30*/)
        {
           // StartObjetX = Player.transform.position.x  /*+*PlayerRigid.velocity.x * (ControlTime-2f)*/;

            VelocX = (Player.transform.position.x + PlayerRigid.velocity.x * ControlTime - gameObject.transform.position.x) / ControlTime;
         

            if (gameObject.transform.position.y - Player.transform.position.y == 0 || gameObject.transform.position.y - Player.transform.position.y > 0)
            {
                VelocY = -(Mathf.Abs(gameObject.transform.position.y - Player.transform.position.y) - (1f / 2f) * 9.81f * ControlTime * ControlTime) / ControlTime;
            }
            else
            {
                VelocY = (Mathf.Abs(gameObject.transform.position.y - Player.transform.position.y) + (1f / 2f) * 9.81f * ControlTime * ControlTime) / ControlTime;
            }

            gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;


            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(VelocX, VelocY);

            Debug.Log(gameObject.GetComponent<Rigidbody2D>().velocity);
            ie = false;
        }


    }
}


//GameObject Destination;
//Rigidbody2D PlayerRigid;
//public GameObject Player;

//public float ControlTime = 0;

//float desX = 0;
//float desY = 0;

//float VelocX = 0;
//float VelocY = 0;
//bool ss = true;

//void Start()
//{

//    //Destination=GameObject.Find("Destination");

//    // Player = GameObject.Find("");

//    PlayerRigid = Player.GetComponent<Rigidbody2D>();

//    desX = Destination.transform.position.x;

//    desY = Destination.transform.position.y;


//    VelocX = (desX - gameObject.transform.position.x) / ControlTime;
//    if (gameObject.transform.position.y - Destination.transform.position.y == 0 || gameObject.transform.position.y - Destination.transform.position.y > 0)
//    {
//        VelocY = -(Mathf.Abs(gameObject.transform.position.y - Destination.transform.position.y) - (1f / 2f) * 9.81f * ControlTime * ControlTime) / ControlTime;
//    }
//    else
//    {
//        VelocY = (Mathf.Abs(gameObject.transform.position.y - Destination.transform.position.y) + (1f / 2f) * 9.81f * ControlTime * ControlTime) / ControlTime;
//    }

//    //gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;

//    //gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(VelocX, VelocY);
//}
//void Update()
//{
//    if ((PlayerRigid.velocity.x * ControlTime + Player.transform.position.x) > Destination.transform.position.x && ss)
//    {
//        gameObject.GetComponent<Rigidbody2D>().gravityScale = 1f;

//        gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(VelocX, VelocY);
//        ss = false;

//    }

//}
//}
