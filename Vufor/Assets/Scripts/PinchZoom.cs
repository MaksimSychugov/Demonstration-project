using UnityEngine;
using System.Collections;

public class PinchZoom : MonoBehaviour
{


	public float zoomSpeed = 0.01f;

	Vector3 tempScaleX;

	void Update()
	{

		if (Input.touchCount == 2)
		{

			Touch touchZero = Input.GetTouch(0);
			Touch touchOne = Input.GetTouch(1);

	
			Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
			Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

			float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
			float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

			float deltaMagnitudeDiff = prevTouchDeltaMag - touchDeltaMag;

			transform.localScale -= new Vector3(zoomSpeed, zoomSpeed, zoomSpeed)*deltaMagnitudeDiff;
			if (transform.localScale.x > 0.5f) {
				transform.localScale = new Vector3 (0.5f, 0.5f, 0.5f);

			}
			if (transform.localScale.x < 0.1f) {
				transform.localScale = new Vector3 (0.1f, 0.1f, 0.1f);
			}
	

		}

	}



}