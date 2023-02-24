using ColoredBall;

public class Program
{
    static void Main(String[] args)
    {
        Ball redBall = new Ball(10,255,0,0);
        Ball blueBall = new Ball(20, 0, 0, 255);
        redBall.Throw();
        redBall.Throw();
        blueBall.Throw();
        blueBall.Throw();
        blueBall.Throw();
        
        redBall.Pop();
        redBall.Throw();
        Console.WriteLine("Red ball thrown {0} times", redBall.GetThrowCount());
        Console.WriteLine("Blue ball thrown {0} times", blueBall.GetThrowCount());

        Ball yellowBall = new Ball(10, new Color(255, 255, 0));
        Color yellowColor = yellowBall.GetColor();
        Console.WriteLine("Yellow ball grayscale value {0}",yellowColor.GetGrayscaleValue());
    }
}