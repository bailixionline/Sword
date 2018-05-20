using UnityEngine;
using UnityEditor;

public class WeaponData
{ 
    public GameObject prefab;
    public float weaponDamage;
    public float weaponSpeed;
    public float coolDownSpeed;

    public WeaponData(GameObject prefab, float weaponDamage, float weaponSpeed, float coolDownSpeed)
    {
        this.prefab = prefab;
        this.weaponDamage = weaponDamage;
        this.weaponSpeed = weaponSpeed;
        this.coolDownSpeed = coolDownSpeed;
    }
}