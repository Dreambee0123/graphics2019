using UnityEngine;
using System.Collections;

public class StoneMove : MonoBehaviour {
    public GameObject explo;
    public float speed;
	void Start () {
        Destroy(gameObject, 6.0f);

    }

   
    void Update () {
        transform.Translate(Vector3.forward * Time.deltaTime * speed,Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag != "Enemy") {
            Instantiate(explo, transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
