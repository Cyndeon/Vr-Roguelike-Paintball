using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunStats
{
    enum bulletTypes 
    {
        normal = 0,
        fire
    }

    public int damage;
    public int magSize;
    public float reloadSpeed;
    public float rateOfFire;
    public float aOERadius;
}
