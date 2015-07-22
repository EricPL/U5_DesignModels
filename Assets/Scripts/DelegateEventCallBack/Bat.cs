using UnityEngine;
using System;
using System.Collections;

public class Bat : MonoBehaviour {

	public delegate void BatCallback(BallEventArgs e);
	private BatCallback hitBallCallback;
	
	private Ball ball;
	
	public void Init(BatCallback callBackDelegate)
	{
		this.hitBallCallback+=callBackDelegate;
		
	}
	
	public void HitTheBall(BallEventArgs e)
	{
		if(hitBallCallback!=null){
			Debug.Log("Hit the ball");
			
			hitBallCallback(e);
		}
		
	}
	
}
