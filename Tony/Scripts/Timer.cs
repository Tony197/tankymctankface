using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Timer : MonoBehaviour 
{

	public Text timerText;
	private float secondsCount;
	private float minuteCount;
	private int hourCount;


	void Update()
	{
		UpdateTimerUI();
	}


//call this on update
	public void UpdateTimerUI()
	{
		//set timer UI
		secondsCount += Time.deltaTime;
		timerText.text = (int)minuteCount + "m:" + (int)secondsCount + "s";
		if (secondsCount >= 60) 
		{
			minuteCount++;
			secondsCount = 0;
		} else if (minuteCount >= 1) 
		{
			timerText.text = "Game Ended";
		}

	}

}
