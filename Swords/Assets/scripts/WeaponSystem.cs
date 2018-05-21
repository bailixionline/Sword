using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour {

    public Transform[] weaponPositions;
    [SerializeField]
    public WeaponData[] weapons;
    public PlayerData pd;

    // Use this for initialization
    void Start () {
        UpdateWeapon();
    }

    private void UpdateWeapon()
    {
        for (int i = 0; i < 5; i++)         
        {
            if(pd.wd[i] != null)
                weapons[i] = pd.wd[i];
        }
    }

    // Update is called once per frame
    void Update () {		
	}
}
