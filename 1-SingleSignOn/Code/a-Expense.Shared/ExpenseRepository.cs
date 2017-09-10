//===============================================================================
// Microsoft patterns & practices
// Cliams Identity Guide V2
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://claimsid.codeplex.com/license)
//===============================================================================


namespace AExpense.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Samples.Web.ClaimsUtilities;

    public class ExpenseRepository
    {
        private static readonly ICollection<Expense> ExpensesStore = InitializeExpenseStoreAndAddData();

        public IEnumerable<Expense> GetAllExpenses()
        {
            return ExpensesStore;
        }

        public IEnumerable<Expense> GetExpenses(Guid userId)
        {
            return ExpensesStore.Where(expense => expense.User.Id == userId).OrderBy(expense => expense.Date);
        }

        public void SaveExpense(Expense expense)
        {
            ExpensesStore.Add(expense);
        }

        public void UpdateApproved(Expense updatedExpense)
        {
            var expense = ExpensesStore.Single(e => e.Id == updatedExpense.Id);
            expense.Approved = updatedExpense.Approved;
        }

        private static ICollection<Expense> InitializeExpenseStoreAndAddData()
        {
            var expensesStoreList = new List<Expense>();

            expensesStoreList.Add(
                new Expense
                    {
                        Id = new Guid("ABAFC874-D0CC-4245-9319-1E5A75108A41"), 
                        User = UserRepository.JohnDoe, 
                        Title = "Dinner", 
                        Description = "Dinner with new employee", 
                        Amount = 125.25m, 
                        Date = new DateTime(2009, 08, 25), 
                        Approved = false, 
                        CostCenter = Adatum.CostCenters.CustomerService, 
                        ReimbursementMethod = ReimbursementMethod.Check
                    });

            expensesStoreList.Add(
                new Expense
                    {
                        Id = new Guid("ABAFC874-D0CC-4245-9319-1E5C77158B42"), 
                        User = UserRepository.JohnDoe, 
                        Title = "Dinner", 
                        Description = "Dinner with customer", 
                        Amount = 200.5m, 
                        Date = new DateTime(2009, 08, 25), 
                        Approved = false, 
                        CostCenter = Adatum.CostCenters.CustomerService, 
                        ReimbursementMethod = ReimbursementMethod.Check
                    });

            expensesStoreList.Add(
                new Expense
                    {
                        Id = new Guid("ABAFC874-A0CC-4145-9319-1E5C78508A41"), 
                        User = UserRepository.JohnDoe, 
                        Title = "Breakfast", 
                        Description = "Breakfast with the team", 
                        Amount = 75.9m, 
                        Date = new DateTime(2009, 08, 23), 
                        Approved = true, 
                        CostCenter = Adatum.CostCenters.CustomerService, 
                        ReimbursementMethod = ReimbursementMethod.Check
                    });

            expensesStoreList.Add(
                new Expense
                {
                    Id = new Guid("D8DBF994-1654-43DE-8C3D-7C2A062F6AE2"),
                    User = UserRepository.Angel,
                    Title = "Hotel",
                    Description = "1 night at Hyatt Regency, Phoenix, AZ",
                    Amount = 168.0m,
                    Date = new DateTime(2017, 08, 21),
                    Approved = true,
                    CostCenter = Adatum.CostCenters.Accountancy,
                    ReimbursementMethod = ReimbursementMethod.DirectDeposit
                });

            expensesStoreList.Add(
                new Expense
                {
                    Id = new Guid("D56B7AF3-85FE-4397-95C6-B448624C7368"),
                    User = UserRepository.Angel,
                    Title = "Meals",
                    Description = "lunch at Chili's, Phoenix, AZ",
                    Amount = 17.50m,
                    Date = new DateTime(2017, 08, 22),
                    Approved = true,
                    CostCenter = Adatum.CostCenters.Accountancy,
                    ReimbursementMethod = ReimbursementMethod.DirectDeposit
                });


            return expensesStoreList;
        }
    }
}