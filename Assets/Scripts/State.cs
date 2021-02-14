﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(10,30)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;

    public string GetStateStory() {
        return storyText;
    }

    public State[] GetNextStates() {
        return nextStates;
    }
}
