using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeed : MonoBehaviour {
    [SerializeField]
    private float speedx;
    private Rigidbody2D rb;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speedx,0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
