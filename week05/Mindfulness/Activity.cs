using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Net.Security;

class Activity{
    string _title;
    string _description;
    public Activity(string title, string description){
    
        _title = title;
        _description = description;
    }

    public string GetTitle() {
        return _title;

    }
    public string GetDescription(){
        return _description;
    }

    virtual public void Run(){
    }
}