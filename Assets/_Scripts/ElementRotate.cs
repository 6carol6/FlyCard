﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(15,30,35) * Time.deltaTime);
	}
}