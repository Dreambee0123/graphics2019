using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    // Use this for initialization
    public GameObject[] enemy;
  
    bool a = false;
    bool b = false;
    public Text GameOver;
    public Text Restart;
    public Text Score;

    public float fenzhi=0;
	void Start () {
        StartCoroutine("Spawn");
        
        
	}

    // Update is called once per frame
    void Update() {

        Score.text = "得分：" + fenzhi.ToString();

        if (a == true) {
            GameOver.text = "Game  Over!!";
            Restart.text = "Press R To Restart";
            if (Input.GetKeyDown("r")) {
       SceneManager.LoadScene(0);
            }
        }

       


    }
    IEnumerator Spawn() {
        while (true) {
            int i = Random.Range(0, enemy.Length);
            Instantiate(enemy[i], new Vector3(Random.Range(-4.3f, 4.3f),0,7.0f),enemy[i].transform.rotation);
            yield return new WaitForSeconds(Random.Range(0.2f, 1.2f));
        }
        
    }

    
    public void  Ssss() {
        fenzhi = fenzhi +10;
    }



    public void JiaZai() {
        a = true;
           
        }
    }

    

