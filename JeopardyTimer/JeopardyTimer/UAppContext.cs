using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JeopardyTimer
{
    public class UAppContext : ApplicationContext
    {


        public UAppContext()
        {

            // Handle the ApplicationExit event to know when the application is exiting.
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            
            
            // Create both application forms and handle the Closed event 
            // to know when both forms are closed.
            Program.timerBar.Closed += new EventHandler(OnFormClosed);
            Program.scoreBoard.Closed += new EventHandler(OnFormClosed);
            
            

            // Show both forms.
            Program.scoreBoard.Show();
            Program.timerBar.Show();
        }

        private void OnApplicationExit(object sender, EventArgs e) {
            
        }


        private void OnFormClosed(object sender, EventArgs e)
        {
            // When a form is closed, decrement the count of open forms. 

            // When the count gets to 0, exit the app by calling 
            // ExitThread().
            ExitThread();
        }
    }
}
