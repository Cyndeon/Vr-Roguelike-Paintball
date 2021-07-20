using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class Gun : MonoBehaviour
{
    [SerializeField] Transform m_shootingPoint;
    [SerializeField] GameObject m_bulletPrefab;
    [SerializeField] CommonGun gunStats;
    [SerializeField] float bulletSpeed;

    private void Start()
    {
        bulletSpeed = gunStats.bulletSpeed;
    }

    public void Shoot()
    {
        GameObject _bullet = Instantiate(m_bulletPrefab, m_shootingPoint.position, transform.rotation);
        _bullet.GetComponent<Rigidbody>().AddForce(m_shootingPoint.forward * bulletSpeed);
    }
}
