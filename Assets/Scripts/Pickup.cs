using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    enum pickupTypes
    {
        Damage = 0,
        shotSpeed

    }
    [SerializeField] pickupTypes thisPickup; // the kind of pickup that will add stats to the player
    [SerializeField] UnityEngine.UI.Text pickupText;

    private void Start()
    {
        pickupText.text = thisPickup.ToString();
    }
    public void Collission()
    {
        switch (thisPickup)
        {
            case pickupTypes.Damage:
                PlayerManager.instance.attackDamage++;
                break;

            default:
                Debug.LogError("PICKUPTYPE NOT FOUND");
                break;
        }
        Destroy(gameObject);
    }
}
