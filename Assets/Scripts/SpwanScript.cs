using UnityEngine;
using System.Collections;

public class SpwanScript : MonoBehaviour {

    public GameObject[] obj;
    public float spwanMin = 1f;
    public float spwanMax = 2f;
	// Use this for initialization
	void Start () {
        Spwan();
	}
	
	// Update is called once per frame
	void Spwan () {
        Instantiate(obj[Random.Range(0, obj.GetLength(0))], transform.position, Quaternion.identity);
        Invoke("Spwan",Random.Range(spwanMin, spwanMax));
	}
}
