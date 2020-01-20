using UnityEngine;
using System.Collections;

public class enemyplane : MonoBehaviour {
    public float startTime;
    private float CountTime;
    public GameObject zidan2;
    public float speed2;
    public GameObject explo;
    // Use this for initialization
    void Start() {
        CountTime = startTime;
        Destroy(gameObject, 6.0f);

    }

    // Update is called once per frame
    void Update() {
        zidanslh();
        transform.Translate(transform.forward * Time.deltaTime * speed2);
    }



    private void OnTriggerEnter(Collider other) {
        if (other.tag != "Enemy") {
            Instantiate(explo,transform.position,Quaternion.identity);
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }

    //void creatEnemy()
    //{
    //    float x = Random.Range(-4.3f, 4.3f);
    //    Instantiate(gameObject, new Vector3(x, transform.position.y, 7.0f), Quaternion.identity);
    //}

    void zidanslh() {
        CountTime = CountTime - Time.deltaTime;
        if (CountTime <= 0) {
            Instantiate(zidan2, transform.position, zidan2.transform.rotation);
            CountTime = startTime;
        }
    }
}
