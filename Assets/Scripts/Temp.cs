using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(TempRoutine());
    }

    IEnumerator TempRoutine()
    {
        while (gameObject.activeSelf)
        {
            GameObject dmgNumber = Instantiate(ObjectsManager.instance.damageNumberObject, transform.position, Quaternion.identity);
            UnityEngine.UI.Text dmgTxt = dmgNumber.GetComponentInChildren<UnityEngine.UI.Text>();
            dmgTxt.text = UnityEngine.Random.Range(0, 101).ToString();
            yield return new WaitForSeconds(1);
        }
    }
}
