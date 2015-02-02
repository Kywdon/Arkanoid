using UnityEngine;
using System.Collections;

public class StartScript : MonoBehaviour {
	public Vector3 Gravity;

	// Use this for initialization
	void Start () {
		Physics.gravity = Gravity;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
