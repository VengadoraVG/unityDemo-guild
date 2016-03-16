using UnityEngine;
using System.Collections;

public class BulletDeath : MonoBehaviour {
    
    public float MaximumLifetime = 20; // segundos
    public float CurrentLifetime; // segundos

    // Use this for initialization
    void Start () {
	CurrentLifetime = MaximumLifetime;
    }
	
    // Update is called once per frame
    void Update () {
	CurrentLifetime -= Time.deltaTime;
        if (CurrentLifetime < 0) {
            Destroy(this.gameObject);
        }
    }
}
