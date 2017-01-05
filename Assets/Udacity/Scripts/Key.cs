using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour 
{
    //Create a reference to the KeyPoofPrefab and Door
	public GameObject keyPoof;
	public GameObject door;

	void Update()
	{
		//Bonus: Key Animation
	}

	public void OnKeyClicked()
	{
        // Instatiate the KeyPoof Prefab where this key is located
		// Make sure the poof animates vertically
		Object.Instantiate(keyPoof, transform.position, Quaternion.Euler(270, 0, 0));

        // Call the Unlock() method on the Door
		door.GetComponent<Door>().Unlock();

        // Destroy the key. Check the Unity documentation on how to use Destroy
		Destroy(gameObject);
    }

}
