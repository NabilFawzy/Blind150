public class TaskManager {
    // Dictionary to store tasks by taskId
    private Dictionary<int, (int userId, int priority)> taskDict;
    
    // sorted set to efficiently track tasks for execution
    private SortedSet<(int priority, int taskId, int userId)> taskSet;

    public TaskManager(IList<IList<int>> tasks) {
        taskDict = new Dictionary<int, (int userId, int priority)>();
        taskSet = new SortedSet<(int priority, int taskId, int userId)>(Comparer<(int priority, int taskId, int userId)>.Create((a, b) => {
            if(a.priority != b.priority) {
                return b.priority.CompareTo(a.priority); // Higher priority first
            }

            if (a.taskId != b.taskId)
                return b.taskId.CompareTo(a.taskId);     // Higher taskId first
            return a.userId.CompareTo(b.userId);         // Arbitrary tie-breaker
        }));

        foreach (var task in tasks) {
            int userId = task[0], taskId = task[1], priority = task[2];
            Add(userId, taskId, priority);
        }
    }
    
    public void Add(int userId, int taskId, int priority) {
        // Add task to dictionaries
        taskDict[taskId] = (userId, priority);
        taskSet.Add((priority, taskId, userId));
    }
    
    public void Edit(int taskId, int newPriority) {
        if (taskDict.TryGetValue(taskId, out var task))
        {
            // Remove old entry from taskSet
            taskSet.Remove((task.priority, taskId, task.userId));

            // Update taskDict
            taskDict[taskId] = (task.userId, newPriority);

            // Add updated entry to taskSet
            taskSet.Add((newPriority, taskId, task.userId));
        }
    }
    
    public void Rmv(int taskId) {
        if (taskDict.TryGetValue(taskId, out var task)) {
            // remove from both dictionaries
            taskSet.Remove((task.priority, taskId, task.userId));
            taskDict.Remove(taskId);
        }
    }
    
    public int ExecTop() {
        if (taskSet.Count == 0)
            return -1; // No tasks available

        // Get the highest-priority task
        var topTask = taskSet.First();

        // Remove it from the system
        taskSet.Remove(topTask);
        taskDict.Remove(topTask.taskId);

        // Return the userId associated with the task
        return topTask.userId;
    }
}

/**
 * Your TaskManager object will be instantiated and called as such:
 * TaskManager obj = new TaskManager(tasks);
 * obj.Add(userId,taskId,priority);
 * obj.Edit(taskId,newPriority);
 * obj.Rmv(taskId);
 * int param_4 = obj.ExecTop();
 */