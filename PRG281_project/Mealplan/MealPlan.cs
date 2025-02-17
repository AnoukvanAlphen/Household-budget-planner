using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SolverFoundation.Services;

public class MealPlan
{
    private List<FoodItem> foodItems;
    private double targetCalories;
    private double targetProtein;
    private double targetCarbs;
    private double targetFat;
    private RichTextBox _richTextBox;

    // Delegate declaration
    public delegate void MealPlanSolvedEventHandler(object sender, EventArgs e);

    // Event declaration
    public event MealPlanSolvedEventHandler MealPlanSolved;

    // Constructor that takes the food items, targets, and the RichTextBox
    public MealPlan(List<FoodItem> foodItems, double targetCalories, double targetProtein, double targetCarbs, double targetFat, RichTextBox richTextBox)
    {
        this.foodItems = foodItems;
        this.targetCalories = targetCalories;
        this.targetProtein = targetProtein;
        this.targetCarbs = targetCarbs;
        this.targetFat = targetFat;
        this._richTextBox = richTextBox;
    }

    private string SanitizeName(string name)
    {
        // Replace invalid characters with underscores
        return new string(name.Select(c => char.IsLetterOrDigit(c) || c == '_' ? c : '_').ToArray());
    }

    public void Solve()
    {
        
        // Create a new SolverContext
        var solverContext = SolverContext.GetContext();
        solverContext.ClearModel();
        var model = solverContext.CreateModel();

        // Define decision variables
        var quantities = new Dictionary<string, Decision>();
        foreach (var item in foodItems)
        {
            var sanitizedName = SanitizeName(item.Name);
            var quantity = new Decision(Domain.RealNonnegative, sanitizedName);
            quantities[sanitizedName] = quantity;
            model.AddDecision(quantity);
        }

        // Define the objective function: minimize total cost
        var costExpression = quantities.Values
            .Select(q => q * foodItems.First(f => SanitizeName(f.Name) == q.Name).Price)
            .Aggregate((sum, term) => sum + term);
        model.AddGoal("MinimizeCost", GoalKind.Minimize, costExpression);

        // Add constraints for nutritional goals
        var caloriesConstraint = quantities.Values
            .Select(q => q * foodItems.First(f => SanitizeName(f.Name) == q.Name).Calories)
            .Aggregate((sum, term) => sum + term);
        model.AddConstraint("CaloriesConstraint", caloriesConstraint >= targetCalories);

        var proteinConstraint = quantities.Values
            .Select(q => q * foodItems.First(f => SanitizeName(f.Name) == q.Name).Protein)
            .Aggregate((sum, term) => sum + term);
        model.AddConstraint("ProteinConstraint", proteinConstraint >= targetProtein);

        var carbsConstraint = quantities.Values
            .Select(q => q * foodItems.First(f => SanitizeName(f.Name) == q.Name).Carbs)
            .Aggregate((sum, term) => sum + term);
        model.AddConstraint("CarbsConstraint", carbsConstraint >= targetCarbs);

        var fatConstraint = quantities.Values
            .Select(q => q * foodItems.First(f => SanitizeName(f.Name) == q.Name).Fat)
            .Aggregate((sum, term) => sum + term);
        model.AddConstraint("FatConstraint", fatConstraint >= targetFat);

        // Solve the model
        var solution = solverContext.Solve();

        // Output results to RichTextBox
        _richTextBox.AppendText("Optimal Meal Plan:\n\n");
        foreach (var item in foodItems)
        {
            var sanitizedName = SanitizeName(item.Name);
            var quantity = quantities[sanitizedName].ToDouble();
            if (quantity > 0)
            {
                // Multiply by 100 to get grams
                _richTextBox.AppendText($"{item.Name}: {quantity * 100:F2} grams\n");
            }
        }

        // Display the nutritional goals in grams
        _richTextBox.AppendText($"\nTarget Protein: {targetProtein} grams\n");
        _richTextBox.AppendText($"Target Carbs: {targetCarbs} grams\n");
        _richTextBox.AppendText($"Target Fat: {targetFat} grams\n");

        // Display the total cost with 'R' prefix
        _richTextBox.AppendText($"\nTotal Cost: R {solution.Goals.First(g => g.Name == "MinimizeCost").ToDouble():F2}");

        // Raise the event
        OnMealPlanSolved(EventArgs.Empty);
    }

    // Protected virtual method to raise the event
    protected virtual void OnMealPlanSolved(EventArgs e)
    {
        MealPlanSolved?.Invoke(this, e);
    }

   
}
