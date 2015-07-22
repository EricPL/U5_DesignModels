using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : Singleton<GameManager> {

	public Text distanceText;
	public Text trajectoryText;
	
	private int distanceNumber;
	private int trajectoryNumber;
	
	public GameObject ballObject;
	public GameObject PitcherObject;
	public GameObject FanObject;
	
	private Ball ballScript;
	private GameObject pitcher;
	private GameObject fan;
	
	public Bat bat;
	
	public void ClickPlayBallButton()
	{
		distanceNumber=int.Parse(distanceText.text);
		trajectoryNumber=int.Parse(trajectoryText.text);
		
		ballScript=GameObject.Instantiate(ballObject).GetComponent<Ball>();
		
		ballScript.SetBat(bat);
		
		pitcher=GameObject.Instantiate(PitcherObject) as GameObject;
		pitcher.GetComponent<Pitcher>().Init(ballScript);
		
		
		fan=GameObject.Instantiate(FanObject) as GameObject;
		fan.GetComponent<Fan>().Init(ballScript);
		
		bat.HitTheBall(new BallEventArgs(distanceNumber,trajectoryNumber));
		//ballScript.OnBallInPlay(new BallEventArgs(distanceNumber,trajectoryNumber));
	}
	
	
}
