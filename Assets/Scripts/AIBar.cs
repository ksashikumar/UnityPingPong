using UnityEngine;
using System.Collections;

public class AIBar : MonoBehaviour {

	public Transform ball;

	private float offset;

	void Start () {
	
	}
	
	void Update () {
		offset = ball.transform.position.y - transform.position.y;
		transform.Translate(new Vector3(0, offset, 0));

		if(transform.position.y > 4.5)
			transform.position = new Vector3(transform.position.x, 4.5f, 0);
		if(transform.position.y < -4)
			transform.position = new Vector3(transform.position.x, -4f, 0);

	}
}
