using System.Collections.Generic;

namespace Scripting
{



    // Creates dictionary for our list of actions 
    public class Script
    {

        private Dictionary<string, List<Action>> actions = new Dictionary<string, List<Action>>();

    
    // Creates instance of Script
    public Script()
    {

    }
    // Adds Action to my list of actions 
    public void AddAction(string group, Action action)
    {
        if(!actions.ContainsKey(group))
        {
            actions[group] = new List<Action>();

        }
        
        if (!actions[group].Contains(action))
        {
            actions[group].Add(action);

        }
    }
    // Gets my list of Actions 
    public List<Action> GetActions(string group)
    {
        List<Action> results = new List<Action>();
        if (actions.ContainsKey(group))
        {
            results.AddRange(actions[group]);

        }
        return results;
    }

// Removes an action from our list.
    public void RemoveActor(string group, Action action)
    {
        if (actions.ContainsKey(group))
        {

            actions[group].Remove(action);
        }

    }


    }
}

