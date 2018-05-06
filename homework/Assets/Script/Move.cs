

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {
 
    [SerializeField]
    private float speed;
    [SerializeField]
    private float dispalcement;
    public float alpha = 0;
    // Use this for initialization
    void Start () {
      
		
	}
	
	// Update is called once per frame
	void Update () {
        PMove();
    }
    public void PMove()
    {
        transform.localPosition = new Vector3(Mathf.PingPong(alpha, dispalcement), 0, 0);
        alpha += speed;

    }
    
}
