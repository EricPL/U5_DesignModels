using UnityEngine;
using System;
using System.Collections;

public class Fan : MonoBehaviour {

	public Fan(Ball ball)
	{
		ball.BallInPlay+=ball_BallInPlay;
	}
	
	public void Init(Ball ball)
	{
		ball.BallInPlay+=ball_BallInPlay;
	}
	
	
	void ball_BallInPlay(object sender, EventArgs e)
	{
		if(e is BallEventArgs)
		{
			BallEventArgs ballEventArgs=e as BallEventArgs;
			
			if(ballEventArgs.Distance>400 && ballEventArgs.Trajectory<30)
			{
				Crazy();
			}
		}
	}
	
	private void Crazy()
	{
		Debug.Log(gameObject.name+" Crazy");
	}
	
	
	
	
}
