
public class Reference
{

    private string _reference1;

    private string _reference2;

    private string _reference3;


    public Reference(string reference, int num)
    {
        if (num == 1)
        {
            reference = _reference1;
        }
        else if (num == 2)
        {
            reference = _reference2;
        }
        else
        {
            reference = _reference3;
        }
        
    }
}





