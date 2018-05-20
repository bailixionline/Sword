using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2D : MonoBehaviour {

    //for movement
    Rigidbody2D rg;
    bool facingRight;
    public float speed;
    public float bootsTimes;
    public WeaponSystem ws;

    float weaponCooldown_1;
	// Use this for initialization
	void Start () {
        rg = gameObject.GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
        weaponCooldown_1 -= 1;
        if (Input.GetKey(KeyCode.Alpha1) && weaponCooldown_1 <= 0)
        {
            Debug.Log("button pressed 1");
            if (ws != null)
            {
                Instantiate(ws.weapons[0].prefab, ws.weaponPositions[0].position, ws.weaponPositions[0].rotation);
                weaponCooldown_1 = ws.weapons[0].coolDownSpeed;
                Debug.Log("shoot 1");
            }
        }
    }

    // Update is called once per frame
    void FixedUpdate () {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        bool boots = Input.GetButton("Fire3");

        HandleMovement(moveX, moveY,boots);
        Flip(moveX);
    }

    private void HandleMovement(float x,float y,bool boots)
    {
        rg.velocity = !boots? new Vector2(x * speed, y * speed): new Vector2(x * speed * bootsTimes, y * speed * bootsTimes);
    }

    private void Flip(float horizontal)
    {
        if (horizontal > 0 && !facingRight || horizontal <0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }
}
 