using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeyIamHere : MonoBehaviour
{

	public int key = -1;
	int counter = 0;

    // Start is called before the first frame update
    void Start()
    {
		if (key == -1) {
			key = gameObject.GetInstanceID();
		}
    }

    // Update is called once per frame
    void Update()
    {
		Debug.Log(key.ToString() + "-" + gameObject.name + " Count:" + counter);
		counter++;
    }
}
