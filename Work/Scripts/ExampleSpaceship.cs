using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour {

 	//these numbers are floating point numbers, fine nimbers, speed location, specific numbers
	public float myFirstFloat;
	public float mySecondFloat = 2;
	public float myThirdFloat = 5.3f;
	private float myForthFloat = 364;

	//whole numbers
	public int myFirstInt;
	public int mySecondInt = -3;

	//Strings - series of numbers or letters, cant add it, not considered a number
	public string myString;
	public string mySecondString = "Hello";

	//other variable types
	public Color myColour;
	public bool myBool; //yes or no
	public char myChar; // single character, a, I, 4, N
	public Vector2 myVector2; //2d games
	public Vector3 myVector3; //usual game
	public Vector4 myVector4; //crazy, look into future
	public List<float> myFloatList; //lists are collections,
	public List<int> myIntList;
	public List<Color> myColourList;
	public List<Vector3> myVectorList;

	// Update is called once per frame
	void Update () {
		
	}
}
