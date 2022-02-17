namespace Assessment3_MarsRover.Controllers
{
    public class Controller
    {
        //to set commands on the rover
        private string commands;
        public Controller(string commands)
        {
            this.commands = commands;
        }

        public string Commands() 
        { 
            return commands; 
        }
    }
}
