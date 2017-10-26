using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GobalGravity : MonoBehaviour 
{
	public CharacterController Map;



	// Use this for initialization
	void Start () 
	{
		Map = GetComponent<CharacterController> ();
	}
	
	// Update is called once per frame
	void Update ()
	{

		if (Input.GetKeyDown (KeyCode.UpArrow)) 
		{
			Map.transform.Rotate (90, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.DownArrow)) 
		{
			Map.transform.Rotate (-90, 0, 0);
		}

		if (Input.GetKeyDown (KeyCode.RightArrow)) 
		{
			Map.transform.Rotate (0, 0, 90);
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) 
		{
			Map.transform.Rotate (0, 0, -90);
		} 
			
	}
}
