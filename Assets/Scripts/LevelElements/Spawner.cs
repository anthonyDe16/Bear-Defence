﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public void Spawn(GameObject objectToSpawn) {
		
		Instantiate (objectToSpawn, transform);
		return;
	}
}
