using Notes.Core.Budget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Core.Goals;

class GoalsService
{
    private BudgetService budgetService;
    private IGoalRepo goalsRepo;

    public GoalsService
    (
        BudgetService budgetService,
        IGoalRepo goalsRepo
    )
    {
        this.budgetService = budgetService;
        this.goalsRepo = goalsRepo;
    }

    public void addGoal(CreateGoalDto dto) => this.goalsRepo.addGoal(dto);

    public GoalViewDto getGoal(int id)
    {
        var goal = goalsRepo.getById(id);

        var aggregatedSummary = budgetService.getAggregatedSummary();

        int reached = 0;
        foreach (var aggregatedSummaryItem in aggregatedSummary) reached += aggregatedSummaryItem.summary;

        int remainder = goal.amount - reached;

        var summary = budgetService.getSummary();

        int currentMonth;
        Int32.TryParse(DateTime.Now.ToString("MM"), out currentMonth);
        int goalMonth = currentMonth;

        foreach(var monthSummary in summary)
        {
            if (monthSummary.month < currentMonth) continue;
            remainder -= monthSummary.income;
            goalMonth = monthSummary.month;
            if (remainder <= 0) break;
        }

        return new GoalViewDto
        {
            name = goal.name,
            amount = goal.amount,
            reached = reached,
            remainder = remainder,
            trend = new DateTime((int)DateTime.Now.Year, goalMonth, 0),
            deadline = DateTime.Parse(goal.deadline.ToString())
        };
    }
}
