using UnityEngine;
using System.Collections;

public class Zidan2move : MonoBehaviour {
    public float bulletspeed2;
    public GameObject explo;
    
    void Start() {
        Destroy(gameObject, 6.0f);
        
    }


    void Update() {
        transform.Translate(Vector3.back * Time.deltaTime * bulletspeed2, Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag != "Enemy") {
            Instantiate(explo, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            
        }
       
        }
    }

