using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour {

    [SerializeField]
    private float bounc;
    //public GameObject player;
    private Rigidbody rb;
    // Use this for initialization
     public void Start()
    {
        rb = GetComponent <Rigidbody>();
        //Get Component
    }
    void OnCollisionEnter(Collision a)
     {
        float timer = 0;
        float count = 0;
      print(message: "Bounce");
      // timer += Time.deltaTime;
        rb.AddForce(9.8f*4 * bounc * Vector2.up) ;
           /// count++;
           // timer = 0;

        
            
            
            
     }
  

}
   
      


