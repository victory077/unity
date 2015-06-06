using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class RPG : MonoBehaviour {
	public float Lag;
	public float Timer;
	public string Win;
	public string LevelUp;
	public string Lose;
	public Text PHPDisplay;
	public Text EHPDisplay;
	public Text EDamageDisplay;
	public Text DamageDisplay;
	public int PHP;
	public int VIT;
	public int STR;
	public int INT;
	public int MID;
	public int LUK;
	public int EHP;
	public int EVIT;
	public int ESTR;
	public int EINT;
	public int EMID;
	public int ELUK;
	public int EEXP;
	public int ATK;
	public int Damage;
	public int EDamage;
	public int Bonus;
	// Use this for initialization
	void Start () {
		PHP = PublicStatic.OriginPHP;
		STR = PublicStatic.OriginSTR;
		VIT = PublicStatic.OriginVIT;
		INT = PublicStatic.OriginINT;
		MID = PublicStatic.OriginMID;
		LUK = PublicStatic.OriginLUK;
		ATK = STR;
		PHPDisplay.text = PHP.ToString ();
		EHPDisplay.text = EHP.ToString ();
	}
	
	// Update is called once per frame
	void Update () {
		Timer += Time.deltaTime;
		if (EHP <= 0)
		{
			PublicStatic.EXP = EEXP + PublicStatic.EXP;
			if(PublicStatic.EXP > PublicStatic.Next)
			{
				PublicStatic.Next = PublicStatic.Next * 1.5f;
				Application.LoadLevel (LevelUp);
				PublicStatic.SUTEFURI = Bonus;
				PublicStatic.EXP = 0;
			}else
			{
				Application.LoadLevel(Win);
			}
		} else if (PHP <= 0) 
		{
			Application.LoadLevel(Lose);
		}
	}
	void EnemyAttack()
	{
		int random = Random.Range (0, 3);
		if (random < 2) 
		{
			int random1 = Random.Range (0, 99);
			int random2 = Random.Range (-2, ESTR); 
			if (random1 < ELUK) 
			{
				Damage = ESTR * 2 - VIT;
				DamageDisplay.text = Damage.ToString ();
				PHP = PHP - Damage;
				PHPDisplay.text = PHP.ToString ();
			} else if(random1 > LUK / 6)
			{
				Damage = ESTR - VIT;
				DamageDisplay.text = Damage.ToString ();
				PHP = PHP - Damage;
				PHPDisplay.text = PHP.ToString ();
			} else
			{
				Damage = 0;
				DamageDisplay.text = Damage.ToString ();
				PHP = PHP - Damage;
				PHPDisplay.text = PHP.ToString ();
			}
		} else 
		{
			Damage = EINT - MID;
			DamageDisplay.text = Damage.ToString ();
			PHP = PHP - Damage;
			PHPDisplay.text = PHP.ToString ();
		}
	}
	public void charge()
	{
		if (Timer > Lag) 
		{
			ATK = STR + ATK;
			Invoke ("EnemyAttack", Lag);
		}
		Timer = 0;
	}
	public void attack()
	{
		int random = Random.Range (0, 99);
		if (Timer > Lag) {
			int random1 = Random.Range (-3, STR);
			if (random < LUK) 
			{
				EDamage = Mathf.FloorToInt (ATK * 1.5f + random1 - EVIT);
				EDamageDisplay.text = EDamage.ToString ();
				EHP = EHP - EDamage;
				EHPDisplay.text = EHP.ToString ();
			} else
			{
				EDamage = ATK + random1 - EVIT;
				EDamageDisplay.text = EDamage.ToString ();
				EHP = EHP - EDamage;
				EHPDisplay.text = EHP.ToString ();
			}
			ATK = STR;
			Invoke ("EnemyAttack", Lag);
		}
		Timer = 0;
	}
	public void magic()
	{
		if (Timer > Lag) 
		{
			EDamage = Mathf.FloorToInt (INT * 1.1f - EMID);
			EDamageDisplay.text = EDamage.ToString ();
			EHP = EHP - EDamage;
			EHPDisplay.text = EHP.ToString ();
			Invoke ("EnemyAttack", Lag);
		}
		Timer = 0;
	}
}
