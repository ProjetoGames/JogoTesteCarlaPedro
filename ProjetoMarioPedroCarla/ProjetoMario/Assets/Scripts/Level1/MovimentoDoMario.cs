using UnityEngine;
using System.Collections;

public class MovimentoDoMario : MonoBehaviour {

	public Transform spritePlayer;
	private Animator animator;

	// Use this for initialization
	void Start () {
	
		animator = spritePlayer.GetComponent<Animator> ();
		//animator.SetBool("fG", false);
		//animator.SetBool("aP", false);
		transform.rotation = new Quaternion(0,0,0,0);
		
	}
	
	// Update is called once per frame
	void Update () {



		if (Input.GetKey ("right")) {
			transform.rotation = new Quaternion(0,0,0,0);

			animator.SetBool ("paradoPequenoParaAndar", true);
			transform.position += new Vector3(0.05f , 0, 0);
		}else if (Input.GetKey ("left")) {
			transform.rotation = new Quaternion(0,180,0,0);

			animator.SetBool ("paradoPequenoParaAndar", true);
			transform.position += new Vector3(-0.05f , 0, 0);
		}else {
			animator.SetBool ("paradoPequenoParaAndar", false);
		}

	

		//Debug.Log (animator.GetBool("fG") + " fG");
		//Debug.Log (animator.GetBool("aP") + " ap");

	}


	void OnTriggerEnter2D(Collider2D col){
		
		Debug.Log (col.ToString());

		if(col.ToString().Equals("cogumelo (UnityEngine.CircleCollider2D)")){

			animator.SetBool ("paradoPequenoParaGrandeParado", true);


		}
		
	}
}
