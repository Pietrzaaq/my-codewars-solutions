using System.Linq;

public class KataGetReadableTime
{
    public  string GetReadableTime(int seconds)
    {
        string hours = ((int) (seconds / 3600)).ToString().PadLeft(2, '0');
        seconds = (seconds % 3600);
        string minutes = ((int) (seconds / 60)).ToString().PadLeft(2, '0');
        seconds = (seconds % 60);

        return $"{hours}:{minutes}:{seconds.ToString().PadLeft(2, '0')}";
    }
}