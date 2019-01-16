using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShadowScript : MonoBehaviour {

    public AnimationCurve curve;
    public float currentSpeed = 10f;
    public float currentProgress;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        currentProgress = GameState.instance.progressNorm;
        currentSpeed = curve.Evaluate(currentProgress);
        rb.velocity = new Vector3(1 * currentSpeed, 0, 0);
    }
}
