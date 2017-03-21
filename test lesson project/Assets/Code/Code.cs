using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    public float Speed;
    public Rigidbody rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody>();
        Speed = 15f;
        	
	}
	
	// Update is called once per frame
	void Update () {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(Horizontal, 0f, Vertical);
        rb.AddForce(direction * Speed);	
	}
}
