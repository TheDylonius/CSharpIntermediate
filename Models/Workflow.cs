using System;
using System.Collections.Generic;

namespace CSharpIntermediate.Models
{
    class Workflow
    {
        private readonly List<IActivity> _activities = new List<IActivity>();

        public void Execute()
        {
            if (_activities == null)
                throw new InvalidOperationException("You must first configure some activities for the workflow.");

            foreach (var activity in _activities)
                activity.Run();
        }

        public void AddActivity(IActivity activity)
        {
            if (activity == null)
                throw new ArgumentNullException("activity");

            _activities.Add(activity);
        }
    }
}