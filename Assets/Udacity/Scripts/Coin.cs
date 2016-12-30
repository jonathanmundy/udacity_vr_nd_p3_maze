﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour 
{
    //Create a reference to the CoinPoofPrefab
	public GameObject coinPoof;

    public void OnCoinClicked() {
        // Instantiate the CoinPoof Prefab where this coin is located
		Object.Instantiate(coinPoof, transform.position, Quaternion.Euler(-90, 0, 0 ));

        // Make sure the poof animates vertically
		//transform.position += Vector3.up * 20.0f;

        // Destroy this coin. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
