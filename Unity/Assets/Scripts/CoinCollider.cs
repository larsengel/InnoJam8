﻿using UnityEngine;
using System.Collections;

public class CoinCollider : MonoBehaviour {
	void OnTriggerEnter(Collider other) {
		Destroy (this.gameObject);
	}
}
