﻿using UnityEngine;
using System.Collections;

public class SpringBehavior : MonoBehaviour {

	private bool is_top = false;

	void OnTriggerEnter (Collider col)
	{
		if(col.gameObject.name == "Player")	{
			col.gameObject.GetComponent<PlayerMovement>().toggleFly(is_top);
		}
	}

	public void setIsTop(bool _bool) {
		is_top = _bool;
	}
}
