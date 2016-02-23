using UnityEngine;
using System.Collections;

public class RotationTouch : MonoBehaviour {

	bool vertical;
	bool horizontal;
	Vector3 startPos;

	void Start () {
		startPos = transform.position;
	}


	void Update () {
		if (Input.touchCount == 1) {
			var touch = Input.GetTouch(0);
			switch(Input.GetTouch(0).phase){
			case TouchPhase.Moved:
				float swipeDistVertical = (new Vector3(0, touch.deltaPosition.y, 0) - new Vector3(0, startPos.y, 0)).magnitude;              
				if (swipeDistVertical > 5)                  
				{                   
					float swipeValue = Mathf.Sign(touch.deltaPosition.y - startPos.y);                   
					if (swipeValue > 0 || swipeValue < 0)     
					{
						vertical = true;
						horizontal = false;
					}                               
				}               
				float swipeDistHorizontal = (new Vector3(touch.deltaPosition.x,0, 0) - new Vector3(startPos.x, 0, 0)).magnitude;             
				if (swipeDistHorizontal > 5)                    
				{                   
					float swipeValue = Mathf.Sign(touch.deltaPosition.x - startPos.x);                   
					if (swipeValue > 0 || swipeValue < 0)
					{
						horizontal = true;
						vertical = false;
					}                           
				}

				if(vertical)
				{
					transform.Rotate(touch.deltaPosition.y * 2, 0,0,Space.World);
				}
				if(horizontal)
				{
					transform.Rotate(0,touch.deltaPosition.x * -2,0,Space.World);
				}
				break;
			}
		}
	}
}
