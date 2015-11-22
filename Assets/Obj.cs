using UnityEngine;
using System.Collections;

public class Obj : MonoBehaviour {

    private float timer;

	// Use this for initialization
	void Start () {
        timer = 0f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, new Vector3(0f, 0f, 0f), timer / 20f);
        timer += Time.deltaTime;
	}
}
