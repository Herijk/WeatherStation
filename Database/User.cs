public class User {
    public int Id { get; private set; }
    public string Name { get; set; }
    private static int counter;
    public User(string name, int id) { 
        Name = name; 
        Id = id;

        counter++;
    }
}
