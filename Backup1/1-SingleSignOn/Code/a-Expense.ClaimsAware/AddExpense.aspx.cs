//===============================================================================
// Microsoft patterns & practices
// Cliams Identity Guide V2
//===============================================================================
// Copyright © Microsoft Corporation.  All rights reserved.
// This code released under the terms of the 
// Microsoft patterns & practices license (http://claimsid.codeplex.com/license)
//===============================================================================





namespace AExpense
{
    using System;
    using System.Globalization;
    using System.Web.UI.WebControls;
    using Data;
    using Samples.Web.ClaimsUtilities;

    public partial class AddExpense : BasePage
    {
        protected override System.Collections.Generic.IEnumerable<string> AuthorizedRoles
        {
            get
            {
                return new[] { Adatum.Roles.Employee, Adatum.Roles.Accountant };
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            if (!IsPostBack)
            {
                this.InitializeControls();
            }

            base.OnLoad(e);
        }

        protected void AddExpenseButtonOnClick(object sender, EventArgs e)
        {
            if (this.IsValid)
            {
                this.SaveExpense();
                Response.Redirect("~/Default.aspx", true);
            }
        }

        private void SaveExpense()
        {
            // TODO: add check for CSRF attacks (set ViewStateUserKey = Session.SessionID)
            var user = (User)Session["LoggedUser"];

            var newExpense = new Expense
                                 {
                                     Id = Guid.NewGuid(),
                                     Title = this.ExpenseTitle.Text,
                                     Description = this.ExpenseDescription.Text,
                                     CostCenter = user.CostCenter,
                                     Amount = Convert.ToDecimal(this.ExpenseAmount.Text, CultureInfo.CurrentUICulture),
                                     Approved = false,
                                     ReimbursementMethod = (ReimbursementMethod)Enum.Parse(typeof(ReimbursementMethod), this.ExpenseReimbursementMethod.SelectedItem.Value),
                                     User = user,
                                     Date = DateTime.Parse(this.ExpenseDate.Text, CultureInfo.CurrentUICulture)
                                 };

            var expenseRepository = new ExpenseRepository();
            expenseRepository.SaveExpense(newExpense);

            user.PreferredReimbursementMethod = (ReimbursementMethod)Enum.Parse(typeof(ReimbursementMethod), this.ExpenseReimbursementMethod.SelectedValue);
            var userRepository = new UserRepository();
            userRepository.UpdateUserPreferredReimbursementMethod(user);
        }

        private void InitializeControls()
        {
            var user = (User)Session["LoggedUser"];

            this.ExpenseReimbursementMethod.Items.Add(new ListItem("Check", ReimbursementMethod.Check.ToString()));
            this.ExpenseReimbursementMethod.Items.Add(new ListItem("Cash", ReimbursementMethod.Cash.ToString()));
            this.ExpenseReimbursementMethod.Items.Add(new ListItem("Direct Deposit", ReimbursementMethod.DirectDeposit.ToString()));
            if (user.PreferredReimbursementMethod != ReimbursementMethod.NotSet)
            {
                this.ExpenseReimbursementMethod.SelectedValue = user.PreferredReimbursementMethod.ToString();
            }

            this.ExpenseCostCenter.Text = user.CostCenter;
        }
    }
}