using Assessment3_MarsRover.Controllers;

namespace Assessment3_MarsRover
{
    public class Mars
    {
        private static Queue<Rover> RoverQueue = new Queue<Rover>();
        public static Queue<Rover> getRoverQueue()
        {
            return RoverQueue;
        }

        private static Queue<Controller> ControllerQueue = new Queue<Controller>();
        public static Queue<Controller> getControllerQueue()
        {
            return ControllerQueue;
        }

        static void Main(string[] args)
        {
            MarsHelper.readFromfile(args);
            List<string> printRovers = getFinalCoordinates(RoverQueue, ControllerQueue);
            foreach(string s in printRovers)
            {
                Console.WriteLine(s);
            }
        }
        private static List<string> getFinalCoordinates(Queue<Rover> roverQueue, Queue<Controller> controllerQueue)
        {
            List<string> output = new List<string>();
            Queue<Rover> roverQueueCoordinates = new Queue<Rover>(RoverQueue);
            Queue<Controller> controllerQueueCoordinates = new Queue<Controller>(ControllerQueue);

            while (!(roverQueueCoordinates.Count() == 0))
            {
                Rover rover = roverQueueCoordinates.Peek();
                Controller controller = controllerQueueCoordinates.Peek();
                string commands = controller.Commands();
                foreach(char follow in commands)
                {
                    switch (follow)
                    {
                        case 'L':rover.spinLeft();
                            break;
                        case 'R':rover.spinRight();
                            break;
                        case 'M':rover.advance();
                            break;
                    }
                }
                output.Add(rover.getXcoord() + " " + rover.getYcoord() + " " + rover.getDirection());

                roverQueue.Dequeue();
                controllerQueueCoordinates.Dequeue();
            }
            return output;
        }
    }
}
