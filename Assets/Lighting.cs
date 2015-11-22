using UnityEngine;
using System.Collections;

public class Lighting : MonoBehaviour {

    private Light light;

    private Material lampadaireLightMat;

	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();
        lampadaireLightMat = (GameObject.FindGameObjectWithTag("LampadaireLight") as GameObject).GetComponent<MeshRenderer>().material;
	}
	
	// Update is called once per frame
	void Update () {
        light.intensity = Mathf.Abs(((Input.mousePosition.x - Camera.main.WorldToScreenPoint(transform.position).x) * 8) / Screen.width * 2);
        lampadaireLightMat.color = Color.white * Mathf.Abs(((Input.mousePosition.x - Camera.main.WorldToScreenPoint(transform.position).x)) / Screen.width * 2);
	}
}
