using UnityEngine;
using System.Collections;

public class move0 : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.back * Time.deltaTime * 5,Space.World);
        if (transform.position.z <= -30)
        {
            transform.position=new Vector3(transform.position.x, transform.position.y, 29);
        }
	}
}
