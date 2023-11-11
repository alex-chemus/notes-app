using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core.Goals;

class Goal
{
    public int id { get; set; }
    public string deadline { get; set; }
    public int amount { get; set; }
    public string name { get; set; }
}

record CreateGoalDto
{
    public int id { get; init; }
    public DateTime deadline { get; init; }
    public int amount { get; set; }
    public string name { get; set; }
}

interface IGoalRepo
{
    public void addGoal(CreateGoalDto dto);
    public Goal getById(int id);
}

record GoalViewDto
{
    public string name { get; init; }
    public int amount { get; init; }
    public int reached { get; init; }
    public int remainder { get; init; }
    public DateTime trend { get; init; }
    public DateTime deadline { get; init; }
}