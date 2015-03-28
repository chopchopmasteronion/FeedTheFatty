using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class gameOver : MonoBehaviour {
	public Text scoreText;
	private persistence ps;
	// Use this for initialization
	void Start () {
	ps = new persistence();
	scoreText.text = ps.writeScore();
	}
	
	// Update is called once per frame
	void Update () {

	}
}
