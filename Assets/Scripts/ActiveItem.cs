using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class ActiveItem : MonoBehaviour
{
    float damageAdd = 5f;
    float secondsActive = 5f;
    float secondsCooldown = 4f;

    bool onCooldown = false;
    private void Start()
    {
        ChangeMaterialColor(Color.green);
    }
    public void Activate()
    {
        if (onCooldown) return;
        onCooldown = true;
        PlayerManager.instance.attackDamage += damageAdd;
        ChangeMaterialColor(Color.blue);
        StartCoroutine(WaitForDeactivation());
    }
    IEnumerator WaitForDeactivation()
    {
        // wait for item to go on cooldown
        yield return new WaitForSeconds(secondsActive);
        // item goes on cooldown
        PlayerManager.instance.attackDamage -= damageAdd;
        ChangeMaterialColor(Color.red);

        // item can be activated again
        yield return new WaitForSeconds(secondsCooldown);
        ChangeMaterialColor(Color.green);
        onCooldown = false;
    }

    void ChangeMaterialColor(Color _color)
    {
        gameObject.GetComponent<Renderer>().sharedMaterial.color = _color;
    }
}
