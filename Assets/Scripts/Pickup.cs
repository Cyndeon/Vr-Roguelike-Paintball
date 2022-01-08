using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    enum pickupTypes
    {
        GunDamage = 0,

    }
    [SerializeField] pickupTypes thisPickup; // the kind of pickup that will add stats to the player
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Hand"))
        {
            switch (thisPickup)
            {
                case pickupTypes.GunDamage:
                    PlayerManager.instance.attackDamage++;
                    break;

                default:
                    Debug.LogError("PICKUPTYPE NOT FOUND");
                    break;
            }
        }
    }
}
