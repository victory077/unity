using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class enemy : MonoBehaviour {
	float timer;
	public int AReload;
	public int HP;
	public Text PlayerHP;
	public AudioClip SEffect;
	// Use this for initialization
	void Start () {
		HP = 3;
		PlayerHP.text = HP.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer > AReload) 
		{
			Debug.Log("yeah");
			timer = 0;
			HP--;
			PlayerHP.text = HP.ToString ();
			GetComponent<AudioSource>().PlayOneShot (SEffect);
		}
		if (HP <= 0)
		{
			Application.LoadLevel("gameover");
		}
	}
}
