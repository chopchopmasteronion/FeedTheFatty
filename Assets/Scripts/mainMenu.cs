using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {
	public void isPressed(string option)
	{
	Application.LoadLevel(option);	
	}
	
}
