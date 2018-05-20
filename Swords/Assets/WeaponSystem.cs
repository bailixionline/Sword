using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour {

    public Transform[] weaponPositions = {};
    public WeaponData[] weapons = {null,null,null,null,null};

    public PlayerData pd;

    // Use this for initialization
    void Start () {
        pd = GameObject.Find("PlayerData").GetComponent<PlayerData>();
        //Debug.Log("WeaponSystem: BeforeUpdateWeapon");
        UpdateWeapon();
        //Debug.Log("WeaponData Lenth in WeaponSystem: " + weapons.Length);
    }

    private void UpdateWeapon()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i<pd.weaponPrefabs.Length )
            {
                if (pd.weaponPrefabs[i] != null)
                {
                    weapons[i] = new WeaponData(pd.weaponPrefabs[i], pd.weaponDamages[i], pd.weaponSpeeds[i],pd.weaponCoolDownSpeed[i]);
                    Debug.Log("Player weapon " + i + ": Prefab_" + weapons[i].prefab + " damage_" + weapons[i].weaponDamage + " speed_" + weapons[i].weaponSpeed + " cooldown_" + weapons[i].coolDownSpeed);
                }
            }
            //Debug.Log("WeaponSystem: UpdateWeapon " +i+ " finished.");
        }

    }

    // Update is called once per frame
    void Update () {
		
	}
}
