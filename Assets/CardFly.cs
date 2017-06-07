using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardFly : MonoBehaviour {

    public int speed;
    public int amplitude;
    public float omega;

    private float initZ;
    private float prevY;

	// Use this for initialization
	void Start () {
        initZ = transform.position.z;
        prevY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, amplitude*Mathf.Sin(omega*(transform.position.z-initZ)) - prevY, Time.deltaTime * speed);
        prevY = transform.position.y;
    }

    private void FixedUpdate()
    {
        
    }
}
