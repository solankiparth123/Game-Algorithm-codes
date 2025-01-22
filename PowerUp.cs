using UnityEngine;

public class PowerUp : MonoBehaviour {

    public float multiplier = 1.4f;
    public GameObject PickupEffect;

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            Pickup(other);
        }
    }

    void Pichup(Collider Player) {
        //Unity Particle Pack Import in assets for destory event 
        Instantiate(PickupEffect, transform.position, transform.rotation);

        //Player.transform.localScale *= multiplier

        PlayerStats stats = Player.GetComponent<PlayerStats>();
        stats.health *= multiplier;

        Destroy(gameObject);
    }

    /* make one file PlayerStats 
    and add public float health = 100f;

    public class PlayerStats : MonoBehaviour {
        public float health = 100f;
    }


    */
}