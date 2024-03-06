namespace MVCmovie.Models;
public class Person 
{
        public Person(string personID, string address) 
        {
            this.PersonID = personID;
    this.Address = address;
   
        }
            public string PersonID { get; set;}
    public string FullName { get; set;}
    public string Address { get; set;}
}