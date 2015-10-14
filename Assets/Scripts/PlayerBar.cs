using UnityEngine;
using System.Collections;

public class PlayerBar : MonoBehaviour {

	private int speed;
	private bool isUp, isDown;

	public KeyCode up, down;

	void Start () {
		speed = 5;
	
	}
	
	void Update () {
		if(Input.GetKeyDown(up))
			isUp = true;
		if(Input.GetKeyUp(up))
			isUp = false;
		if(Input.GetKeyDown(down))
			isDown = true;
		if(Input.GetKeyUp(down))
			isDown = false;

		if(isUp)
			transform.Translate(Vector3.up * speed * Time.deltaTime);
		if(isDown)
			transform.Translate(Vector3.down * speed * Time.deltaTime);

		if(transform.position.y > 4.5)
			transform.position = new Vector3(transform.position.x, 4.5f, 0);
		if(transform.position.y < -4)
			transform.position = new Vector3(transform.position.x, -4f, 0);
	}
}
