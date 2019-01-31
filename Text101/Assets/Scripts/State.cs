using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [TextArea(14,10)][SerializeField] string story;
    [SerializeField] State[] nextState;

    public State[] GetNextState()
    {
        return nextState;
    }

    public string GetStory()
    {
        return story;
    }
	
}
