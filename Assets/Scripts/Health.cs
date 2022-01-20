using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] float maxHealth = 1;
    [SerializeField] float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }
    public void ChangeHealth(float hpChange)
    {
        currentHealth -= hpChange;
        if (currentHealth <= 0)
        {
            die();
            return;
        }
        else if (currentHealth > maxHealth) currentHealth = maxHealth;

        GameObject dmgNumber = Instantiate(ObjectsManager.instance.damageNumberObject, transform.position, Quaternion.identity);
        UnityEngine.UI.Text dmgTxt = dmgNumber.GetComponentInChildren<UnityEngine.UI.Text>();
        dmgTxt.text = hpChange.ToString();
    }
    void die()
    {
        //would be added to a pool if one would exist
        gameObject.SetActive(false);
    }
}
