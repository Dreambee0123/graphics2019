using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    public float xMin, xMax, zMin, zMax;
    public float startTime;
    private float CountTime;
    public GameObject zidan1;

   

    GameController g;
    // Use this for initialization
    void Start() {
        CountTime = startTime;
        g = GameObject.Find("GameObject").GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update() {
        feijimove();
        zidanslh();


    }


    void feijimove() {
        float MoveH = Input.GetAxis("Horizontal");
        float MoveV = Input.GetAxis("Vertical");
        transform.Translate(new Vector3(MoveH, 0, MoveV) * Time.deltaTime * 5, Space.World);
        if (transform.position.x <= xMin) {
            transform.position = new Vector3(xMin, 0, transform.position.z);
        }
        if (transform.position.x >= xMax) {
            transform.position = new Vector3(xMax, 0, transform.position.z);
        }
        if (transform.position.z <= zMin) {
            transform.position = new Vector3(transform.position.x, 0, zMin);
        }
        if (transform.position.z >= zMax) {
            transform.position = new Vector3(transform.position.x, 0, zMax);
        }
    }

    void zidanslh() {
        CountTime = CountTime - Time.deltaTime;
        if (Input.GetButtonDown("Fire1") && CountTime <= 0) {
            Instantiate(zidan1, transform.position, zidan1.transform.rotation);
            CountTime = startTime;
        }

    }
    private void OnTriggerEnter(Collider other) {
       
        if (other.tag != "Player"/*&&other .tag!="PlayerBullet"*/) {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
            g.JiaZai();
        }
    }

}



