using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateControler1 : MonoBehaviour {
	public Animator anim; 

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>(); 	
	}

	// Update is called once per frame
	void Update ()
	{
		if (Input.GetKeyDown ("o")) {
			anim.Play ("Opentop");
		}
		{
			if (Input.GetKeyDown ("c")) {
				anim.Play ("Closetop");
			}
		}
	}
}
