
using PROJECTPAIN;

using System;
using System.Xml.XPath;

namespace Goals_PRG281_project
{
    
    internal class Navigation: INavigator
    {
        private GoalManager _goalManager;

        public Navigation()
        {
         
        }

        public void GotoMainMenu()
        {
            frmMainMenu mainMenu = new frmMainMenu();
            mainMenu.ShowDialog();
        }

        public void GotoCurrentGoals()
        {
            frmCurrent_goals currentGoals = new frmCurrent_goals(_goalManager);
            currentGoals.ShowDialog();
        }

        public void GotoGoalSettings()
        {
            frmGoal_setting goalSetting = new frmGoal_setting();
            goalSetting.ShowDialog();
        }

        public void GotoExistingBudget()
        {
            frmExistingBudgetScreen1 existingbudget = new frmExistingBudgetScreen1();
            existingbudget.ShowDialog();
        }

        public void GotonOptimizeMeal()
        {
            frmLinprog optminze = new frmLinprog();
            optminze.ShowDialog();     
        }
        public void GoToTrackExpenses()
        {
            frmExpenseTracker expenseTracker = new frmExpenseTracker();
            expenseTracker.ShowDialog();
        }

        public void GoToDetailedExpenses()
        {
            frmViewDetailedExpenses frmViewDetailedExpenses = new frmViewDetailedExpenses();    
            frmViewDetailedExpenses.ShowDialog();   

        }

        public void GoToBudget()
        {
            frmBudgetSetup frmBudgetSetup = new frmBudgetSetup();   
            frmBudgetSetup.ShowDialog();

        }
        public void DisplaySplash()
        {
            frmLoadingScreen frmLoadingScreen = new frmLoadingScreen();
            frmLoadingScreen.ShowDialog();

        }


    }
}
