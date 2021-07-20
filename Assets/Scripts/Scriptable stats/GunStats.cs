using UnityEngine;

public class GunStats : ScriptableObject
{
    public enum bulletTypes 
    {
        normal = 0,
        fire
    }
    public bulletTypes ThisBulletType;  // IF APPLICABLE Type of damage the item deals

    public string objectName;           // Name of object (gun/item)

    public int damage;                  // How much damage 1 bullet does
    public int magSize;                 // How many bullets before reloading
    public float bulletSpeed;           // Speed that the bullet travels at
    public float rateOfFire;            // How many bullets are shot per second
    public float reloadSpeed;           // Time that it takes to reload the gun (in seconds)

    public float aOERadius;             // IF APPLICABLE the size of the explosion the bullet creates upon hitting something
}
