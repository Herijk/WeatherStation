public class Sensor
{
    public int Id { get; private set; }
    public string Type { get; set; }
    public DateTime MeasurementDate { get; set; }
    private static int counter;

    public Sensor() {
        counter++;
    } 
}