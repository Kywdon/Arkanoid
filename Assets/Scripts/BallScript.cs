using UnityEngine;
using System.Collections;

public class BallScript : MonoBehaviour {

	//public Vector3 startForce;
	public int speed;
	private Vector3 Changes;
	private bool isActive;
	private Vector3 currentVelocity;
	
	// Use this for initialization
	void Start () {
		isActive = false;
		currentVelocity = new Vector3 (20, 0, 10);
	}

	void FixedUpdate(){
		if (Input.GetKeyDown("space") == true) {
			if (isActive == false){
				Debug.Log ("ISACTIVELOOP");
				isActive = !isActive;
				this.rigidbody.velocity = currentVelocity;
			}
			else {
				Debug.Log ("isnotactiveloop");
				isActive = !isActive;
				currentVelocity = this.rigidbody.velocity;
				this.rigidbody.velocity= new Vector3(0,0,0);
			}
		}
	}

	private void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name != "Ground"){
			Changes = Vector3.Reflect (- collision.relativeVelocity, collision.contacts[0].normal);
			if (collision.gameObject.name == "Player"){
				this.rigidbody.velocity = (Changes.normalized * speed);
			}
			else if (collision.gameObject.tag == "Brick") {
				Destroy (collision.gameObject);
			}
		}
	}
}
