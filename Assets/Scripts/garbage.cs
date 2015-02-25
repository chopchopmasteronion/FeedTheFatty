using UnityEngine;
using System.Collections;

public class garbage : MonoBehaviour {
	private ParticleSystem particle;
	// Use this for initialization
	void Start () {
		particle = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
		if(particle)
		{
			if(false == particle.IsAlive())
			{
				Destroy(gameObject);
			}
		}
	}
}
