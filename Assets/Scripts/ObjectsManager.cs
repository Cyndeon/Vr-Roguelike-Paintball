using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsManager : MonoBehaviour
{
    public static ObjectsManager instance;
    private void Awake()
    {
        instance = this;
    }

    public GameObject damageNumberObject;
}
