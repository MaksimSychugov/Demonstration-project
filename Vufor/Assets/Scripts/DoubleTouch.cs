using UnityEngine;
using System.Collections;

public class DoubleTouch : MonoBehaviour {

	Quaternion beginTransform;
	Vector3 beginScale;

	void Start () {
		beginTransform = transform.rotation;
		beginScale = transform.localScale;
	}


	void Update () {
		foreach(Touch touch in Input.touches){
			if(touch.tapCount == 2){
				transform.rotation = beginTransform;
				transform.localScale = beginScale;
			}
		}
	}

}