using UnityEngine;

public class playerMovement : MonoBehaviour {

	public Rigidbody playerRb;
	public float forwardForce;
	public float sidewayForce;
	
	// Update is called once per frame
	void FixedUpdate() {

		// start move forward
		playerRb.AddForce(0, 0, forwardForce * Time.deltaTime);

		// move right
		if(Input.GetKey("d")) {
			playerRb.AddForce(sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// move left
		if(Input.GetKey("a")) {
			playerRb.AddForce(-sidewayForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
		}

		// outside the boundary, end the game
		if(playerRb.transform.position.y < 0) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
