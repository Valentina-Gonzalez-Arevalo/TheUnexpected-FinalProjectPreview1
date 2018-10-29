using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class TimerScript : MonoBehaviour {

	public Text contador;
	private float tiempo = 10f;

	// Use this for initialization
	void Start () {
		contador.text = "" + tiempo;


		
	}
	
	// Update is called once per frame
	void Update () {
		tiempo -= Time.deltaTime;
		contador.text = "" + tiempo.ToString("f0");
		
	}
}
