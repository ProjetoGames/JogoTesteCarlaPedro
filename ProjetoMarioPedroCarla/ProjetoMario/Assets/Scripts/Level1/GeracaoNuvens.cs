using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GeracaoNuvens : MonoBehaviour {

	public GameObject nuvem;
	public List<GameObject> nuvens;
	public float xInicial;
	public float xFinal;
	public float yMaximo;
	public float yMinimo;
	private float contadorTempo;



	void Start () {

		for (int i=0; i< 6; i++) {
			
			GameObject temp = Instantiate (nuvem) as GameObject;
			temp.SetActive (false);
			nuvens.Add (temp);
			
		}
	
	}
	
	// Update is called once per frame
	void Update () {

		contadorTempo += Time.deltaTime;
		if(contadorTempo>5){
			contadorTempo=0;
			espalhar();
		}
	
	}

	private void espalhar ()
	{
		
		float rand = Random.Range (yMinimo,yMaximo);

		GameObject tempNuvem = null;
		
		for (int i=0; i< 6; i++) {
			
			if(!nuvens[i].activeSelf){
				tempNuvem=nuvens[i];
				break;
			}
		}
		
		if(tempNuvem!=null){
			tempNuvem.transform.position = new Vector3(xInicial, rand, tempNuvem.transform.position.z);
			tempNuvem.SetActive(true);
			
		}
		
		
	}

	/*
	public float alturaMax;
	public float alturaMin;
	private float tempo;
	private float contadorTempo;
	public int max;
	public GameObject prefab;
	public List<GameObject> blocos; // vai guarda os objetos que vamos jogar na tela
	
	

	// Update is called once per frame
	void Update ()
	{
		contadorTempo += Time.deltaTime;
		if(contadorTempo>tempo){
			contadorTempo=0;
			espalhar();
		}
		
	}
	
	private void espalhar ()
	{
		
		float rand = Random.Range (0,9);
		float randomico;
		GameObject tempBloco = null;
		
		if (rand < 5)
			randomico = alturaMin;
		else
			randomico = alturaMax;
		
		
		for (int i=0; i< max; i++) {
			
			if(!blocos[i].activeSelf){
				tempBloco=blocos[i];
				break;
			}
		}
		
		if(tempBloco!=null){
			tempBloco.transform.position = new Vector3(11.22814f, randomico, tempBloco.transform.position.z);
			tempBloco.SetActive(true);
			
		}
		
		
	}
	
	public float GetTempo(){
		return tempo;
	}
	
	public void SetTempo(float t){
		tempo = t;
	}*/
}
