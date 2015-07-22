using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class Ball : MonoBehaviour {

	public event EventHandler BallInPlay;

	
	public void OnBallInPlay(BallEventArgs e)
	{

	
		EventHandler ballInPlay=BallInPlay;
		
		Debug.Log(ballInPlay);
		
		if(ballInPlay!=null)
			ballInPlay(this,e);
	}
	
	public void SetBat(Bat bat)
	{
		bat.Init(new Bat.BatCallback(OnBallInPlay));
	}
}

public class BallEventArgs : EventArgs
{
	public int Trajectory { get; set; }
	public int Distance { get; set; }
	
	public BallEventArgs(int distance, int trajectory)
	{
		this.Trajectory=trajectory;
		this.Distance=distance;
	}
}