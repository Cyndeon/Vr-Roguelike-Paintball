using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ScriptableObjectSwitch
{
    public static ScriptableObject GetObjectData(ScriptableObject _object)
    {
        switch (_object)
        {
            default:
                Debug.Log($"{_object.name} is not a valid type for the required action");
                return null;
                break;
        }
    }
}
