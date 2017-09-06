﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour {
	Player player;

	// Use this for initialization
	void Start () {
		player = GetComponent<Player> ();
	}
	
	// Update is called once per frame

	void PowerShot(){
		StartCoroutine (PowerShotStart());
	}

	void Shield(){
		/*
		 *set shield sbg child player
		 *shield selalu ngikut player
		 *set skill window active
		 *wait for'duration'
		 *set skill non-active
		*/

	}

	IEnumerator PowerShotStart(){
		player.skillActive = true;
		yield return new WaitForSeconds (5f);
		player.skillActive = false;
	}

}