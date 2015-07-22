using UnityEngine;
using System.Collections;
using System;

public class Pitcher : MonoBehaviour {

	public Pitcher(Ball ball)
	{
		//ball.BallInPlay+=new EventHandler(ball_BallInPlay);
		ball.BallInPlay+=ball_BallInPlay;
	}
	
	public void Init(Ball ball)
	{
		ball.BallInPlay+=ball_BallInPlay;
	}
	
	
	void ball_BallInPlay(object sender, EventArgs e)
	{
		Debug.Log(gameObject.name+" handle ball event");
		
		if(e is BallEventArgs)
		{
			BallEventArgs ballEventArgs= e as BallEventArgs;
			if((ballEventArgs.Distance<100) && (ballEventArgs.Trajectory<50))
			{
				CatchBall();
			}
			else
			{
				CoverFirstBall();
			}
		}
	}
	
	private void CatchBall()
	{
		Debug.Log(gameObject.name+" catch ball");
	}
	
	private void CoverFirstBall()
	{
		Debug.Log(gameObject.name+" cover the ball");
	}
	
}
