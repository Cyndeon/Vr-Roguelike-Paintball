using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public static PlayerManager instance;
    private void Awake()
    {
        instance = this;
    }
    //-------------------------------------------------------------------------------------------
    //-------------------------------------------------------------------------------------------
    [Header("Gun Stats")]
    public float attackSpeed;
    public float attackDamage;
    public float attackShotSpeed;

    [Header("Player Stats")]
    public float playerHealth;
    public float playerSpeed;
}
