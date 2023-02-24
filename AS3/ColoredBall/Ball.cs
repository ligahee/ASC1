namespace ColoredBall;

public class Ball
{
    private int size;
    private Color color;
    private int throwCount;

    public Ball(int size, Color color)
    {
        this.size = size;
        this.color = color;
        this.throwCount = 0;
    }

    public Ball(int size, int red, int green, int blue, int alpha = 255)
        : this(size, new Color(red, green, blue, alpha))
    {
        
    }

    public void Pop()
    {
        size = 0;
    }

    public void Throw()
    {
        if (size != 0)
        {
            throwCount++;
        }
    }

    public int GetThrowCount()
    {
        return throwCount;
    }

    public Color GetColor()
    {
        return color;
    }
    
    

}