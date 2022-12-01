using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingSystem : MonoBehaviour
{

    [Header("Point where we initiate bullet")]
    [SerializeField] GameObject shootingPoint;

    [SerializeField] GameObject bulletPref;

    [SerializeField] float recoilTime;

    private void Start()
    {
        StartCoroutine(Shoot());
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            GameObject nBullet = Instantiate(bulletPref, shootingPoint.transform.position, Quaternion.identity);
            nBullet.GetComponent<BaseBulletScript>().SetDirection(BulletDirection());
            nBullet.SetActive(true);
            yield return new WaitForSeconds(recoilTime);
        }
        
    }

    private Vector2 BulletDirection()
    {
        return new Vector2(shootingPoint.transform.position.x - transform.position.x, shootingPoint.transform.position.y - transform.position.y);
    }

}
