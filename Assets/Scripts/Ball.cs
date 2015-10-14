using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

	private bool play;
	private Vector3 direction;

	private float speed = 0.1f;

	private int aiScore;
	private int playerScore;

	private Vector3 temp;

	void Start () {
		aiScore = 0;
		playerScore = 0;
		GameObject.Find("Score").GetComponent<GUIText>().text = "0  :  0";
		Init ();
	
	}
	
	void Update () {

		GameObject.Find("Score").GetComponent<GUIText>().text = aiScore + "  :  " + playerScore + "";

		if(aiScore == 5 || playerScore == 5)
			Application.LoadLevel("GameOver");

		if(Input.GetKeyDown(KeyCode.Space))
			play = true;
		if(play) {
			temp = transform.position;
			temp = temp + direction * speed;
			transform.position = temp ;
		}
	
	}

	void Init() {
		play = false;
		direction = new Vector3(1.0f,1.0f,0).normalized;
		transform.position = new Vector3(0, 0, 0);
	}

	void OnCollisionEnter(Collision col) {
		direction = Vector3.Reflect(direction, col.contacts[0].normal);
		if (col.collider.name == "Left Wall"){
			playerScore++;
			Init();
			
		}
		else if (col.collider.name == "Right Wall"){
			aiScore++;
			Init();
		}
	}
}
