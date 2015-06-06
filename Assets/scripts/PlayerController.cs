using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public int Move;
	public float encounter;
	public string enemyname;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (transform.position);
	}
	public void UP()
	{
		float a = transform.position.z;
		if (14 > a) {
			transform.position += new Vector3 (0, 0,Move);
		}
		Encount ();
	}
	public void DOWN()
	{
		float a = transform.position.z;
		if (a > 4){
			transform.position += new Vector3 (0,0,-Move);
		}
		Encount ();
	}
	public void RIGHT()
	{
		float b = transform.position.x;
		if (b < 8) 
		{
			transform.position += new Vector3 (Move, 0, 0);
		}
		Encount ();
	}
	public void LEFT()
	{
		float b = transform.position.x;
		if (2 < b) {
			transform.position += new Vector3 (-Move, 0, 0);
		}
		Encount ();
	}
	void Encount (){
		encounter ++;
		int random = Random.Range (0, 30+PublicStatic.OriginLUK);
		if (encounter > random) {
			Application.LoadLevel(enemyname);
			encounter = 0;
		}
	}
}
