private DateTime _lastActivity;

public DateTime LastActivity
{
    get { return _lastActivity; }
    set
    {
        // Potential validation or additional logic can be added here
        _lastActivity = value;
    }
}
