using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

    //for movement
    public Rigidbody2D rg;
    public float speed=3;

	// Use this for initialization
	void Start () {
        rg = gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        rg.velocity = new Vector2(moveX * speed, moveY * speed);
	}
}
