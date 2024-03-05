using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PSPM_MathQuiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void FinishQuiz()
        {

        }

        private async void ViewScoresClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ScoresPage());
        }

        private void DisplayFinalResults()
        {
            finishGameView.IsVisible = true;
            gameView.IsVisible = false;
            questionLabel.IsVisible = false;
            answerEntry.IsVisible = false;
            submitAnswerButton.IsVisible = false;
            resultPoints.Text = currentScore.ToString();
            resultTime.Text = totalTime.ToString("F2");
        }

        private void SaveResults(string userName, double totaltime, int score)
        {
            App.Database.SaveResultsAsync(userName, totaltime, score);
        }
    }
}
