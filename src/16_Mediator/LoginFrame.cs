using System;

namespace Mediator
{
    //public partial class LoginFrame : Form, IMediator
    //{
    //    public LoginForm()
    //    {
    //        InitializeComponent();
    //        CreateColleagues();
    //        ColleagueChanged();
    //    }

    //    public virtual void CreateColleagues()
    //    {
    //        checkGuest.SetMediator(this);
    //        checkLogin.SetMediator(this);
    //        textUser.SetMediator(this);
    //        textPass.SetMediator(this);
    //        buttonOk.SetMediator(this);
    //        buttonCancel.SetMediator(this);
    //    }

    //    public virtual void ColleagueChanged()
    //    {
    //        if (checkGuest.Checked)
    //        {
    //            // Guest 
    //            textUser.SetColleagueEnabled(false);
    //            textPass.SetColleagueEnabled(false);
    //            buttonOk.SetColleagueEnabled(true);
    //        }
    //        else
    //        {
    //            // Login 
    //            textUser.SetColleagueEnabled(true);
    //            UserPassChanged();
    //        }
    //    }

    //    private void UserPassChanged()
    //    {
    //        if (textUser.Text.Length > 0)
    //        {
    //            textPass.SetColleagueEnabled(true);
    //            if (textPass.Text.Length > 0)
    //            {
    //                buttonOk.SetColleagueEnabled(true);
    //            }
    //            else
    //            {
    //                buttonOk.SetColleagueEnabled(false);
    //            }
    //        }
    //        else
    //        {
    //            textPass.SetColleagueEnabled(false);
    //            buttonOk.SetColleagueEnabled(false);
    //        }
    //    }

    //    private void buttonOk_Click(object sender, EventArgs e)
    //    {
    //        Console.WriteLine(sender + " : " + e.ToString());
    //        Close();
    //    }
    //}
}
