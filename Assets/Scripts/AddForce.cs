using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    [SerializeField] int _force;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(transform.forward * _force);
    }


    private void OnCollisionEnter(Collision collision)
    {
        HitboxHit hit = collision.gameObject.GetComponent<HitboxHit>();
        if (!hit) return;
        if (!hit.CompareTag("Gun"))
        {
            int damage = Mathf.RoundToInt(PlayerManager.instance.attackDamage);
            hit.TakeDamage(damage);

        }
    }
}
