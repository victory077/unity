using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PublicStatic : MonoBehaviour {
	public static int SUTEFURI = 5;
	public static int OriginPHP = 100;
	public static int OriginSTR = 10;
	public static int OriginVIT = 10;
	public static int OriginINT = 10;
	public static int OriginMID = 10;
	public static int OriginLUK = 30;
	public static int EXP;
	public static float Next = 4;
	public Text SUTEFURIDisplay;
	public Text HPDisplay;
	public Text STRDisplay;
	public Text VITDisplay;
	public Text INTDisplay;
	public Text MIDDisplay;
	public Text LUKDisplay;

	// Use this for initialization
	void Start () {
		STRDisplay.text = OriginSTR.ToString ();
		INTDisplay.text = OriginINT.ToString ();
		VITDisplay.text = OriginVIT.ToString ();
		MIDDisplay.text = OriginMID.ToString ();
		LUKDisplay.text = OriginLUK.ToString ();
		HPDisplay.text = OriginPHP.ToString ();
		SUTEFURIDisplay.text = SUTEFURI.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void STRUP ()
	{
		OriginSTR++;
		STRDisplay.text = OriginSTR.ToString ();
		SUTEFURI--;
		SUTEFURIDisplay.text = SUTEFURI.ToString ();
	}
	public void INTUP ()
	{
		OriginINT++;
		INTDisplay.text = OriginINT.ToString ();
		SUTEFURI--;
		SUTEFURIDisplay.text = SUTEFURI.ToString ();
	}
	public void VITUP ()
	{
		OriginVIT++;
		VITDisplay.text = OriginVIT.ToString ();
		SUTEFURI--;
		SUTEFURIDisplay.text = SUTEFURI.ToString ();
	}
	public void MIDUP ()
	{
		OriginMID++;
		MIDDisplay.text = OriginMID.ToString ();
		SUTEFURI--;
		SUTEFURIDisplay.text = SUTEFURI.ToString ();
	}
	public void LUKUP ()
	{
		OriginLUK++;
		LUKDisplay.text = OriginLUK.ToString ();
		SUTEFURI--;
		SUTEFURIDisplay.text = SUTEFURI.ToString ();
	}
	public void PHPUP ()
	{
		OriginPHP = OriginPHP + 5;
		HPDisplay.text = OriginPHP.ToString ();
		SUTEFURI--;
		SUTEFURIDisplay.text = SUTEFURI.ToString ();
	}
}
