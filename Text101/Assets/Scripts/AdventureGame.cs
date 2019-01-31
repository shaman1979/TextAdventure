using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text storyText;

    [SerializeField] State startState;

    State state;

    private void Start()
    {
        state = startState;
        storyText.text = state.GetStory();
    }

    private void Update()
    {
        StoryNext();
    }

    private void StoryNext()
    {
        var nextStory = state.GetNextState();

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            state = nextStory[0];
        }

        else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            state = nextStory[1];
        }

        storyText.text = state.GetStory();
    }
}
