using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour {

    public WeaponData[] wd = {null, null, null, null, null };

    public GameObject[] weaponPrefabs;
    public float[] weaponDamages;
    public float[] weaponSpeeds;
    public float[] weaponCoolDownSpeed;
    // Use this for initialization
    void Start () {
        UpdateWeaponSystem();
        Debug.Log("WeaponData Lenth in PlayerData: " +wd.Length);
    }

    protected void UpdateWeaponSystem()
    {
        for (int i = 0; i < 5; i++)
        {
            if (i < weaponPrefabs.Length)
            {
                if (weaponPrefabs != null && weaponPrefabs[i] != null)
                {
                    wd[i] = new WeaponData(weaponPrefabs[i], weaponDamages[i], weaponSpeeds[i], weaponCoolDownSpeed[i]);
                    Debug.Log("Player data weapon " + i + ": damage_" + wd[i].weaponDamage + " speed_" + weaponSpeeds[i] + " cooldown_" + weaponCoolDownSpeed[i]);
                }
            }
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
