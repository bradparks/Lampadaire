using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

    public GameObject obj;
    private float spawnTimer;

    private Slider health;
    private Text gameOver;
    private Light light;

	// Use this for initialization
	void Start () {
        spawnTimer = 0f;

        health = Canvas.FindObjectOfType<Slider>();
        gameOver = Canvas.FindObjectOfType<Text>();
        light = GameObject.FindObjectOfType<Light>();
	}
	
	// Update is called once per frame
	void Update () {
        if (spawnTimer >= 2f)
        {
            if (Random.value > 0.5f)
            {
                Instantiate(obj, new Vector3(50f, 10f, 0f), Quaternion.identity);
            }
            else
            {
                Instantiate(obj, new Vector3(-50f, 10f, 0f), Quaternion.identity);
            }
            spawnTimer = 0f;
        }
        else
        {
            spawnTimer += Time.deltaTime;
        }

        if (light.intensity < 1f)
        {
            health.value -= 1f * Time.deltaTime;
        }

        if (health.value <= 0f)
        {
            gameOver.enabled = true;
        }
	}
}
