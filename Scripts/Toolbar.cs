using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toolbar : MonoBehaviour {
public GameObject tool1,tool2,tool3,highlight;
	void Update ()
	{
		if(Input.GetKey("1"))
		{
			tool1.SetActive(true);
			tool2.SetActive(false);
			tool3.SetActive(false);
			highlight.transform.localPosition = new Vector3(-117.5701f, -6.005005f, 0f);
		}
		if(Input.GetKey("2"))
		{
			tool1.SetActive(false);
			tool2.SetActive(true);
			tool3.SetActive(false);
			highlight.transform.localPosition= new Vector3(-2.570068f, -6.005005f, 0f);
		}
		if(Input.GetKey("3"))
		{
			tool1.SetActive(false);
			tool2.SetActive(false);
			tool3.SetActive(true);
			highlight.transform.localPosition = new Vector3(112.4299f, -6.005005f, 0f);
		}
	}
}
