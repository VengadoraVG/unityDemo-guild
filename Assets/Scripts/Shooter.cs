using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Shooter : MonoBehaviour {

    public ParticleSystem Smog;
    public GameObject BulletPrototype;

    public float ShootCooldown = 2;
    public float ElapsedShootCooldown;

    public Transform BulletInitialPosition;

    private List<GameObject> myBullets;

    void Start () {
        ElapsedShootCooldown = ShootCooldown;
        myBullets = new List<GameObject>();
    }
	
    void Update () {
        ElapsedShootCooldown -= Time.deltaTime;
	if (ElapsedShootCooldown < 0) {
            ElapsedShootCooldown = ShootCooldown;
            Shoot();
        }
    }

    public void Shoot () {
        GameObject bullet = Instantiate(BulletPrototype);
        myBullets.Add(bullet);
        bullet.transform.position = BulletInitialPosition.position;
        bullet.transform.rotation = transform.rotation;
    }
}
