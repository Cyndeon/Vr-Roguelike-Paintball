using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxHit : MonoBehaviour
{
    Health hp;
    [SerializeField] float damageMultiplier = 1f;
    private void Start()
    {
        hp = GetComponentInParent<Health>();
    }
    public void TakeDamage(float _damage)
    {
        _damage = _damage * damageMultiplier;
        hp.ChangeHealth(_damage);
        GameObject dmgNumbers = Instantiate(ObjectsManager.instance.damageNumberObject.gameObject, gameObject.transform.position + new Vector3(.1f, 1.5f, 0), transform.rotation);
        dmgNumbers.GetComponentInChildren<UnityEngine.UI.Text>().text = _damage.ToString();
    }
}
