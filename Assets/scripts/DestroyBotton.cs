using UnityEngine;
using System.Collections;

public class DestroyBotton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (PublicStatic.SUTEFURI <= 0) {
			Destroy(gameObject);
		}
	}
}
