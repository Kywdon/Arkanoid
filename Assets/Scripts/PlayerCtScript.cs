using UnityEngine;
using System.Collections;

public class PlayerCtScript : MonoBehaviour {

	private Vector3 p_position;
	public int speed;
	public float zconstraint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate (){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		transform.Translate (0, 0, (- moveHorizontal * Time.deltaTime * speed));
		p_position = this.transform.position;
		
		if (p_position.z < - zconstraint) {
			transform.position = new Vector3 (p_position.x, p_position.y, -zconstraint);
		} 
		if (p_position.z > zconstraint) {
			transform.position = new Vector3(p_position.x, p_position.y,zconstraint);     
		}
	}
}
