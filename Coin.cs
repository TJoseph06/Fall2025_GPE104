using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehavior
{
	public int value;
	void Start()
	{

	}
	void Update()
	{

	}
	void OnTriggerEnter2D(Collider2D Other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			Destroy(gameObject);
		}
	}

}
