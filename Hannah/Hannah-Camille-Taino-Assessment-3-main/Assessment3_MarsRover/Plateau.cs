namespace Assessment3_MarsRover
{
    public class Plateau
    {

        private static int _maxx;
        private static int _maxy;
        public Plateau(int _maxx, int _maxy)
        {
            Plateau._maxx = _maxx;
            Plateau._maxy = _maxy;
        }
        public static int getMaxx()
        {
            return _maxx;
        }

        public static int getMaxy()
        {
            return _maxy;
        }
    }
}