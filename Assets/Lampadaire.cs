using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Lampadaire : MonoBehaviour {

    private Slider health;
    private Light light;

	// Use this for initialization
	void Start () {
        health = Canvas.FindObjectOfType<Slider>();
        light = GameObject.FindObjectOfType<Light>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter (Collider collider)
    {
        Destroy(collider.gameObject);
        if (light.intensity > 1f)
        {
            health.value -= 2f;
        }
    }
}
