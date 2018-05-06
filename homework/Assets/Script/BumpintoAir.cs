using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpintoAir : MonoBehaviour {
    [SerializeField]
    private float time;
    private float gravitiy = 9.81f;
    private float PI = Mathf.PI;
    private float Xd=0;
    private float Yd=0;
    private float speedx;
    private float speedy;
    private Rigidbody2D rb;
    private Rigidbody2D rrb;
    public GameObject Obj;
    public float speedother;
    bool ie = true;
    // Use this for initialization
    void Start () {


        Obj = GameObject.Find("Objectt");
        rb = GetComponent<Rigidbody2D>();
        rb = Obj.GetComponent<Rigidbody2D>();
    }
	// Update is called once per frame
	void Update () {
        if (ie )
        {
            Xd = gameObject.transform.position.x - (Obj.transform.position.x + rrb.velocity.magnitude * time);

            if (Xd < 0) Xd = -Xd;
            Yd = gameObject.transform.position.y - Obj.transform.position.y;
            if (Yd < 0) Yd = -Yd;
            speedx = Xd / time;
            speedy = (Yd + gravitiy * time * time * 0.5f) / time;
            if (gameObject.transform.position.x - Obj.transform.position.x > 0)
                rb.velocity = new Vector2(-speedx, speedy);
            else
            {

                rb.velocity = new Vector2(speedx, speedy);
            }
            Debug.Log(gameObject.GetComponent<Rigidbody2D>().velocity);
            ie = false;
        }
    }
}
