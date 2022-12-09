using System;
using System.Collections;

using UnityEngine;

namespace SpaceGame
{
	public class RocketMovement : MonoBehaviour
	{
		[SerializeField, Range(0, 40)] float speed;
		[SerializeField] private GameObject moon;
		private bool engineOn = true;
		private Rigidbody body;
		private float gravitationPullRange;


		private void Start()
		{
			gravitationPullRange = 75f + moon.transform.localScale.x;
			body = gameObject.GetComponent<Rigidbody>();
		}

		private void FixedUpdate()
		{
			if(engineOn)
			{
				body.AddForce(transform.up * speed, ForceMode.Acceleration);
			}
			else
			{
				body.AddForce(-transform.up * 0.5f);
			}

			
			if(Physics.Raycast(new Vector3(gameObject.transform.position.x, transform.position.y - 2, transform.position.z + 5.0f), transform.up);
			{
				engineOn = false;

				
				//StartCoroutine(LandRocket());
			}
		}

		/*private IEnumerator LandRocket()
		{
			Vector3 rocketToMoon = (gameObject.transform.position - moon.transform.position).normalized;
			
			float t = 0;
			float rotTime = 0.75f;
			


			Quaternion starRot = gameObject.transform.rotation;
			Quaternion endROt = Quaternion.Euler(rocketToMoon.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z);


			while(t < rotTime)
			{
				gameObject.transform.rotation = Quaternion.Slerp(starRot, endROt, t / rotTime);

				yield return null;

				t += Time.deltaTime;
			}

			Debug.Log("finished");
		}*/
	}
}