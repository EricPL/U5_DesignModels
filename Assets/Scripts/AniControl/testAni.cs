using UnityEngine;
using System.Collections;

public class testAni : MonoBehaviour {

	private Animator anim;
	
	int speedHash=Animator.StringToHash("speed");
	int walkState_Hash=Animator.StringToHash("walk");
	public float inputSpeed=0;
	
	void Start()
	{
		anim=GetComponent<Animator>();
	}
	
	void Update()
	{
		anim.SetFloat(speedHash,inputSpeed);
		
		AnimatorStateInfo stateInfo=anim.GetCurrentAnimatorStateInfo(0);
		
		if(stateInfo.shortNameHash==walkState_Hash)
		{
			Debug.Log("walk");
		}
	}
	
	
}
