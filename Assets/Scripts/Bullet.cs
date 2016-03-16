using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    
    public ParticleSystem explosion;

    public float speed = 100; // unidades de unity por segundo

    void Start () {
        
    }
	
    void Update () {
	transform.position = transform.position + transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter (Collider c) {
        ParticleSystem myExplosion = Instantiate(explosion);
        myExplosion.transform.position = transform.position;
        myExplosion.Play();
        Destroy(this.gameObject);
    }
}
