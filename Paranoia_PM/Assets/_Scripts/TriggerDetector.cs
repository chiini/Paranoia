using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerDetector : MonoBehaviour {


    public GameObject player;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player){
            Debug.Log("Player detected!!!");
            //GameOver();
        };
    }

    void GameOver(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void Start () {
		
	}
	
	void Update () {
		
	}
}
