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

    float weaponCooldown_1,weaponCooldown_2,weaponCooldown_3,weaponCooldown_4,weaponCooldown_5;
    // Use this for initialization
    void Start () {
        rg = gameObject.GetComponent<Rigidbody2D>();
	}

    private void Update()
    {
        WeaponOneCheck();
        WeaponTwoCheck();
        WeaponThreeCheck();
        WeaponFourCheck();
        WeaponFiveCheck();
    }

    void WeaponOneCheck()
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
    void WeaponTwoCheck()
    {
        weaponCooldown_2 -= 1;
        if (Input.GetKey(KeyCode.Alpha2) && weaponCooldown_2 <= 0)
        {
            Debug.Log("button pressed 2");
            if (ws != null)
            {
                Instantiate(ws.weapons[1].prefab, ws.weaponPositions[1].position, ws.weaponPositions[1].rotation);
                weaponCooldown_2 = ws.weapons[1].coolDownSpeed;
                Debug.Log("shoot 2");
            }
        }
    }
    void WeaponThreeCheck()
    {
        weaponCooldown_3 -= 1;
        if (Input.GetKey(KeyCode.Alpha3) && weaponCooldown_3 <= 0)
        {
            Debug.Log("button pressed 3");
            if (ws != null)
            {
                Instantiate(ws.weapons[2].prefab, ws.weaponPositions[2].position, ws.weaponPositions[2].rotation);
                weaponCooldown_3 = ws.weapons[2].coolDownSpeed;
                Debug.Log("shoot 3");
            }
        }
    }
    void WeaponFourCheck()
    {
        weaponCooldown_4 -= 1;
        if (Input.GetKey(KeyCode.Alpha4) && weaponCooldown_4 <= 0)
        {
            Debug.Log("button pressed 4");
            if (ws != null)
            {
                Instantiate(ws.weapons[3].prefab, ws.weaponPositions[3].position, ws.weaponPositions[3].rotation);
                weaponCooldown_4 = ws.weapons[3].coolDownSpeed;
                Debug.Log("shoot 4");
            }
        }
    }
    void WeaponFiveCheck()
    {
        weaponCooldown_5 -= 1;
        if (Input.GetKey(KeyCode.Alpha5) && weaponCooldown_5 <= 0)
        {
            Debug.Log("button pressed 5");
            if (ws != null)
            {
                Instantiate(ws.weapons[4].prefab, ws.weaponPositions[4].position, ws.weaponPositions[4].rotation);
                weaponCooldown_5 = ws.weapons[4].coolDownSpeed;
                Debug.Log("shoot 5");
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
 