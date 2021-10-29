using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class PassiveItem : MonoBehaviour
{
    [Header("Gun Stat Boosts")]
    public float attackSpeedBoost;
    public float attackDamageBoost;
    public float attackShotSpeedBoost;

    [Header("Player Stat Boosts")]
    public float playerHealthBoost;
    public float playerSpeedBoost;

    PlayerManager pM; // used to call to certain functions used by the player

    public virtual void OnEquip()
    {
        pM = FindObjectOfType<PlayerManager>();
        ChangeStats();
    }

    public virtual void OnUnequip()
    {
        ChangeStats(false);
    }

    public virtual void OnShoot()
    {

    }
    public virtual void OnRoomClear()
    {

    }
    public virtual void OnEnemyHit()
    {

    }
    public virtual void OnEnemyKill()
    {

    }
    /// <summary>
    /// Add or subtract stat boosts
    /// </summary>
    /// <param name="_add">Whether the stats will be added or subtracted</param>
    void ChangeStats(bool _add = true)
    {
        if (pM == null) Debug.LogError("PLAYER MANAGER NOT FOUND WHILE ADDING STATS");
        // add gun stats, then player stats
        pM.attackSpeed += _add == true ? attackSpeedBoost : -attackSpeedBoost;
        pM.attackDamage += _add == true ? attackDamageBoost : -attackDamageBoost;
        pM.attackShotSpeed += _add == true ? attackShotSpeedBoost : -attackShotSpeedBoost;

        pM.playerHealth += _add == true ? playerHealthBoost : -playerHealthBoost;
        pM.playerSpeed += _add == true ? playerSpeedBoost : -playerSpeedBoost;
    }
}
