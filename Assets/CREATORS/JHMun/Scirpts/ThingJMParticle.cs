﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThingJMParticle : Thing {

	// Use this for initialization
	//SetTarget, Vector3
	//StopMoving
	//SetRandomTarget - float area 
	//Protected , other function cannot intrude

	//f for float

	protected override void TTTAwake()
	{
		//		base.TTTAwake();
		// how far the following camera will be from muy object
		cameraOffset = 15;
		acceleration = 2f;
		drag = 1.0f; //the bigger the drag is, the slower your thing moves
		mass = 0.2f;


		getNewDestinationInterval = 5; //in seconds
		newDestinationRange = 40;

		myCubeColor = new Color (1, 0.2f, 0); //r, g, b  0-1


	}
	protected override void TTTStart()
	{
		//		base.TTTStart ();
		//		everything in this code block will only be executed once

		Speak ("Uh La La ~! Moon is here.");
		InvokeRepeating ("RandomSetDestination", 0f, 10f);
	}

	protected override void TTTUpdate()
	{
		//		base.TTTUpdate();
		//		everythin inside this code block will be exe many times
		//		about ~60sec
	}
		
		//	below are MakeAllRainbow events
		
	protected override void OnMeetingSomeone ( GameObject other)
	{
//		base.OnMeetingSomeone (other);
//		everything inside this code block willl be triggered/called
//		when my thing meets anyine
		Speak ("Get out of my way!!!!");
		PlaySound ("zapsplat_multimedia_game_collect_pick_up_tone_17875");

	}

	protected override void OnLeavingSomeone( GameObject other)
	{
		//	base.OnLeavingSomeone (other);
		InvokeRepeating ("RandomeSetDestination", 2f, 10f);
		PlaySound ("zapsplat_multimedia_game_ascend_climb_jump_synthesized_17873");
	}

	protected override void OnSunset ()
	{
//		this code will be triggered when sunis set
		//		base.OnSeunset();
		Speak ("I need the moon back~");
		Spark (Color.yellow, 50);

	}
	protected override void OnSunrise ()
	{
		ChangeColor (Color.red);
	}
	protected  override void OnTouchWater()
	{
		//		base.OnTouchWater();
	}

	protected override void OnLeaveWater()
	{
		ResetColor ();
	}

	protected override void OnNeighborSpeaking()
	{
	}

	protected override void OnNeigborSparkingParticles()
	{
		//base.OnNeigborSparkingParticles();
	}

}

