using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right_and_left_UpDate : MonoBehaviour {

    
    public float RightBound = 0;
    public float LeftBound = 0;

    public float ControlVelocity = 1;
    //public float ControlTime = 1;
    //float mytime = 0;
    float MyStartPosition = 0;
   



    Rigidbody2D Myrigid;
    

	// Use this for initialization
	void Start () {
        MyStartPosition = gameObject.transform.position.x;

        Myrigid = gameObject.GetComponent<Rigidbody2D>();
        Myrigid.velocity = new Vector2(1 * ControlVelocity, 0);

    }
	
	// Update is called once per frame
	void Update () {

        //mytime += Time.deltaTime * ControlTime;


        //if (mytime > 10)
        //{
        //    Myrigid.velocity = new Vector2(1 * ControlVelocity, 0);
        //    if (mytime > 20)
        //    {
        //        mytime = 0;
        //    }

        //}
        //else
        //{

        //    Myrigid.velocity = new Vector2(-1 * ControlVelocity, 0);

        //}

        if (gameObject.transform.position.x-MyStartPosition>RightBound)
        {
            Myrigid.velocity = new Vector2(-1 * ControlVelocity, 0);
        }
        if (gameObject.transform.position.x - MyStartPosition <  -LeftBound)
        {
            Myrigid.velocity = new Vector2(1 * ControlVelocity, 0);
        }








    }
}
