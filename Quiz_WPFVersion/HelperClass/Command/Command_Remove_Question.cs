﻿using Quiz_WPFVersion.Models;
using Quiz_WPFVersion.ViewModels.Teacher;
using System;

using System.Windows.Input;

namespace Quiz_WPFVersion.HelperClass.Command
{
    public class Command_Remove_Question : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private CreateQuizViewModel vModel;


        public Command_Remove_Question(CreateQuizViewModel vModel)
        {
            this.vModel = vModel;
        }



        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var selObj = parameter as Question_Binding;
            vModel.questionList.Remove(selObj);
        }
    }
}
