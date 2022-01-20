using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(XRGrabInteractable))]
public class GunBehavior : MonoBehaviour
{
    [SerializeField] Transform m_shootingPoint;
    [SerializeField] GameObject m_bulletPrefab;
    [SerializeField] float bulletSpeed;

    PlayerManager player;

    private void Start()
    {
        player = PlayerManager.instance;

        bulletSpeed = bulletSpeed <= 0 ? 1 : player.attackShotSpeed;
    }

    public void Shoot()
    {
        GameObject _bullet = Instantiate(m_bulletPrefab, m_shootingPoint.position, transform.rotation);
       
        //_bullet.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
    }
}
