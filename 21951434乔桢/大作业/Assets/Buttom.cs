using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Buttom : MonoBehaviour {
    public Text a;
    int i = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void B() {
        i++;
        if (i % 2 != 0) {
            Time.timeScale = 0;
            a.text = "继续";
        } else {
            Time.timeScale = 1;
            a.text = "暂停";
        }
    }
}
