﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewCanvas : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void CloseViewCanvas()
    {
        gameObject.SetActive(false);
    }

}
