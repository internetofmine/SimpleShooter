using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicWorldGenerator : MonoBehaviour {

    bool initialized = false;

    LevelLayout level;//Level will consist of an array of informations about level like enemy density, wing formations and types, for automatic generation.
                      //Will also contain informations in a form of array about backgrounds in levels existing in games. 
                      //Each level will provide a chance to build up - equipement, lives and score, for a moment when you run out of level information.
                      //Once end of the array is met, generator will go 
                      //full jenkins and generate stuff more randomly in more ramping difficulties.
                      //Level should have a midpoint at which game starts generating next level, to ensure smooth transition
    
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!initialized)
            return;

	}

    private bool IsSwitchConditionMet()
    {

    }

    private bool GenerateNextLevel()
    {

    }
}

