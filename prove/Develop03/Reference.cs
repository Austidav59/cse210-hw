
public class Reference
{
    private List<string> _references = new List<string>();

    

    
    public void SetReference(string reference)
    {
        _references.Add(reference)
    }

    public string GetReference(int referenceIndex)
    {
        return _references[referenceIndex]
    }
}