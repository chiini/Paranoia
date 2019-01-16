using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameState : MonoBehaviour {

    public static GameState instance;

    public float progressNorm;
    public float xMin;
    public float xMax;
    public Transform Player;
    public GameObject Shadow;
    public float TransformX;

    private void Start()
    {
        instance = this;
        TransformX = Player.transform.position.x;
    }

    private void Update()
    {
        progressNorm = Mathf.InverseLerp(xMin,xMax, Player.transform.position.x);
        if (progressNorm == 1)
        {
            Shadow.SetActive(false);
        }
    }
}
