
using System.Security.Cryptography.X509Certificates;

public class Resume {
    public string _member = "";
    public List<Job> _Joblist = new List<Job>();


    public void Display()
    {   
        Console.WriteLine($"{_member}");
        Console.WriteLine("Jobs: ");
        foreach ( Job j in _Joblist){
            j.DysplayInformation();
            
        }
    }
}