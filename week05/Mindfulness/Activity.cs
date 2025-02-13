class Activity
{
    protected string _title;
    protected string _description;

    public Activity(string title, string description)
    {
        _title = title;
        _description = description;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public virtual void Run()
    {
        // Default behavior
    }
}