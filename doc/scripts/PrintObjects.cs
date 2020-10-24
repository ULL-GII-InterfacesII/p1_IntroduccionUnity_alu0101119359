using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintObjects : MonoBehaviour
{

	private Hashtable objects = new Hashtable();
	private Hashtable counter = new Hashtable();

	// Start is called before the first frame update
	void Start()
    {
		GameObject[] rootObjects = gameObject.scene.GetRootGameObjects() ;

		int key = 0;
		foreach (GameObject child in rootObjects)
		{
			objects.Add(key, child);
			counter.Add(key, 0);
			key++;
		}

		foreach (DictionaryEntry de in objects)
		{
			Debug.Log( de.Key.ToString() +"-"+ de.Value.ToString() +" "+ counter[de.Key].ToString());
		}

    }

    // Update is called once per frame
    void Update()
    {
    }
}
