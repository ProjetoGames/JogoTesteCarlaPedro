using UnityEngine;
using System.Collections;

public class MovimentoNuvens : MonoBehaviour {

	public GameObject este;
	public float xFinal;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		transform.position += new Vector3 ( -2 , 0 , 0)* Time.deltaTime;
		if(transform.position.x < xFinal){
			este.SetActive(false);
		}
	
	}

}
