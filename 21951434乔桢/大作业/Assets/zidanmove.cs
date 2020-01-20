using UnityEngine;
using System.Collections;

public class zidanmove : MonoBehaviour {
    public float bulletspeed;
    public GameController g;
    // Use this for initialization
    void Start() {
        Destroy(gameObject, 6.0f);
        g = GameObject.Find("GameObject").GetComponent<GameController>();
    }
    // Update is called once per frame
    void Update() {
        zdmove();
        
    }





    void zdmove() {
        transform.Translate(Vector3.back * Time.deltaTime * bulletspeed, Space.World);
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag != "Player") {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            g.Ssss();
        }
    }
}
