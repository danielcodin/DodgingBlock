using UnityEngine;

public class playerCollision : MonoBehaviour {

	public playerMovement playerMovement;

	void OnCollisionEnter(Collision collisionInfo) {

		if (collisionInfo.collider.tag == "Obstacle") {
			playerMovement.enabled = false;
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}
